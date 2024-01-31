using Microsoft.Extensions.Options;
using MongoDB.Driver;

using Elanco_API.Services;
using Elanco_API.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<StoreDatabaseSettings>(
                builder.Configuration.GetSection(nameof(StoreDatabaseSettings)));

builder.Services.AddSingleton<IStoreDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<StoreDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
        new MongoClient(builder.Configuration.GetValue<string>("StoreDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<Http_Requests, Functionality>();



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Swagger here used in developer environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// i put swagger outside of if statements aswell to be used after deployment 
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
