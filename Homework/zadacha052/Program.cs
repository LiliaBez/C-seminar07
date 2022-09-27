/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/


int[ , ] numbers = { { 1, 4 ,7, 2}, 
                     { 5, 9, 2, 3 }, 
                     { 8, 4, 2, 4} };
int height = numbers.GetLength(0);
int widht = numbers.GetLength(1);

double FindArithmeticMeanColumn (int[,] numbers, int height, int widht)
{
    for (int j = 0; j < widht; j++)
    {
        double sum = 0;
        for (int i = 0; i < height; i++)
        {
            sum = sum + numbers[i, j];
        }
        return sum / height;
    }
    return Console.WriteLine(sum / height);
}

Console.Write(FindArithmeticMeanColumn);



