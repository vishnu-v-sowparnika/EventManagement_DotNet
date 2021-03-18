using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Events.DTO
{
    [AutoMapFrom(typeof(Models.Events))]
    [AutoMapTo(typeof(Models.Events))]
    public class EventUpdateDTO
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }

        public virtual DateTime Eventdate { get; set; }

        public virtual string Venue { get; set; }

        public virtual DateTime Reg_start_date { get; set; }

        public virtual DateTime Reg_end_date { get; set; }
    }
}
