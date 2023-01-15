double[] array = generateArray(7);
double max = array[0]; double min = array[0]; 
PrintArray(array);  
SearchMax(array);
SearchMin(array);
difference(max, min);
double diff = difference(max,min);
Console.WriteLine("Разница между максимальным и минимальным элементами массива : " + Math.Round(diff, 2));

double[] generateArray (int arraySize)
{
    //massiv[i] = Convert.ToDouble(Console.ReadLine())
    double[] array = new double[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }  
    return array;
}

double SearchMax (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
           max = array[i]; 
        }
    }
    return max;
}

double SearchMin (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double difference (double max, double min)
{
    double diff = max - min;
    return diff;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i],2)}, ");
    }
    Console.WriteLine();
}
