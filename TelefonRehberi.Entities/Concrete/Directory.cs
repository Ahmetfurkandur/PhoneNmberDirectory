using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Absract;

namespace TelefonRehberi.Entities.Concrete
{
    [Table("Directory")]
    public class Directory:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string NameAndSurname { get; set; }
        public string EmailAdress { get; set; }
        public long PhoneNumber { get; set; }

    }
}
