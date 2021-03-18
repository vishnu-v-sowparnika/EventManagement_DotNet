using Abp.Domain.Entities.Auditing;
using EventManagement.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Models
{
   public class Organiser: CreationAuditedEntity<int>
    {
        [Display(Name = "First Name ")]
        public virtual string FName { get; set; }
        [Display(Name = "Last Name")]
        public virtual string LName { get; set; }

        [ForeignKey("AddressId")]
        public virtual int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual User user { get; set; }

        
    }
}
