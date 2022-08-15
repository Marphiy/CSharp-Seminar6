

void FillArray(int[] arr, int startNum = -9, int endNum = 10)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(startNum, endNum);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("Массив [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

void FindSubseqInArrey(int[] arr, int num)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 2)
        {
            if (num / 100 % 10 == arr[i]
            && num / 10 % 10 == arr[i + 1]
            && num % 10 == arr[i + 2]) count++;
        }
    }
    if (count > 0) Console.WriteLine($"Последовательность чисел {num} встречается в массиве {count} раз/а!");
    else Console.WriteLine($"Последовательность чисел {num} НЕ встречается в массиве!");
}

int CountOfNumLength(int num)
{
    int numLengh = 1;
    while (num / 10 > 0)
    {
        num /= 10;
        numLengh++;
    }
    return numLengh;
}
int[] NumToDigit(int num)
{
    int size = CountOfNumLength(num);
    int[] arr = new int[size];
    int count = 0;
    while (num > 0)
    {
        arr[count] = num % 10;
        num /= 10;
        count++;
    }
    return arr;
}

int SumOfArrElmnts(int[] arr)
{
    int sumOfEl = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sumOfEl += arr[i];
    }
    return sumOfEl;
}

int PowOfArrElmnts(int[] arr)
{
    int sumOfEl = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        sumOfEl *= arr[i];
    }
    return sumOfEl;
}

int[] PowOfEachElmToArray(int num1, int num2)
{
    int num1Lengh = CountOfNumLength(num1);
    int num2Lengh = CountOfNumLength(num2);
    //Console.WriteLine($"{num1Lengh}, {num2Lengh}");
    int size = num1Lengh * num2Lengh;
    int[] arr = new int[size];
    //PrintArray(NumToGigit(num1));
    //PrintArray(NumToGigit(num2));
    int k = 0;
    for (int i = 0; i < NumToDigit(num1).Length; i++)
    {
        for (int j = 0; j < NumToDigit(num2).Length; j++)
        {
            arr[k] = (NumToDigit(num1)[i]) * (NumToDigit(num2)[j]);
            Console.WriteLine($"{NumToDigit(num1)[i]} * {NumToDigit(num2)[j]} = {arr[k]}");
            k++;
        }
    }
    return arr;
}

int[] EmptyOutOfArray(int[] arr, int newArrSize)
{
    int[] newArr = new int[newArrSize];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

void Zadacha1()
{
    //Задан массив из случайных цифр на 15 элементов. На вход подаётся 
    //трёхзначное натуральное число. Напишите программу, которая определяет, 
    //есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.

    int size = 15;
    //int[] arr = new int[] {0, 9, 8, 2, 3, 6, 1, 1, 8, 8, 4, 8, 8, 8, 2};
    int[] arr = new int[size];
    FillArray(arr, 0, 10);
    PrintArray(arr);
    int num = new Random().Next(100, 1000);
    //int num = 823;
    Console.WriteLine($"Последовательность чисел {num}");
    FindSubseqInArrey(arr, num);
}


void Zadacha2()
{
    //На вход подаются два числа случайной длины. Найдите произведение 
    //каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.

    int num1 = new Random().Next(1, 1000);
    int num2 = new Random().Next(1, 1000);
    Console.WriteLine($"Даны 2 числа {num1} и {num2}");
    Console.WriteLine("Произведение каждого разряда первого числа на каждый разряд второго:");
    PrintArray(PowOfEachElmToArray(num1, num2));

}

void Zadacha3()
{
    //Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. 
    //Подсчитайте их количество.
    int limit = 1000000;
    int[] arr = new int[limit];
    int count = 0;
    for (int i = 1; i < limit; i++)
    {
        if (SumOfArrElmnts(NumToDigit(i)) == PowOfArrElmnts(NumToDigit(i)) / 3)
        {
            arr[i] = i;
            count++;
        }
    }
    //PrintArray(EmptyOutOfArray(arr, count));
    Console.WriteLine($"Чисел от 1 до {limit}, сумма цифр которых строго в три раза меньше их произведений {count}");
}

void Zadacha1_1()
{
    int numOfArrays = 5;
    int[][] ArrayOfArray = new int[numOfArrays][];
    int max = 0;
    int maxInd = 0;
    int count = 0;
    int minInd = 0;
    for (int i = 0; i < numOfArrays; i++)
    {
        ArrayOfArray[i] = new int[10];
        FillArray(ArrayOfArray[i], 1, 100);
        if (SumOfArrElmnts(ArrayOfArray[i]) >= max)
        {
            if (SumOfArrElmnts(ArrayOfArray[i]) == max) break;
            max = SumOfArrElmnts(ArrayOfArray[i]);
            maxInd = i;
        }
        PrintArray(ArrayOfArray[i]);
        Console.WriteLine($"Сумма элементов {SumOfArrElmnts(ArrayOfArray[i])}");
    }
    Console.WriteLine();
    for (int i = 0; i < numOfArrays; i++)
    {
        if (SumOfArrElmnts(ArrayOfArray[i]) == max) 
        {
            minInd = i;
            break;
        }
    }
    Console.Write($"Массив с максимальной суммой элементов - ");
    PrintArray(ArrayOfArray[minInd]);
    Console.WriteLine($"Сумма элементов массива составляет {SumOfArrElmnts(ArrayOfArray[minInd])}");
}

//Zadacha1();
//Zadacha2();
//Zadacha3();
//Zadacha1_1();