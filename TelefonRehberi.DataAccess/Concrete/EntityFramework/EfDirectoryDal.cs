using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.DataAccess.Absract;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.DataAccess.Concrete.EntityFramework
{
    public class EfDirectoryDal:EfRepositoryBase<Directory,PhoneNumberDirDBContext>,IDirectoryDal
    {

    }
}
