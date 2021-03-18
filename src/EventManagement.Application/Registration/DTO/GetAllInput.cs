using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Registration.DTO
{
    public class GetAllInput:PagedResultRequestDto
    {
        public virtual string Keyword { get; set; }
        public virtual string EventId { get; set; }

        public virtual string ParticipantId { get; set; }
    }
}
