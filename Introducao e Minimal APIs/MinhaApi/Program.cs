var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//() => Função anônima
app.MapGet("/", () => {
    return Results.Ok("Hello World");
});

app.MapGet("/name/{nome}", (string nome) => {
    return Results.Ok($"Hello {nome}");
});

app.MapPost("/", (User user) => {
    return Results.Ok(user);
});

app.Run();


public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
}
