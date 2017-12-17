using EmojiApp.Infrastructure.IoC;
using EmojiApp.Infrastructure.MVVM;
using EmojiApp.Infrastructure.Native;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmojiApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel, IViewModel
    {
        #region Props
        private string _textToSpeak;

        public string TextToSpeak
        {
            get => _textToSpeak;
            set
            {
                if (_textToSpeak != value)
                {
                    _textToSpeak = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _displayMessage;

        public string DisplayMessage
        {
            get => _displayMessage;
            set
            {
                if (_displayMessage != value)
                {
                    _displayMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    OnPropertyChanged();
                    ShowBusy.ChangeCanExecute();
                }
            }
        }
        #endregion

        #region Commands 
        public Command ShowBusy { get; }

        private async Task OnShowBusy()
        {
            IsBusy = true;
            await Task.Delay(5000);
            IsBusy = false;
        }

        public Command Speak { get; }

        public Command Version { get; }
        #endregion

        public MainPageViewModel()
        {
            IsBusy = false;
            ShowBusy = new Command(async () => await OnShowBusy(), () => !IsBusy);
            Speak = new Command(async () =>
            {
                ITextToSpeech textToSpeech = IoCContainerFactory.GetContainer().Get<ITextToSpeech>();

                //bool result=await App.Current.MainPage.DisplayAlert("Will speak",String.Format("Using version {0}",textToSpeech.Version()),"Ok","Cancel");
                textToSpeech.Speak(TextToSpeak);
            });

        }
    }
}
