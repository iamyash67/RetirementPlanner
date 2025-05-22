using Microsoft.Extensions.DependencyInjection;
using RPT.Services;
using RPT.Services.Interfaces;
using RPT.Repositories.Interfaces;
using RPT.Repositories;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Add CORS services BEFORE app.Build()
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Database connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSingleton(connectionString);

// Repositories
builder.Services.AddScoped<IGoalRepository, GoalRepository>();
builder.Services.AddScoped<IFinancialYearDataRepo, FinancialYearDataRepo>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IGoalService, GoalService>();
builder.Services.AddScoped<IFinancialYearDataService, FinancialYearDataService>();

// Swagger & Controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 2️⃣ Use CORS EARLY in middleware pipeline (BEFORE UseAuthorization)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend"); // 🔥 Must be before any authorization/authentication

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
