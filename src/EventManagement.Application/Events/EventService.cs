using System.Linq;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using EventManagement.Events.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Dynamic.Core;



namespace EventManagement.Events
{
    public class EventService : EventManagementAppServiceBase, IEventService
    {
        private readonly IRepository<Models.Events> _eventRepository;
        public EventService(IRepository<Models.Events> eventRepository)
        {
            _eventRepository = eventRepository;
            
        }
        public async Task<ListResultDto<EventListDto>> GetAll(GetAllInput input)
        {

            var query = _eventRepository.GetAll().WhereIf(!input.CreatorId.IsNullOrEmpty(), t => t.CreatorUserId == long.Parse(input.CreatorId)).WhereIf(!input.Keyword.IsNullOrEmpty(),k=>k.Description.Contains(input.Keyword)|| k.Venue.Contains(input.Keyword));
            var eventobj = await query.Take(input.MaxResultCount).Skip(input.SkipCount).ToListAsync();
            //var regcounts=query.Select(x=>x.Registrations.Count)
            var eventdto = ObjectMapper.Map<List<EventListDto>>(eventobj);
            return new PagedResultDto<EventListDto>(query.Count(), eventdto);
           // return  new ListResultDto<EventListDto>(eventdto);
            //throw new NotImplementedException();
        }


        public async Task<PagedResultDto<EventListDto>> GetAllPaged(GetAllInput input)
        {
            var query = _eventRepository.GetAll().WhereIf(!input.CreatorId.IsNullOrEmpty(), t => t.CreatorUserId == long.Parse(input.CreatorId)).WhereIf(!input.Keyword.IsNullOrEmpty(), k => k.Description.Contains(input.Keyword));
            var eventobj = await query.Skip(input.SkipCount).Take(input.MaxResultCount).ToListAsync();
            var eventdto = ObjectMapper.Map<List<EventListDto>>(eventobj);
            return new PagedResultDto<EventListDto>(query.Count(), eventdto);
            // return  new ListResultDto<EventListDto>(eventdto);
            //throw new NotImplementedException();
        }

        public async Task<int> CreateEvent(EventCreateDTO input)
        {
            var events = ObjectMapper.Map<Models.Events>(input);
          int id= await _eventRepository.InsertAndGetIdAsync(events);
            return id;
           // throw new NotImplementedException();
        }

        public void UpdateEvent(EventUpdateDTO input)
        {
            var events = _eventRepository.Get(input.Id);
            ObjectMapper.Map(input, events);
            return;
        }

        public async  void DeleteEvent(int eventId)
        {
            await _eventRepository.DeleteAsync(eventId);
            return;
        }

        public async Task<EventUpdateDTO> Get(int id)
        {
            var myevent= await _eventRepository.GetAsync(id);
            return ObjectMapper.Map<EventUpdateDTO>(myevent);
        }

        public async Task<List<int>> GetRegistrationCount()
        {
            throw new NotImplementedException();
            var query = await _eventRepository.GetAll().Include(x=>x.Registrations).Select(x => x.Registrations.Count).ToListAsync();
            return query;
        }
    }
}
