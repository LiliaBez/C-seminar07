/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/


int[ , ] numbers = { { 1, 4 ,7, 2}, 
                     { 5, 9, 2, 3 }, 
                     { 8, 4, 2, 4} };

FindArithmeticMeanColumn(numbers);



void FindArithmeticMeanColumn (int[,] numbers)
{
    int height = numbers.GetLength(0);
    int widht = numbers.GetLength(1);
    for (int j = 0; j < widht; j++)
    {
        int sum = 0;
        for (int i = 0; i < height; i++)
        {
            sum += numbers[i, j];
        }
        float arithmeticMean = sum / height;
        Console.WriteLine($"Среднее арифметическое элементов столбца {j} равно: {arithmeticMean}");
    }
}





