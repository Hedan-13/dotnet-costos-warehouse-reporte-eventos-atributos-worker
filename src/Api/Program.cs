using Andreani.ARQ.WebHost.Extension;
using Microsoft.AspNetCore.Builder;
using CostosWarehouse.ReporteEventosAtributos.Worker.Application;
using CostosWarehouse.ReporteEventosAtributos.Worker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAndreaniWebHost(args);
builder.Services.ConfigureAndreaniWorkerServices();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.ConfigureAndreaniWorker();

app.Run();
