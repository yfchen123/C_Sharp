using Microsoft.AspNetCore.Mvc;
/*WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
app.MapGet("/products/{id}/paged",
([FromRoute] int id, 
[FromQuery] int page, 
[FromHeader(Name = "PageSize")] int pageSize) 
=> $"Received id {id}, page {page}, pageSize {pageSize}");
app.Run();*/

/*WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
app.MapGet("/product/{id}", (ProductId id) => $"Received {id}"); 
app.Run();
readonly record struct ProductId(int Id) 
{
    public static bool TryParse(string? s, out ProductId result) 
    {
        if (s is not null 
            && s.StartsWith('p') 
            && int.TryParse( 
            s.AsSpan().Slice(1), 
            out int id)) 
        {
            result = new ProductId(id); 
            return true; 
        }
        result = default; 
        return false; 
    }
}*/

/*WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
app.MapPost("/product", (Product product) => $"Received {product}"); 
app.Run();
record Product(int Id, string Name, int Stock);*/

/*WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
app.MapGet("/stock/{id?}", (int? id) => $"Received {id}"); 
app.MapGet("/stock2", (int? id) => $"Received {id}"); 
app.MapPost("/stock", (Product? product) => $"Received {product}"); 
app.Run();
record Product(int Id, string Name, int Stock);*/

// Default value builder for stock
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
app.MapGet("/stock", StockWithDefaultValue); 
app.Run();
string StockWithDefaultValue(int id = 0) => $"Received {id}"; 