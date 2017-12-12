using EmojiApp.Infrastructure.Page;
using EmojiApp.ViewModels;

namespace EmojiApp
{
    public partial class MainPage : BaseContentPage<MainPageViewModel>
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
	}
}
