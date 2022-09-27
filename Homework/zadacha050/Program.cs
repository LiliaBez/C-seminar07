/*Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.*/

int height = EnterInt("Enter height: "); //высота массива
int width = EnterInt("Enter widht: ");  //ширина массива

int[,] numbers = new int[height, width];

Fill2DArray(numbers, height, width);
Print2dArray(numbers, height, width);


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2dArray(int[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите индекс строки искомого элемента: ");
int indexHeight = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца искомого элемента: ");
int indexWidht = int.Parse(Console.ReadLine()!);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (i == indexHeight && j == indexWidht)
        {
            Console.WriteLine($"Искомый элемент: {numbers[i, j]}");
        }
    }
}

if (indexHeight >= height || indexWidht >= width)
{
    Console.WriteLine("Такого числа в массиве нет");
}