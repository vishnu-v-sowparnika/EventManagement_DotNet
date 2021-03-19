using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using EventManagement.Events;
using EventManagement.Registration.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Registration
{
    public class RegistrationService : EventManagementAppServiceBase, IRegistrartionService
    {
        private IRepository<Models.Registration> _registrationRepository;
        private IRepository<Models.Events> _eventRepository;
        public RegistrationService(IRepository<Models.Registration> registrationRepository,IRepository<Models.Events> eventRepository)
        {
            _registrationRepository = registrationRepository;
            _eventRepository = eventRepository;
        }
        public async Task<PagedResultDto<EventListDto>> GetRegisteredEvents(DTO.GetAllInput input)
        {
            //throw new NotImplementedException();
            //var UserId = GetCurrentUserAsync().Id;
            var UserId = AbpSession.UserId;
            var query = _registrationRepository.GetAll().Where(x => x.CreatorUserId == UserId).Include(x => x.Event).Select(x => x.Event);
            var revents =await  query.Skip(input.SkipCount).Take(input.MaxResultCount).ToListAsync();
           // var regevents = await _registrationRepository.GetAll().Where(x => x.CreatorUserId == UserId).Include(x=>x.Event).Select(x=>x.Event).ToListAsync();
            var mappedobj = ObjectMapper.Map<List<EventListDto>>(revents);
            //  return new ListResultDto<EventListDto>(mappedobj); 
            return new PagedResultDto<EventListDto>(query.Count(), mappedobj);
        }

        public async Task<int> RegisterEvent(RegistrationInputDto input)
        {

            //throw new NotImplementedException();
            //var saveobj = ObjectMapper.Map<Models.Registration>(input);
            
            var savevent =await _eventRepository.GetAsync(input.EventId);
            var saveobj = new Models.Registration() { Event = savevent };
            var id=await _registrationRepository.InsertAndGetIdAsync(saveobj);
            return id;
        }

        public async  void UnregisterEvent(RegistrationInputDto input)
        {
             //throw new NotImplementedException();
            var userId = AbpSession.UserId;
            var regobj =await  _registrationRepository.GetAll().Where(x => x.EventId == input.EventId && x.CreatorUserId == userId).FirstOrDefaultAsync();
            await _registrationRepository.DeleteAsync(regobj);

            return;
        }

        
    }
}
