using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EventManagement.Events;
using EventManagement.Registration.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Registration
{
    interface IRegistrartionService:IApplicationService
    {
        Task<int> RegisterEvent(RegistrationInputDto input);

        void UnregisterEvent(RegistrationInputDto input);

     //   Task<ListResultDto<GetRegisteredEventDto>> GetRegisteredEvents();

        Task<PagedResultDto<EventListDto>> GetRegisteredEvents(DTO.GetAllInput input);
        // Task <ListResultDto<EventListDto>>  
    }
}
