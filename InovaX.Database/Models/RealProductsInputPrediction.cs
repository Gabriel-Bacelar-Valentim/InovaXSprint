using Microsoft.ML.Data;

public class RealProductsInputPrediction
{
    [LoadColumn(0)]
    public string Name { get; set; }

    [LoadColumn(1)]
    public string Category { get; set; }

    [LoadColumn(2)]
    public float Price { get; set; }
}