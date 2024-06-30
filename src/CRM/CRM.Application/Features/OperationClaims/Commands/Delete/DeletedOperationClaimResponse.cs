using Core.Application.Responses;

namespace CRM.Application.Features.OperationClaims.Commands.Delete;

public class DeletedOperationClaimResponse : IResponse
{
    public int Id { get; set; }
}
