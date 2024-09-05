

using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Controllers;
using WebApplication1.DbContexts;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddLogging();

//builder.Services.AddTransient<DBConnect, DBConnect>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionstring = builder.Configuration.GetConnectionString("MyNewContextString");
builder.Services.AddDbContext<MyNewContext>(options=>options.UseMySql(connectionstring,ServerVersion.AutoDetect(connectionstring)));

builder.Services.AddTransient<ShopService, ShopService>();

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

