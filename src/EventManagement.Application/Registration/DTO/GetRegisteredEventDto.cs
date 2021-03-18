using Abp.AutoMapper;
using AutoMapper.Configuration.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Registration.DTO
{
    [AutoMapFrom(typeof(Models.Events))]
    public class GetRegisteredEventDto
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }

        public virtual DateTime Eventdate { get; set; }

        public virtual string Venue { get; set; }

        public virtual DateTime Reg_start_date { get; set; }

        public virtual DateTime Reg_end_date { get; set; }

        [SourceMember(nameof(Models.Events.CreatorUserId))]
        public virtual long CreatorId { get; set; }
    }
}
