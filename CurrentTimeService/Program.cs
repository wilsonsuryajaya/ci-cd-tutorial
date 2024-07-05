var builder = WebApplication.CreateBuilder( args );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI( options =>
{
    options.SwaggerEndpoint( "/swagger/v1/swagger.json", "Web API V1" );
    if ( app.Environment.IsDevelopment() )
        options.RoutePrefix = "swagger";
    else
        options.RoutePrefix = string.Empty;
} );

app.UseHttpsRedirection();

// GET UTC
app.MapGet( "time/utc", () => Results.Ok( DateTime.UtcNow ) );

// Hello world for unit test
app.MapGet( "/hello_world", () => "Hello World!" );

await app.RunAsync();

public partial class Program { }