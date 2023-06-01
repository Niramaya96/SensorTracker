using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SensorTracker.DataAcessLayer;
using SensorTracker.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});


var app = builder.Build();



app.MapGet("/Orders", async (ApplicationDbContext context) =>
{
    await context.Orders.ToListAsync();
});

app.MapGet("/Orders/{id}", async (int id,ApplicationDbContext context) =>
{
   await context.Orders.FirstOrDefaultAsync(o => o.Id == id);
});

app.MapPost("/Orders", async ([FromBody]Order order,ApplicationDbContext context,
    HttpResponse resonse) =>
{
    await context.Orders.AddAsync(order);
    await context.SaveChangesAsync();
    // retirn Results.

});

app.MapPut("/Orders", async ([FromBody] Order order, ApplicationDbContext context) =>
{
    var orderFromDb =  context.Orders.FirstOrDefault(o => o.Id == order.Id);

    if (orderFromDb == null)
    {
        return Results.NotFound();
    }

    orderFromDb = order; // передаем DTO или VM
    await context.SaveChangesAsync();
    //return Results.NoContent();
});

app.MapDelete("/Orders/{id}", async (int id, ApplicationDbContext context) =>
{
    var orderInDb = await context.Orders.FirstOrDefaultAsync(o => o.Id == id);

    if (orderInDb == null)
    {
        Results.NotFound();
    }
    context.Orders.Remove(orderInDb);
    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.UseHttpsRedirection();

app.Run();
