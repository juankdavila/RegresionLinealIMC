using MathNet.Numerics.LinearRegression;

double[] weigths = new double[] { 50, 60, 70, 80, 90, 100, 110 };

double[] heights = new double[] { 1.50, 1.60, 1.70, 1.80, 1.90, 2.00, 2.10 };

double[] bmis = new double[weigths.Length];

double[][] inputMatrix = new double[weigths.Length][];
for (int i = 0; i < weigths.Length; i++)
{
    bmis[i] = weigths[i] / (heights[i] * heights[i]);

}
for (int i = 0; i < weigths.Length; i++)
{
    inputMatrix[i] = new double[] { 1.0, weigths[i] };

}


var parameters = MultipleRegression.QR(inputMatrix, bmis, false);
double intercept = parameters[0]; //intercepto
double slope = parameters[1]; //Pendiente
double prediccion = slope * 75 + intercept;
Console.WriteLine($"El IMC  para una persona que pesa 75 kg es: {prediccion} ");