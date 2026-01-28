using MediatR;
using OrderCustomer_Managment.Infrastructure.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

// --- SERVICIOS ---

// 1. Controladores
builder.Services.AddControllers();

// 2. Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. Capa de Infraestructura 
builder.Services.AddInfrastructure(builder.Configuration);

// 4. MediatR 
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
});

var app = builder.Build();

// --- MIDDLEWARE (EL ORDEN IMPORTA) ---

// 5. Activación de la interfaz de Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Order & Customer API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();