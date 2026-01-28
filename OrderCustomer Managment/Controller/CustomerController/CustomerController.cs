using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderCustomer_Managment.Application.Models.Customer.Commands;
using OrderCustomer_Managment.Application.Models.Customer.Queries;
using OrderCustomer_Managment.Domain.Entities;

namespace OrderCustomer_Managment.Controller.CustomerController;

[ApiController]
[Route("api/[controller]")]

public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;
    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
    {
        var result = await _mediator.Send(command);
        return CreatedAtAction("GetById", new { id = result }, command);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new CustomerGetAllQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new CustomerGetByIdQuery(id);

        var result = await _mediator.Send(query);

        if (result == null)
        {
            return NotFound(new { Message = $"Cliente con ID {id} no encontrado" });
        }

        return Ok(result); ;
    }
}
