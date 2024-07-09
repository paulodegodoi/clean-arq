using CleanArq.Application.UseCases.AddCustomer;
using CleanArq.Domain.Contracts.Repositories;
using CleanArq.Domain.Contracts.UseCases.AddCustomer;
using CleanArq.Infrastructure.Repositories.AddCustomer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAddCustomerUseCase, AddCustomerUseCase>();
builder.Services.AddSingleton<IAddCustomerRepository, AddCustomerRepository>();
 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
