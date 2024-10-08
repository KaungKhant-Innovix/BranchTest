// Program.cs
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Branches Conflict Test API",
        Description = "A simple example ASP.NET Core Web API for testing branches and conflicts"
    });
});

//Comment added by main
//Another comment added by main
//comment added by dev_kk
//another comment added by dev_kk

//Comment to delete dev branch

//Comment 1

//Comment 2

//Comment 3

<<<<<<< HEAD
//Comment 4 by Main

//Comment 5 by Main

=======
//Comment 4 added by dev_kk

//Comment 5 added by dev_kk
>>>>>>> dev_kk


// Register custom services
builder.Services.AddScoped<BranchesConflictTest.Services.ProductService>();
builder.Services.AddScoped<BranchesConflictTest.Services.OrderService>();
builder.Services.AddScoped<BranchesConflictTest.Services.CustomerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Branches Conflict Test API V1");
        c.RoutePrefix = string.Empty; // Set Swagger UI to root path (optional)
    });
}

// Configure the HTTP request pipeline.
app.UseAuthorization();

app.MapControllers();

app.Run();
