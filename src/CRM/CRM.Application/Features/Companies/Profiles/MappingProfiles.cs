using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using CRM.Application.Features.Companies.Commands.Create;
using CRM.Application.Features.Companies.Commands.Delete;
using CRM.Application.Features.Companies.Commands.Update;
using CRM.Application.Features.Companies.Queries.GetById;
using CRM.Application.Features.Companies.Queries.GetList;
using CRM.Domain.Entities;

namespace CRM.Application.Features.Companies.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Company, CreatedCompanyResponse>().ReverseMap();
        CreateMap<Company, CreateCompanyCommand>().ReverseMap();

        CreateMap<Company, UpdatedCompanyResponse>().ReverseMap();
        CreateMap<Company, UpdateCompanyCommand>().ReverseMap();

        CreateMap<Company, DeletedCompanyResponse>().ReverseMap();
        CreateMap<Company, DeleteCompanyCommand>().ReverseMap();

        CreateMap<Company, GetByIdCompanyResponse>().ReverseMap();
        CreateMap<Company, GetByIdCompanyQuery>().ReverseMap();

        CreateMap<Company, GetListCompanyResponse>().ReverseMap();
        CreateMap<Company, GetListCompanyQuery>().ReverseMap();

        CreateMap<IPaginate<Company>, GetListResponse<GetListCompanyResponse>>().ReverseMap();
    }
}
