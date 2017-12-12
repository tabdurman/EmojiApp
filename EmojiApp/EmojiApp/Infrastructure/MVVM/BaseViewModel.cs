using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmojiApp.Infrastructure.MVVM
{
    public abstract class BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string Name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}
