using ModeloApi.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//add services to the container
builder.Services.AddDbContext<AgendaContext>(options => 
  options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))); 

builder.Services.AddControllers();

builder.Services.AddControllersWithViews();

builder.Services.AddEndPointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Enviroment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.HttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
