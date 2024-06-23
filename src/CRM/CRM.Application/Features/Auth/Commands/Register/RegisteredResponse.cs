using Core.Application.Responses;

namespace CRM.Application.Features.Auth.Commands.Register;

public class RegisteredResponse : IResponse
{
    public string Message { get; set; }

    public RegisteredResponse()
    {
        Message = string.Empty;
    }

    public RegisteredResponse(string message)
    {
        Message = message;
    }
}
