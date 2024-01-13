using Microsoft.EntityFrameworkCore;
using SampleWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//////////////////////////////DB Context Dependency Injection////////////////////////////////////////////////////////////
var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbPwd = Environment.GetEnvironmentVariable("DB_PWD");

var conString = $"Data Source={dbServer}; Initial Catalog=customerdb; User Id = sa; Password=apple@123#; Integrated Security = True; TrustServerCertificate=True";
builder.Services.AddDbContext<CustomerDbContext>(options=>options.UseSqlServer(conString));
/////////////////////////////////////////////////////////////////////////////////////////////////////
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

app.UseAuthorization();

app.MapControllers();

app.Run();
