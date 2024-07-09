using CleanArq.Api.Models;
using CleanArq.Domain.Contracts.UseCases.AddCustomer;
using CleanArq.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArq.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddCustomerController : ControllerBase
{
    private readonly IAddCustomerUseCase _addCustomerUseCase;

    public AddCustomerController(IAddCustomerUseCase addCustomerUseCase)
    {
        _addCustomerUseCase = addCustomerUseCase;
    }

    [HttpPost]
    public IActionResult AddCustomer(AddCustomerInput input)
    {
        var customer = new Customer(input.Name, input.Document, input.Email);
        _addCustomerUseCase.AddCustomer(customer);
        
        return Created("", customer);
    }
}