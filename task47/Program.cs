// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


void PrintMassiv(double[,] image)
{
    for (int m = 0; m < image.GetLength(0); m++)
    {
        for (int n = 0; n < image.GetLength(1); n++)
        {
            Console.Write($"{image[m, n]} ");

        }
        Console.WriteLine();
    }
}

void FillMassiv(double[,] image)
{
    for (int m = 0; m < image.GetLength(0); m++)
    {
        for (int n = 0; n < image.GetLength(1); n++)
        {
            image[m, n] = new Random().NextDouble() * 200 - 100; // [1;10) - не включая 10
        }
    }
}


double[,] matrix = new double[3, 4];
FillMassiv(matrix);
Console.WriteLine();
PrintMassiv(matrix);
Console.WriteLine();