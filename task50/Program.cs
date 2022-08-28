Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int[m, n];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
        massiv[i, j] = Convert.ToInt32(new Random().Next(0, 100));
}

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
        Console.Write(massiv[i, j] + "  ");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > m || b > n)
    Console.WriteLine("такого числа нет");
else
{
    object c = massiv.GetValue(a - 1, b - 1);
    Console.WriteLine("Искомое число: ");
    Console.WriteLine(c);
}