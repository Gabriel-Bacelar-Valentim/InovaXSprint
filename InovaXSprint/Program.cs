using InovaX.API.Extensions;
using InovaX.Services.CEP;
using InovaXSprint.API.Configuration;
using InovaXSprint.API.Extensions;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;
APIConfiguration apiConfiguration = new();
configuration.Bind(apiConfiguration);
builder.Services.Configure<APIConfiguration>(configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger(apiConfiguration);
builder.Services.AddContext(apiConfiguration);
builder.Services.AddServices();

builder.Services.AddScoped<ICEPService, CEPService>();

builder.Services.AddScoped<ModelTrainingService>();

string csvFilePath = configuration["ModelConfig:CsvFilePath"];
string modelPath = configuration["ModelConfig:ModelPath"];
builder.Services.AddSingleton<RealProductsService>(provider => new RealProductsService(csvFilePath, modelPath));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var trainingService = scope.ServiceProvider.GetRequiredService<ModelTrainingService>();
    trainingService.TrainAndSaveModel(csvFilePath, modelPath);
}

// Configurações do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
