using Microsoft.ML.Data;

namespace InovaX.Database.Models
{
    public class RealProductsOutputPrediction
    {

        [ColumnName("Score")]
        public float Price { get; set; }

    }
}
