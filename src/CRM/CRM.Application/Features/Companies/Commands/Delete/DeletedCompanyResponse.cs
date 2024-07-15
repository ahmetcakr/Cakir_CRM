using Core.Application.Responses;

namespace CRM.Application.Features.Companies.Commands.Delete;

public class DeletedCompanyResponse : IResponse
{
    public int Id { get; set; }
}
