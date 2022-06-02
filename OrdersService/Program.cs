using OrdersService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/Orders", () =>
{
    var orders = Enumerable.Range(1, 5).Select(index =>
       new Orders
       {
           OrderId = Guid.NewGuid().ToString(),
           Product = string.Concat("Product", new Random().Next(2, 10))
       })
        .ToArray();
    return orders;
})
.WithName("GetOrders");

app.Run();
