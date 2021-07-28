using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Bussiness.Absract
{
    public interface IDirectoryService
    {
        List<Directory> GetAll();
        List<Directory> GetDirectoriesByNameAndSurname(string nameAndSurname);
        void Delete(Directory directory);
        void Add(Directory directory);
        void Update(Directory directory);
    }
}
