var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();   // добавляем поддержку статических файлов
//app.Run(async (context) => await context.Response.SendFileAsync("index.html"));
//app.Run(async (context) => await context.Response.WriteAsync("Hello World"));
//app.Run(async (context) => await context.Response.WriteAsync("Hello METANIT.COM"));
app.Map("/time", () => $"time:{DateTime.Now.ToLongTimeString()}");
app.Map("/ajax2-1", (string event1, string date) => $"<h3>{event1}</h3><h5>{date}</h5>");
//app.Map("/about", () => "About Page");
//app.Map("/contact", () => "Contacts Page");
//app.UseWelcomePage();
//app.Run(async (context) => await context.Response.SendFileAsync("index.html"));
//app.Run(async (context) => await context.Response.WriteAsync("Hello world!!!"));
app.Run();
