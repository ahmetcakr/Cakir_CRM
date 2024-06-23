using AutoMapper;
using Core.Security.Entities;
using CRM.Application.Features.Auth.Commands.RevokeToken;

namespace CRM.Application.Features.Auth.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RefreshToken, RevokedTokenResponse>().ReverseMap();
    }
}
