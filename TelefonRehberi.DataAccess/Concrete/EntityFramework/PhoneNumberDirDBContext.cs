using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.DataAccess.Concrete.EntityFramework
{
    public class PhoneNumberDirDBContext:DbContext
    {
        public PhoneNumberDirDBContext():base("PhoneNumberDirDB")
        {

        }
        public DbSet<Directory> Directories { get; set; }
    }
}
