using Core.Application.Responses;

namespace CRM.Application.Features.UserOperationClaims.Commands.Delete;

public class DeletedUserOperationClaimResponse : IResponse
{
    public int Id { get; set; }
}
