using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class Participants:Entity<int>,IHasCreationTime
    {

        [EmailAddress]
        public virtual string Email { get; set; }

        //[MaxLength(10)]
        //[MinLength(10)]
        [StringLength(10)]
        public virtual string Phone { get; set; }

        //[Display(Name = "Event Title")]
        //[ForeignKey("EventId")]
        //public virtual int? EventId { get; set; }

        //public virtual Models.Events Event { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
