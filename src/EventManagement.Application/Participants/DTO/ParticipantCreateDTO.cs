using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Participants.DTO
{
    public class ParticipantCreateDTO:IHasCreationTime
    {
        [EmailAddress]
        public virtual string Email { get; set; }

        //[MaxLength(10)]
        //[MinLength(10)]
        [StringLength(10)]
        public virtual string Phone { get; set; }

        
        public DateTime CreationTime { get; set; }
    }
}
