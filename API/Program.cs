using TeatroBack.Data;
using TeatroBack.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Filters;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Filter.ByExcluding(Matching.FromSource("Microsoft"))
    .WriteTo.File("logs/errorlogs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(dispose: true);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/*  builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
        }); */

var connectionString = builder.Configuration.GetConnectionString("ServerDB");
builder.Services.AddScoped<IObraService, ObraService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISeatService, SeatService>();
builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddScoped<ISalaService, SalaService>();
builder.Services.AddScoped<IReserveService, ReserveService>();

// Register database context
builder.Services.AddDbContext<ObraContext>(options =>
    options.UseSqlServer(connectionString));

// Register repositories
builder.Services.AddScoped<IObraRepository, ObraEFRepository>();
builder.Services.AddScoped<IUserRepository, UserEFRepository>();
builder.Services.AddScoped<ISeatRepository, SeatRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();
builder.Services.AddScoped<ISalaRepository, SalaRepository>();
builder.Services.AddScoped<IReserveRepository, ReserveRepository>();


// Register services
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

/* app.UseHttpsRedirection();*/
app.UseAuthorization();
app.UseCors(options =>
{
    options.WithOrigins("http://localhost:5173")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
});
app.MapControllers();

app.Run();

