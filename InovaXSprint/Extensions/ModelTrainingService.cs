using InovaX.Database.Models;
using Microsoft.ML;

namespace InovaX.API.Extensions
{
    public class ModelTrainingService
    {
        public void TrainAndSaveModel(string dataPath, string modelPath)
        {
            var mlContext = new MLContext();

            IDataView dataView = mlContext.Data.LoadFromTextFile<RealProductsInputPrediction>(dataPath, separatorChar: ',', hasHeader: true);

            var split = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);

            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(nameof(RealProductsInputPrediction.Name))
                .Append(mlContext.Transforms.Categorical.OneHotEncoding(nameof(RealProductsInputPrediction.Category)))
                .Append(mlContext.Transforms.Concatenate("Features", nameof(RealProductsInputPrediction.Name), nameof(RealProductsInputPrediction.Category)))
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: nameof(RealProductsInputPrediction.Price), maximumNumberOfIterations: 100));

            var model = pipeline.Fit(split.TrainSet);

            using (var fileStream = new FileStream(modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                mlContext.Model.Save(model, dataView.Schema, fileStream);
            }
        }

    }
}
