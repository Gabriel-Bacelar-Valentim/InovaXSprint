using InovaX.Database.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace InovaX.API.Extensions
{
    public class RealProductsService
    {
        private readonly List<RealProducts> _products;
        private readonly PredictionEngine<RealProductsInputPrediction, RealProductsOutputPrediction> _predictionEngine;

        public RealProductsService(string csvFilePath, string modelPath)
        {
            _products = LoadProductsFromCsv(csvFilePath);

            var mlContext = new MLContext();
            ITransformer trainedModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            _predictionEngine = mlContext.Model.CreatePredictionEngine<RealProductsInputPrediction, RealProductsOutputPrediction>(trainedModel);
        }

        private List<RealProducts> LoadProductsFromCsv(string filePath)
        {
            var products = new List<RealProducts>();

            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    products.Add(new RealProducts
                    {
                        Name = values[0],
                        Category = values[1],
                        Price = float.Parse(values[2]),
                        Rating = double.Parse(values[3])
                    });
                }
            }

            return products;
        }

        public List<RealProducts> GetProductsByName(string name)
        {
            return _products.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public float PredictPrice(string name, string category)
        {
            var input = new RealProductsInputPrediction { Name = name, Category = category };
            var prediction = _predictionEngine.Predict(input);
            return prediction.Price;
        }
    }
}
