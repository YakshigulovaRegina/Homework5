int[] array = generateArray(4);  
search(array);
PrintArray(array);
Console.WriteLine("Сумма элементов : " + (search(array)));

int[] generateArray (int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(-10,10);
    }  
    return array;
}

int search (int[] array)
{ 
    int number = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((i + 1) %2 != 0)
    {
        number = number + array[i];
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
