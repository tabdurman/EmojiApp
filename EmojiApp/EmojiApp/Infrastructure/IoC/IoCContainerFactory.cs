using Ninject;
using Ninject.Modules;
using System;

namespace EmojiApp.Infrastructure.IoC
{
    public class IoCContainerFactory
    {
        private static IKernel _container;
        

        public static void Init()
        {
            if (_container == null)
                _container = new Ninject.StandardKernel();
        }

        public static void Init(INinjectModule[] modules)
        {
            if (_container==null)
                _container = new Ninject.StandardKernel(modules);
        }

        public static void Init(NinjectModule module)
        {
            var settings = new NinjectSettings();
            settings.LoadExtensions = false;

            if (_container == null)
                _container = new Ninject.StandardKernel(settings,module);
        }

        public static IKernel GetContainer()
        {
            if (_container == null)
                throw new ApplicationException("Initialize containerFirst");
            return _container;
        }

    }
}
