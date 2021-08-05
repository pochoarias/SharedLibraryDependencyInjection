using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryConsumer.DependencyResolution
{
    public static class Bootstrapper
    {
        private static IContainer _container;

        private static void InitContainer()
        {

            var container = new Container(config =>
            {
                config.AddRegistry<CommonRegistry>();
                config.AddRegistry<ExternalRegistry>();
            });

            var what = container.WhatDoIHave();
            _container = container;
        }

        public static IContainer GetContainer()
        {
            if (_container == null)
                InitContainer();

            return _container;

        }
    }
}
