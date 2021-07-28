using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Bussiness.Absract;
using TelefonRehberi.Bussiness.Utilities;
using TelefonRehberi.Bussiness.ValidationRules.FluentValidation;
using TelefonRehberi.DataAccess.Absract;
using TelefonRehberi.Entities.Concrete;


namespace TelefonRehberi.Bussiness.Concrete
{
    public class DirectoryManager:IDirectoryService
    {
        private IDirectoryDal _directoryDal;
        public DirectoryManager(IDirectoryDal directoryDal)
        {
            _directoryDal = directoryDal;
        }

        //add operation
        public void Add(Directory directory)
        {
            ValidationTool.FluentValidate(new DirectoryValidator(),directory);
            _directoryDal.Add(directory);
        }
        //delete operation
        public void Delete(Directory directory)
        {
            _directoryDal.Delete(directory);
        }


        public List<Directory> GetAll()
        {
            return _directoryDal.GetAll().ToList();
        }

        public List<Directory> GetDirectoriesByNameAndSurname(string nameAndSurname)
        {
            return _directoryDal.GetAll(d => d.NameAndSurname.Contains(nameAndSurname));
        }
        //Update operation
        public void Update(Directory directory)
        {
            ValidationTool.FluentValidate(new DirectoryValidator(), directory);
            _directoryDal.Update(directory);
        }
    }
}
