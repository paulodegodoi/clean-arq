using CleanArq.Domain.Entities;

namespace CleanArq.Domain.Contracts.Repositories;

public interface IAddCustomerRepository
{
    public void AddCustomer(Customer customer);
}