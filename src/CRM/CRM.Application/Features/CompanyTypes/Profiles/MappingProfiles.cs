using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using CRM.Application.Features.CompanyTypes.Commands.Create;
using CRM.Application.Features.CompanyTypes.Commands.Delete;
using CRM.Application.Features.CompanyTypes.Commands.Update;
using CRM.Application.Features.CompanyTypes.Queries.GetById;
using CRM.Application.Features.CompanyTypes.Queries.GetList;
using CRM.Domain.Entities;

namespace CRM.Application.Features.CompanyTypes.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CompanyType, CreatedCompanyTypeResponse>().ReverseMap();
        CreateMap<CompanyType, CreateCompanyTypeCommand>().ReverseMap();

        CreateMap<CompanyType, UpdatedCompanyTypeResponse>().ReverseMap();
        CreateMap<CompanyType, UpdateCompanyTypeCommand>().ReverseMap();

        CreateMap<CompanyType, DeletedCompanyTypeResponse>().ReverseMap();
        CreateMap<CompanyType, DeleteCompanyTypeCommand>().ReverseMap();

        CreateMap<CompanyType, GetByIdCompanyTypeResponse>().ReverseMap();
        CreateMap<CompanyType, GetByIdCompanyTypeQuery>().ReverseMap();

        CreateMap<CompanyType, GetListCompanyTypeResponse>().ReverseMap();
        CreateMap<CompanyType, GetListCompanyTypeQuery>().ReverseMap();

        CreateMap<IPaginate<CompanyType>, GetListResponse<GetListCompanyTypeResponse>>().ReverseMap();
    }
}
