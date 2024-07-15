using AutoMapper;
using CRM.Application.Features.Companies.Rules;
using CRM.Application.Repositories;
using MediatR;

namespace CRM.Application.Features.Companies.Queries.GetById;

public class GetByIdCompanyQuery : IRequest<GetByIdCompanyResponse>
{
    public int Id { get; set; }

    internal sealed class GetByIdCompanyQueryHandler(
        ICompanyRepository companyRepository,
        IMapper mapper,
        CompanyBusinessRules companyBusinessRules) : IRequestHandler<GetByIdCompanyQuery, GetByIdCompanyResponse>
    {

        public async Task<GetByIdCompanyResponse> Handle(GetByIdCompanyQuery request, CancellationToken cancellationToken)
        {
            var company = await companyRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            GetByIdCompanyResponse getByIdCompanyResponse = mapper.Map<GetByIdCompanyResponse>(company);

            return getByIdCompanyResponse;
        }
    }
}
