using MediatR;
using Microsoft.AspNetCore.Builder;
using OrderCustomer_Managment.Infrastructure.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

// 1. controladores
builder.Services.AddControllers();

// 2. Swagger 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);

// 4.  MediatR
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
});

var app = builder.Build();

// 5Middleware de Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();