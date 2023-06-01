using Microsoft.EntityFrameworkCore;
using SensorTracker.DataAcessLayer;
using SensorTracker.Entities;

var builder = WebApplication.CreateBuilder(args);

string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));


var app = builder.Build();



app.MapGet("/Orders", async (ApplicationDbContext context) =>
{
    await context.Orders.ToListAsync();
});

app.MapGet("/Orders/{id}", async (int id,ApplicationDbContext context) =>
{
   await context.Orders.FirstOrDefaultAsync(o => o.Id == id);
});

app.MapPost("/Orders", async (Order order, ApplicationDbContext context) =>
{
    await context.Orders.AddAsync(order);
});

app.MapPut("/Orders", async (Order order, ApplicationDbContext context) =>
{
    var orderInDb =  context.Orders.FirstOrDefault(o => o.Id == order.Id);

    if (orderInDb == null)
    {
        throw new Exception("Not found");
    }

    orderInDb = order;
    await context.SaveChangesAsync();
});

app.MapDelete("/Orders/{id}", async (int id, ApplicationDbContext context) =>
{
    var orderInDb = context.Orders.FirstOrDefault(o => o.Id == id);

    if (orderInDb == null)
    {
        throw new Exception("Not found");
    }
    context.Orders.Remove(orderInDb);
    await context.SaveChangesAsync();
});

app.Run();
