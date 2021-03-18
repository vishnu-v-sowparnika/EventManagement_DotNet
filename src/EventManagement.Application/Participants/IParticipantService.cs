using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EventManagement.Participants.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Participants
{
    public interface IParticipantService : IApplicationService
    {
        Task<PagedResultDto<ParticipantListDTO>> GetAll(GetAllInputDTO input);

        Task<int> Register(ParticipantCreateDTO input);

        Task<ParticipantListDTO> Get(int Id);
    }
}
