using Azure.Messaging.ServiceBus;
using MaintenanceAdapter.Application.ViewModels.MessageIntegration.Requests;
using System.Text.Json;

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


app.MapPost("/api/integration", async (MessageIntegrationRequest request) =>
{
    var connectionString = builder.Configuration["Servicebus:ConnectionStringCaseQueue"];   
    var client = new ServiceBusClient(connectionString);
    var sender = client.CreateSender("maintenance-case-queue");
    var body = JsonSerializer.Serialize(request);
    var message = new ServiceBusMessage(body);
    await sender.SendMessageAsync(message);



});

app.Run();
