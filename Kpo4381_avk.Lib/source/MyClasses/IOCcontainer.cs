using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Kpo4381_avk.Lib
{ 
    public static class IOCcontainer
    {
        public static WindsorContainer container { get; private set; }

        static IOCcontainer()
        {
            switch (AppGlobalSettings.searchProjectFactory)
            {
                case "splitFile":
                    container = new WindsorContainer();
                    container.Register(Component
                        .For<ISearchProjectListLoader>()
                        .ImplementedBy<SearchProjectListSplitFileLoader>()
                        .LifeStyle.Singleton
                        );
                    container.Register(Component
                        .For<ISearchProjectListSaver>()
                        .ImplementedBy<SearchProjectListSplitFileSaver>()
                        .LifeStyle.Singleton
                        );
                    break;
                case "test":
                    container = new WindsorContainer();
                    container.Register(Component
                        .For<ISearchProjectListLoader>()
                        .ImplementedBy<SearchProjectListTestLoader>()
                        .LifeStyle.Singleton
                        );
                    container.Register(Component
                        .For<ISearchProjectListSaver>()
                        .ImplementedBy<SearchProjectListTestSaver>()
                        .LifeStyle.Singleton
                        );
                    break;
                default:
                    container = new WindsorContainer();
                    container.Register(Component
                        .For<ISearchProjectListLoader>()
                        .ImplementedBy<SearchProjectListSplitFileLoader>()
                        .LifeStyle.Singleton
                        );
                    container.Register(Component
                        .For<ISearchProjectListSaver>()
                        .ImplementedBy<SearchProjectListSplitFileSaver>()
                        .LifeStyle.Singleton
                        );
                    break;
            }

        }
    }
}
