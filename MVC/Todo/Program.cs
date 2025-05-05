using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //Adicionado as controllers na inicializacao da api
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapControllers();

app.Run();
