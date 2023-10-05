using Cleiteam.API.Configuration;
using Cleiteam.CrossCutting.AutoMapper;
using Cleiteam.CrossCutting.DependencyContainer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapperConfiguration();
builder.Services.AddIdentityConfig(builder.Configuration);
builder.Services.AddSwaggerConfig();
builder.Services.RegisterServices(builder.Configuration);
builder.Services.AddAutoMapperConfiguration();

var app = builder.Build();

app.UseApiConfiguration(app.Environment);


app.Run();