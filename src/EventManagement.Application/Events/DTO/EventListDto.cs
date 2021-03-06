using Abp.AutoMapper;
using AutoMapper.Configuration.Annotations;
using System;

namespace EventManagement.Events
{
    [AutoMapFrom(typeof(Models.Events))]
    [AutoMapTo(typeof(Models.Events))]
    public class EventListDto
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