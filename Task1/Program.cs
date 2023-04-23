//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] CreateAndFillingArray(int size, int leftRangeValue, int rightRangeValue)
{
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(leftRangeValue, rightRangeValue);
    }
    return array;
}

void PrintArrayInConsole(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int CountingTheNumberOfEvenNumbersInAnArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
           result++;
        }
    }
    return result;
}

int size = 12;

int[] array = CreateAndFillingArray(size, 100, 1000);

PrintArrayInConsole(array);

System.Console.WriteLine($"Количество четных в массиве = {CountingTheNumberOfEvenNumbersInAnArray(array)}");

