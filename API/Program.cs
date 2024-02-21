using TeatroBack.Data;
using TeatroBack.Business;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ServerDB");
builder.Services.AddScoped<IObraService,ObraService>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<ISeatService,SeatService>();
builder.Services.AddScoped<ISessionService,SessionService>();
// Register database context
builder.Services.AddDbContext<ObraContext>(options =>
    options.UseSqlServer(connectionString));

// Register repositories
builder.Services.AddScoped<IObraRepository, ObraEFRepository>();
builder.Services.AddScoped<IUserRepository, UserEFRepository>();
builder.Services.AddScoped<ISeatRepository, SeatRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();

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

