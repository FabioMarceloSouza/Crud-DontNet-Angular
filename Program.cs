using crud_server.Data;
using crud_server.Services;
using crud_server.Services.InterfaceServices;
using crud_server.Validators;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<ContextDatabase>(builder.Configuration.GetConnectionString("CrudDatabase"));
builder.Services.AddScoped<IEmployeeService, EmployeeServices>();
builder.Services.AddScoped<IDepartmentService, DepartmentServices>();
builder.Services.AddControllers().AddFluentValidation(
    config => config.RegisterValidatorsFromAssemblyContaining<EmployeValidator>());
builder.Services.AddControllers().AddNewtonsoftJson( x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);    

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(e => e.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
