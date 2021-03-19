using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EventManagement.Events.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Events
{
    public interface IEventService:IApplicationService
    {
        Task<ListResultDto<EventListDto>> GetAll(GetAllInput input);

        Task<PagedResultDto<EventListDto>> GetAllPaged(GetAllInput input);
        Task<int> CreateEvent(EventCreateDTO input);

        void UpdateEvent(EventUpdateDTO input);

        void DeleteEvent(int id);

        Task<EventUpdateDTO> Get(int id);

        Task<List<int>> GetRegistrationCount();
    }
}
