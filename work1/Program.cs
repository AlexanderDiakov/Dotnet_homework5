// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу,которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[11];
FillArray(array);
EvenNumbers(array);
PrintArray(array);
int count = 0;

void EvenNumbers(int[] array)
{
    count = 0;
    for (int index = 0; index < array.Length; index++)
        if (array[index] % 2 == 0)
            count++;
    Console.WriteLine($"размер массива --> {array.Length} количество четных чисел --> {count}");
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        array[index] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}




