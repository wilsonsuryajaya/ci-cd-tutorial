var builder = WebApplication.CreateBuilder( args );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet( "time/utc", () => Results.Ok( DateTime.UtcNow ) );
app.MapGet( "/hello_world", () => "Hello World!" );

await app.RunAsync();

public partial class Program { }