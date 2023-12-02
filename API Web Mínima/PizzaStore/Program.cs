// Adicione um namespace. Você precisará desse namespace quando você chamar mais tarde SwaggerDoc() e fornecer as informações de cabeçalho para a sua API.
using Microsoft.OpenApi.Models;
using PizzaStore.DB;

var builder = WebApplication.CreateBuilder(args);

// Adicione AddSwaggerGen(). Esse método configura informações de cabeçalho em sua API, como o que é chamado e o número da versão.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
   {
       c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaStore API", Description = "Making the Pizzas you love", Version = "v1" });
   });

var app = builder.Build();
// Adicionar UseSwagger() e UseSwaggerUI(). Essas duas linhas de código informarão ao projeto de API para usar o Swagger e também onde encontrar o arquivo de especificação swagger.json.
app.UseSwagger();
app.UseSwaggerUI(c =>
   {
       c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
   });
app.MapGet("/", () => "Hello World!");

app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
app.MapGet("/pizzas", () => PizzaDB.GetPizzas());
app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));
app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));

app.Run();
