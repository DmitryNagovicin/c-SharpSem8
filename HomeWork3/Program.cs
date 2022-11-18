//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateArray(int rous, int colums)
{
    int[,] massiv = new int[rous, colums];
    Random rnd = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = rnd.Next(0, 11);
        }
    }
    return massiv;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}


int m1 = Prompt("Введите количество строк 1 матрицы: ");
int n1 = Prompt("Введите количество столбцов 1 матрицы: ");
int[,] mas1 = CreateArray(m1, n1);
System.Console.WriteLine();
PrintArray(mas1);
System.Console.WriteLine();
int m2 = Prompt("Введите количество строк 2 матрицы: ");
int n2 = Prompt("Введите количество столбцов 2 матрицы: ");
int[,] mas2 = CreateArray(m2, n2);
System.Console.WriteLine();
PrintArray(mas2);
System.Console.WriteLine();
if (mas1.GetLength(1) != mas2.GetLength(0))
{
    System.Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    System.Console.WriteLine("Результирующая матрица ");
    int[,] result = Multiplication(mas1, mas2);
    PrintArray(result);
}
