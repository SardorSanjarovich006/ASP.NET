using Sheenam.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<ApplicationDbContext>(); 
Console.WriteLine(builder.Environment.EnvironmentName);
var app = builder.Build();

app.MapControllers();   
app.Run();