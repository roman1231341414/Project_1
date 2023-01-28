int [] generatArray(int length,int start,int end)
{
    int [] result = new int[length];
    for (int i = 0; i < length; i++)
    {
     result[i] = new Random().Next(start,end + 1);   
    }
    return result;
}
int [] array = generatArray(12,-9,9);
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]); 
        if (i <array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getSumOfPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int getSumOfNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
printArray(array);
int SumOfPositive = getSumOfPositive(array);
int SumOfNegative = getSumOfNegative(array);
Console.WriteLine($"Сумма положительных {SumOfPositive}");
Console.WriteLine($"Сумма отрицательных {SumOfNegative}");
