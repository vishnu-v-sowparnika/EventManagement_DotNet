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
    public class Registration : CreationAuditedEntity<int>, IHasCreationTime,ISoftDelete,IMustHaveTenant
    {

        [ForeignKey("EventId")]
        public virtual int EventId { get; set; }
        public virtual Models.Events Event { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsDeleted { get; set; }
        public int TenantId { get ; set ; }
    }
}
