var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddScoped<ISensorRepository,SensorRepository>();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.MapGet("/Sensors", async (ISensorRepository repository) =>
{
    return await repository.GetSensorsAsync();
});

app.MapGet("/Sensors/{id}", async (int id,ISensorRepository repository) =>
    await repository.GetSensorByIdAsync(id) is Sensor sensor
    ? Results.Json(sensor) : Results.NotFound());

app.MapPost("/Sensors", async ([FromBody]Sensor sensor,ISensorRepository repository) =>
{
    await repository.InsertSensorAsync(sensor);
    await repository.SaveChangesAsync();
    return Results.Created($"Sensors/{sensor.Id}", sensor);
});
    


app.MapPut("/Sensors", async ([FromBody] Sensor sensor, ISensorRepository repository) =>
{
    await repository.UpdateSensorAsync(sensor);
    await repository.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/Sensors/{id}", async (int id, ISensorRepository repository) =>
{
    await repository.DeleteSensorAsync(id);
    await repository.SaveChangesAsync();
    return Results.NoContent();
});

app.UseHttpsRedirection();

app.Run();

