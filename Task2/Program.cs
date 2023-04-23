//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
        if (i%2 != 0)
        {
           result += array[i];
        }
    }
    return result;
}

int size = 5;

int[] array = CreateAndFillingArray(size, 0, 10);

PrintArrayInConsole(array);

System.Console.WriteLine($"Сумма нечетных в массиве = {CountingTheNumberOfEvenNumbersInAnArray(array)}");


