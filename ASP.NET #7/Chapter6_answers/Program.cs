/*var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();
builder.Services.AddRazorPages();
var app = builder.Build();

app.MapGet("/test", () => "Hello World!");
app.MapHealthChecks("/healthz");
app.MapRazorPages();

app.MapGet("/product/{name}", (string name) => $"The product is {name}") 
.WithName("product");

app.MapGet("/links", (LinkGenerator links) =>
{
    string? link = links.GetPathByName("product",
        new { name = "big-widget" }
        );
    return $"View the product at {link}";
});*/

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<RouteOptions>(o => 
{
    o.LowercaseUrls = true; 
    o.AppendTrailingSlash = true; 
    o.LowercaseQueryStrings = false; 
});
WebApplication app = builder.Build();
app.MapGet("/HealthCheck", () => Results.Ok()).WithName("healthcheck");
app.MapGet("/{name}", (string name) => name).WithName("product");
app.MapGet("/", (LinkGenerator links) =>
new[]
{
    links.GetPathByName("healthcheck",options: new LinkOptions
    {
        LowercaseUrls = false,
        AppendTrailingSlash = false,
    }),
    links.GetPathByName("product", 
    new { Name = "Big-Widget", Q = "Test"}) 
});

app.Run();
