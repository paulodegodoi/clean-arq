namespace CleanArq.Domain.Entities;

public class Customer
{
    public Customer(string name, string document, string email)
    {
        Name = name;
        Document = document;
        Email = email;
    }

    public string Name { get; private set; }
    public string Document { get; private set; }
    public string Email { get; private set; }
}