using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.NotificadorErros;
using Cleiteam.Identidade.API.Configurations;
using Cleiteam.CrossCutting.DependencyContainer;
using Cleiteam.CrossCutting.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddIdentityConfiguration(builder.Configuration);
builder.Services.AddApiConfiguration();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterServices(builder.Configuration);
builder.Services.AddAutoMapperConfiguration();

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

app.UseSwaggerConfiguration();
app.UseApiConfiguration(app.Environment);

app.Run();
