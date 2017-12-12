using EmojiApp.Infrastructure.MVVM;

namespace EmojiApp.Infrastructure.Page
{
    public class BaseContentPage<T> : global::Xamarin.Forms.ContentPage
            where T : IViewModel
    {
        protected readonly IViewModel _viewModel;

        public BaseContentPage()
        {
        }

        public BaseContentPage(IViewModel viewModel)
        {
            _viewModel = viewModel;
        }
    }
}
