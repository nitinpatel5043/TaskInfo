//using Serilog;
//using TaskInfo.BuilderExtensions;
//using TaskInfo.Middleware;

//var builder = WebApplication.CreateBuilder(args);

//builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration loggerConfiguration) =>
//{
//    loggerConfiguration
//    .ReadFrom.Configuration(context.Configuration)
//    .ReadFrom.Services(services);
//});


//builder.Services.AddServiceCollection(builder.Configuration);

//// Build the application
//WebApplication app = builder.Build();

//// Middleware setup
//app.UseExceptionMiddleware();
//app.UseSerilogRequestLogging();
//app.UseSwagger();
//app.UseSwaggerUI();
//app.UseHttpsRedirection();
//app.UseAuthentication();
//app.UseAuthorization();
//app.MapControllers();

//app.Run();





using Serilog;
using System.Text.Json.Serialization;
using TaskInfo.BuilderExtensions;
using TaskInfo.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration loggerConfiguration) =>
{
    loggerConfiguration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services);
});

// Add services to the DI container
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        // Serialize enums as strings in JSON
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Task API", Version = "v1" });
    // Display enums as names in Swagger
    c.UseInlineDefinitionsForEnums();
});

// Add custom service registrations (if needed)
builder.Services.AddServiceCollection(builder.Configuration);

// Build the application
var app = builder.Build();

// Middleware setup
app.UseExceptionMiddleware();
app.UseSerilogRequestLogging();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();









