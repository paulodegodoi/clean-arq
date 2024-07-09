using CleanArq.Domain.Entities;

namespace CleanArq.Domain.Contracts.UseCases.AddCustomer;

public interface IAddCustomerUseCase
{
    void AddCustomer(Customer  customer);
}