using cleaningUpProgramCsFile.StartupConfig;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.RegisterServices();


var app = builder.Build();

app.ConfigureSwagger();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapCheckerEndpoint();

app.Run();
