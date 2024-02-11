var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();   // добавляем поддержку статических файлов
//app.Run(async (context) => await context.Response.SendFileAsync("index.html"));
//app.Run(async (context) => await context.Response.WriteAsync("Hello World"));
//app.Run(async (context) => await context.Response.WriteAsync("Hello METANIT.COM"));
app.Map("/time", () => $"time:{DateTime.Now.ToShortTimeString()}");
app.Map("/", async (context) => await context.Response.SendFileAsync("index.html"));
app.Map("/about", () => "About Page");
app.Map("/contact", () => "Contacts Page");
//app.UseWelcomePage();
app.Run();
