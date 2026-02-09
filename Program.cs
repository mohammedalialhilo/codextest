var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/info", () =>
{
    var info = new
    {
        Name = "Codex Info Landing",
        Description = "A simple C# and HTML landing page.",
        Contact = "hello@example.com"
    };

    return Results.Ok(info);
});

app.Run();
