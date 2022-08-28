// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


void FillMassiv(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            image[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMassiv(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");

        }
        Console.WriteLine();
    }
}

void SummaMassiv(int[,] image)
{

    for (int j = 0; j < image.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < image.GetLength(0); i++)
        {
            count++;
            sum = sum + image[i, j];
        }
        double c = sum / count;
        Console.WriteLine($"Среднее арифметическое элементов в столбце {j+1} равно ");
        Console.Write(Math.Round(c, 2));
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк и число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMassiv(matrix);
Console.WriteLine("Массив элементов выглядит так: ");
PrintMassiv(matrix);
Console.WriteLine();
SummaMassiv(matrix);