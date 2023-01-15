int[] array = generateArray(7);  
search(array);
PrintArray(array);
Console.WriteLine("Четных чисел : " + (search(array)));

int[] generateArray (int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(100,999);
    }  
    return array;
}

int search (int[] array)
{ 
    int number = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] %2 == 0)
    {
        number = number + 1;
    } 
}
return number;
}


void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
