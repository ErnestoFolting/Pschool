global using Microsoft.EntityFrameworkCore;
using PschoolBackend.Middlewares;
using PschoolBackend_BLL.DTOs.MappingProfiles;
using PschoolBackend_BLL.Services;
using PschoolBackend_BLL.Services.Interfaces;
using PschoolBackend_DAL;
using PschoolBackend_DAL.Interfaces;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient",
        builder =>
        {
            builder.WithOrigins("https://localhost:7296")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        }); 
});

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IParentService, ParentService>();
builder.Services.AddScoped<IParentCoupleService, ParentCoupleService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(StudentProfile)), Assembly.GetAssembly(typeof(ParentProfile)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.MapControllers();

app.UseCors("AllowBlazorClient");

app.Run();
