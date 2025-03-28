using StoreProject.ClientRoutes;
using StoreProject.Data;


Console.Clear();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
builder.Services.AddScoped<ClientContext>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ClientRoutes();

app.UseHttpsRedirection();
app.Run();

// var clients = new List<Client>
// {
// new("Junior", "123123123", 312323123),
// new("Carlos Alberto", "1231231231", 1321212),
// new("Silvio Abravanel", "531231125", 1231231231),
// new("Adriano da Silva", "5125125121",312312331),
// };

// Console.WriteLine("-- Cadastro de Clientes --");
// for (int i = 0; i < 4; i++)
//     Console.WriteLine(clients[i]);
