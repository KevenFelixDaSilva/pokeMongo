using Microsoft.Extensions.DependencyInjection;
using pokeMongo.Endpoints;
using pokeMongo.Infra;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
try{
    builder.Services.Configure<MongoDbContext>(
        builder.Configuration.GetSection("MongoDB"));
    Console.WriteLine("MongoDb connect!");
}catch(Exception ex)
{
    Console.WriteLine("Deu ruim!",ex);
}

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/pessoa/buscar", async (MongoDbContext context) =>
{
    string name = "s";
    var result = await PessoaRequest.Find(name);
    return result;
});

app.Run();
