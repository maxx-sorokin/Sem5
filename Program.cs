int[] numbers = new int[12];

FillArray(numbers);
PrintArray(numbers);
int sumPositive = GetSumPositiveNumbers(numbers);
Console.WriteLine($"Positive sum = {sumPositive}");
int sumNegative = GetSumNegativeNumbers(numbers);
Console.WriteLine($"Negative sum = {sumNegative}");

(int,int) sum = GetSumNegativeAndPositiveNumbers(numbers);

Console.WriteLine($"Negative = {sum.Item1}, Positive = {sum.Item2}");

(int,int) GetSumNegativeAndPositiveNumbers(int[] array)
{
    int sumNegative = 0;
    int sumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegative += array[i];
        }
        else
        {
            sumPositive += array[i];
        }
    }
    return (sumNegative,sumPositive);
}


int GetSumNegativeNumbers(int[] numbers)
{
    int sum = 0;

    for (var i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum += numbers[i];
        }
    }

    return sum;
}

int GetSumPositiveNumbers(int[] numbers)
{
    int sum = 0;

    for (var i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum += numbers[i];
        }
    }

    return sum;
}



void PrintArray(int[] array)
{
    Console.WriteLine();
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
}