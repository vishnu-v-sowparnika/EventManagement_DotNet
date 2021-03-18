using Abp.Application.Services.Dto;

namespace EventManagement.Events
{
    public class GetAllInput:PagedResultRequestDto
    {
        public string CreatorId { get; set; }

        public string Keyword { get; set; }
        
    }
}