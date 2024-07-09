using CleanArq.Domain.Contracts.Repositories;
using CleanArq.Domain.Entities;

namespace CleanArq.Infrastructure.Repositories.AddCustomer;

public class AddCustomerRepository : IAddCustomerRepository
{
    private readonly IList<Customer> _customers = new List<Customer>();
    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
}