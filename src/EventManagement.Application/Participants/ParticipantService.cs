using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using EventManagement.Participants.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Participants
{
    public class ParticipantService:EventManagementAppServiceBase,IParticipantService
    {
        private IRepository<Models.Participants> _participantRepository;
        public ParticipantService(IRepository<Models.Participants> participantRepository)
        {
            _participantRepository = participantRepository;
        }

        public async Task<ParticipantListDTO> Get(int Id)
        {
            throw new NotImplementedException();
            //return _participantRepository.GetAsync(Id);
        }

        public async Task<PagedResultDto<ParticipantListDTO>> GetAll(GetAllInputDTO input)
        {
            throw new NotImplementedException();
            //var query =  _participantRepository.GetAll().WhereIf(!input.EventId.IsNullOrEmpty(), t => t.EventId == int.Parse(input.EventId));
            //var result =await  query.Take(input.MaxResultCount).Skip(input.SkipCount).ToListAsync();
            //var mapobject = ObjectMapper.Map<List<ParticipantListDTO>>(result);
            //return new PagedResultDto<ParticipantListDTO>(query.Count(), mapobject);

        }

        public async Task<int> Register(ParticipantCreateDTO input)
        {
            //throw new NotImplementedException();
            return 0;
        }

        
    }
}
