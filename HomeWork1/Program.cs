// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int Prompt(string message)
{
    System.Console.WriteLine(message);
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

void Poriadok(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int i1 = 0; i1 < array.GetLength(1); i1++)
        {
            int min = array[i, i1];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    array[i, j] = array[i, i1];
                    array[i, i1] = min;
                }
            }
        }
    }
}


int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int[,] mas = CreateArray(m, n);
System.Console.WriteLine();
PrintArray(mas);
System.Console.WriteLine();
Poriadok(mas);
PrintArray(mas);
