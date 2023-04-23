//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76


double[] CreateAndFillingArray(int size)
{
    double[] array = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble(), 2);
    }
    return array;
}

void PrintArrayInConsole(double[] array)
{
    Console.WriteLine(string.Join("; ", array));
}

double TheDifferenceBetweenTheMaximumAndMinimumValuesOfTheArray(double[] array)
{
    double minValue = array[0], maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
           maxValue = array[i];
        }else if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    return Math.Round(maxValue - minValue, 2);
}

int size = 5;

double[] array = CreateAndFillingArray(size);

PrintArrayInConsole(array);

System.Console.WriteLine($"разница между макс и мин значенями массива = {TheDifferenceBetweenTheMaximumAndMinimumValuesOfTheArray(array)}");


