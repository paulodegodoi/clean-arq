using CleanArq.Domain.Contracts.Repositories;
using CleanArq.Domain.Contracts.UseCases.AddCustomer;
using CleanArq.Domain.Entities;

namespace CleanArq.Application.UseCases.AddCustomer;

public class AddCustomerUseCase : IAddCustomerUseCase
{
    private readonly IAddCustomerRepository _addCustomerRepository;

    public AddCustomerUseCase(IAddCustomerRepository addCustomerRepository)
    {
        _addCustomerRepository = addCustomerRepository;
    }

    public void AddCustomer(Customer customer)
    {
        _addCustomerRepository.AddCustomer(customer);
    }
}