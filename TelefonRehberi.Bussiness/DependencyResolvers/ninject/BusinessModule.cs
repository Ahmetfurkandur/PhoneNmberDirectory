using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Bussiness.Absract;
using TelefonRehberi.Bussiness.Concrete;
using TelefonRehberi.DataAccess.Absract;
using TelefonRehberi.DataAccess.Concrete.EntityFramework;

namespace TelefonRehberi.Bussiness.DependencyResolvers.ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDirectoryService>().To<DirectoryManager>();
            Bind<IDirectoryDal>().To<EfDirectoryDal>();
        }
    }
}
