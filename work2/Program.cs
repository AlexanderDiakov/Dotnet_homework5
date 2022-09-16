// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[11];
FillArray(array);
sumElements(array);
PrintArray(array);
int sum = 0;

void sumElements(int[] array)
{
    sum = 0;
    for (int index = 0; index < array.Length; index += 2)
        sum = sum + array[index];
    Console.WriteLine($"размер массива --> {array.Length} сумма элементов, стоящих на нечётных позициях --> {sum}");
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        array[index] = new Random().Next(1, 15);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 1;
    for (index = 0; index < length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}
