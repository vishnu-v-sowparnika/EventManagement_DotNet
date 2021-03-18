using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Participants.DTO
{
    public class ParticipantListDTO
    {
        public virtual int Id { get; set; }
        [EmailAddress]
        public virtual string Email { get; set; }

        //[MaxLength(10)]
        //[MinLength(10)]
        [StringLength(10)]
        public virtual string Phone { get; set; }

        [Display(Name = "Event Title")]

        public virtual int? EventId { get; set; }

        public virtual Models.Events Event { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
