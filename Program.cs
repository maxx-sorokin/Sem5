// int[] numbers = new int[12];

// FillArray(numbers);
// PrintArray(numbers);

// задача 31

// int sumPositive = GetSumPositiveNumbers(numbers);
// Console.WriteLine($"Positive sum = {sumPositive}");
// int sumNegative = GetSumNegativeNumbers(numbers);
// Console.WriteLine($"Negative sum = {sumNegative}");

// (int,int) sum = GetSumNegativeAndPositiveNumbers(numbers);
// Console.WriteLine($"Negative = {sum.Item1}, Positive = {sum.Item2}");



// задача 32

// SignChange(numbers);
// PrintArray(numbers);



// задача 33

// Console.WriteLine("Введите число");
// int findNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindNumberInArray(numbers,findNumber));


// задача 35

// int[] numbers = new int[123];
// FillArray(numbers);
// PrintArray(numbers);
// int count = GetCountNumberInRange(numbers);
// Console.WriteLine(count);


// задача 37

int[] numbers = new int[10];
FillArray(numbers);
PrintArray(numbers);
int[] arrayOfProducts = GetsTheProductsOfPairsOfNumbers(numbers);
PrintArray(arrayOfProducts);


// метод - находит произведения пар чисел в массиве и записывает их в новый массив
int[] GetsTheProductsOfPairsOfNumbers(int[] array)
{
    int newArrayLength = array.Length / 2;

    if (array.Length % 2 != 0)
    {
        newArrayLength++;
    }

    int[] newArray = new int[newArrayLength];

    for (int i = 0; i < newArrayLength-1; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    newArray[newArrayLength-1] = array[newArrayLength-1];
    return newArray;
}


// метод - находит колчество элементов массива, значения которых лежат в отрезке [10,99]
int GetCountNumberInRange(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 & array[i] <= 99)
        {
            count += 1;
        }
    }
    return count;
}


// метод - находит заданное число в массиве
bool FindNumberInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

// метод - меняет знак каждого элемента в массиве
void SignChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

// метод - находит сумму отрицательных и положительных чисел в массиве
(int, int) GetSumNegativeAndPositiveNumbers(int[] array)
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
    return (sumNegative, sumPositive);
}

// метод - находит сумму отрицательных чисел в массиве
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

// метод - находит сумму положительных чисел в массиве
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
        array[i] = random.Next(0, 11);
    }
}