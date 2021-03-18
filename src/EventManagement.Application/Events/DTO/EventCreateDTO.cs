using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Events.DTO
{
    [AutoMapTo(typeof(Models.Events))]
    public class EventCreateDTO
    {
        public virtual string Description { get; set; }

        public virtual DateTime Eventdate { get; set; }

        public virtual string Venue { get; set; }

        public virtual DateTime Reg_start_date { get; set; }

        public virtual DateTime Reg_end_date { get; set; }
    }
}
