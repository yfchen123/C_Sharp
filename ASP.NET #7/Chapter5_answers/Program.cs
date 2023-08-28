using System.Collections.Concurrent;

/*WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
var people = new List<Person> 
{ 
    new("Tom", "Hanks"), 
    new("Denzel", "Washington"), 
    new("Leondardo", "DiCaprio"), 
    new("Al", "Pacino"), 
    new("Morgan", "Freeman"), 
}; 
app.MapGet("/person/{name}", (string name) => 
people.Where(p => p.FirstName.StartsWith(name))); 
app.Run();*/

//public record Person(string FirstName, string LastName);

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

var _fruit = new ConcurrentDictionary<string, Fruit>();

app.MapGet("/fruit", () => _fruit); 
app.MapGet("/fruit/{id}", (string id) => 
    _fruit.TryGetValue(id, out var fruit) ? TypedResults.Ok(fruit) : Results.NotFound()); 
app.MapPost("/fruit/{id}", (string id, Fruit fruit) =>
    _fruit.TryAdd(id, fruit) ? 
    TypedResults.Created($"/fruit/{id}", fruit) : Results.BadRequest(new { id = "A fruit with this id already exists" }); 
Handlers handlers = new(); 
app.MapPut("/fruit/{id}", (string id, Fruit fruit) =>
{
    _fruit[id] = fruit;
    return Results.NoContent();
}); 
app.MapDelete("/fruit/{id}", (string id) =>
{
    _fruit.TryRemove(id, out _);
return Results.NoContent();
}); 
app.Run();



record Fruit(string Name, int Stock)
{
    public static readonly Dictionary<string, Fruit> All = new();
};
class Handlers
{
    public void ReplaceFruit(string id, Fruit fruit) 
{
        Fruit.All[id] = fruit;
    }
    public static void AddFruit(string id, Fruit fruit) 
{
        Fruit.All.Add(id, fruit);
    }
}