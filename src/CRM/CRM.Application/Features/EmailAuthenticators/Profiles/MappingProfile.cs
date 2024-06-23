using AutoMapper;
using Core.Security.Entities;
using CRM.Application.Features.EmailAuthenticators.Commands.Create;
using CRM.Application.Features.EmailAuthenticators.Commands.Update;

namespace CRM.Application.Features.EmailAuthenticators.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateEmailAuthenticatorCommand, EmailAuthenticator>()
            .ReverseMap();

        CreateMap<UpdateEmailAuthenticatorCommand, EmailAuthenticator>()
            .ReverseMap();
    }
}
