using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using pokeMongo.Domain;
using pokeMongo.Infra;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection(nameof(MongoDbSettings)));
builder.Services.AddSingleton<MongoDbSettings>();


builder.Services.AddSingleton<IRepository, Repository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapPost("/pessoa/buscar", async ([FromBody] Pessoa body, IRepository repository) =>
{
    repository.Create(body);
});

app.Run();
