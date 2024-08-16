using Microsoft.Extensions.Configuration;
using DataLibrary;
using DataLibrary.Service;
using Managers.Contracts;
using Managers.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILoadDataService, LoadDataService>();
builder.Services.AddScoped<IAirflowServerManager, AirflowServerManager>();
builder.Services.AddScoped<IDataDescriptionManager, DataDescriptionManager>();
builder.Services.AddScoped<IDataClassificationLevelManager, DataClassificationLevelManage>();
builder.Services.AddScoped<IPersonalDataManager, PersonalDataManager>();
builder.Services.AddScoped<IContainerTypeManager, ContainerTypeManager>();
builder.Services.AddScoped<ISourceTypeManager, SourceTypeManager>();
builder.Services.RegisterDataServices(builder.Configuration);
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
