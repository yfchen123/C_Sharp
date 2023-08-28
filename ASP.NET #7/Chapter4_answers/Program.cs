/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseWelcomePage();

app.Run();*/

var builder1 = WebApplication.CreateBuilder(args);
var app1 = builder1.Build();
app1.UseDeveloperExceptionPage();
app1.UseStaticFiles();
app1.UseRouting();
app1.MapGet("/", () => "Hello World!");

app1.Run();
