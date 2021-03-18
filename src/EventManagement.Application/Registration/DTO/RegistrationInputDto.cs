using Abp.AutoMapper;
using EventManagement.Events;

namespace EventManagement.Registration
{
    [AutoMapTo(typeof(Models.Events))]
    public class RegistrationInputDto
    {
        //public virtual int Id { get; set; }
        public virtual int EventId { get; set; }
    }
}