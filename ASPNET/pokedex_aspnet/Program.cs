var builder = WebApplication.CreateBuilder(args);

// Add controllers (REST API)
builder.Services.AddControllers();

// Register PokemonService as singleton (keeps data alive while app runs)
builder.Services.AddSingleton<PokedexApi.Services.PokemonService>();

// Add CORS policy to allow frontend access
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowAll");
app.UseRouting();
app.MapControllers();

app.Run();
