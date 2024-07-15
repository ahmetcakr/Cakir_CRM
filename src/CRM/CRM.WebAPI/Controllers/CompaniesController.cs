using Core.Application.Requests;
using Core.Application.Responses;
using CRM.Application.Features.Companies.Commands.Create;
using CRM.Application.Features.Companies.Commands.Delete;
using CRM.Application.Features.Companies.Commands.Update;
using CRM.Application.Features.Companies.Queries.GetById;
using CRM.Application.Features.Companies.Queries.GetList;
using CRM.Application.Features.Users.Queries.GetList;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : BaseController
    {

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCompanyQuery getByIdCompanyQuery)
        {
            GetByIdCompanyResponse result = await Mediator.Send(getByIdCompanyQuery);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCompanyQuery getListUserQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListCompanyResponse> result = await Mediator.Send(getListUserQuery);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCompanyCommand createCompanyCommand)
        {
            CreatedCompanyResponse result = await Mediator.Send(createCompanyCommand);
            return Created(uri: "", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCompanyCommand  updateCompanyCommand)
        {
            UpdatedCompanyResponse result = await Mediator.Send(updateCompanyCommand);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCompanyCommand deleteCompanyCommand)
        {
            DeletedCompanyResponse result = await Mediator.Send(deleteCompanyCommand);
            return Ok(result);
        }
    }
}
