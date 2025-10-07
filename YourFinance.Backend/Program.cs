using YourFinance.Backend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<AuthenticationService>(); // Register the authorization service
builder.Services.AddScoped<UserExistsService>();

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => {
        policy
            .WithOrigins("http://localhost:8080") // Allow requests from Swagger UI
            .WithOrigins("http://localhost:4200") // Allow localhost for Ionic Angular
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors(); // apply CORS middleware

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();