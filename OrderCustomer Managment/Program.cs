using MediatR;
using Microsoft.AspNetCore.Builder;
using OrderCustomer_Managment.Infrastructure.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

// 1. Mantén los controladores
builder.Services.AddControllers();

// 2. Swagger (Esto evita el error del 'GetSwagger')
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. DESCOMENTA ESTO (Es vital para la migración)
builder.Services.AddInfrastructure(builder.Configuration);

// 4. Agrega MediatR (si tus migraciones dependen de alguna lógica de inicialización)
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