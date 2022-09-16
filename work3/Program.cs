// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[11];
FillArray(array);
MinMaxValue(array);
PrintArray(array);


void MinMaxValue(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        if (array[index] < min)
        {
            min = array[index];
        }
    }
    Console.WriteLine($"размер массива --> {array.Length}. Максимальное значение --> {max}, минимальное значение --> {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением --> {max - min}");
}

void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        array[index] = new Random().Next(1, 100);
    }
}

void PrintArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

