using Abp.Application.Services.Dto;

namespace Taskever.Application.Services.Dto.Friendships
{
    public class UpdateLastVisitTimeInput : IInputDto
    {
        public int FriendUserId { get; set; }
    }
}