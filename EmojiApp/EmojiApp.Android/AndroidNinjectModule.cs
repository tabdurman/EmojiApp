using EmojiApp.Droid.Native;
using EmojiApp.Infrastructure.Native;
using Ninject.Modules;

namespace EmojiApp.Droid
{
    public class AndroidNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITextToSpeech>().To<AndroidTextToSpeech>();
        }
    }
}