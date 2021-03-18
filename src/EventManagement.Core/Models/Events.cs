using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class Events :CreationAuditedEntity<int>,IMustHaveTenant
    {

        public virtual string Description { get; set; }

        public virtual DateTime Eventdate { get; set; }

        public virtual string Venue { get; set; }

        public virtual ICollection<Models.Registration> Registrations { get; set; }

        public virtual DateTime Reg_start_date { get; set; }

        public virtual DateTime Reg_end_date { get; set; }
        public int TenantId { get ; set ; }

        //[ForeignKey("organiserId")]
        //public virtual int? organiserId { get; set; }
        //public virtual Organiser organiser { get; set; }
    }
}
