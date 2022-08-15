void FillArray(int[] arr, int startNum = -9, int endNum = 10)
{
    for (int i = 0; i < arr.Length; i ++)
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

void SumOfNegPos(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNeg += arr[i];
        else sumPos += arr[i];
    }
    Console.WriteLine($"Сумма отрицательных чисел массива = {sumNeg}");
    Console.WriteLine($"Сумма положительных чисел массива = {sumPos}");
}

int[] ChangeSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

void FindNumInArray(int[] arr, int findNum)
{
    bool find = false;
    for (int i = 0; i < arr.Length && !find; i++)
    {
        find = findNum == arr[i];
    }
    if (find) Console.WriteLine($"В массиве присутствует число {findNum}.");
    else Console.WriteLine($"В массиве числа {findNum} нет!");
}

void CountNumsInArrayRange(int[] arr, int start, int end)
{
    int count = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] > start && arr[i] < end) count++;
    }
    Console.WriteLine($"В заданном массиве в диапазоне от {start} до {end} лежит {count} элементов!");
}

int[] FindPowOfPairs(int[] arr)
{
    int i =0;
    int newArrSize = arr.Length / 2 + 1;
    if (arr.Length % 2 == 0) newArrSize = arr.Length / 2;
    int[] newArr = new int[newArrSize];
    for (i = 0; i < arr.Length / 2; i++)
    {
         newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 == 1) newArr[i] = arr[i];
    return newArr;
}

int CountOfEvenNums(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int CountOfOddIndNums(int[] arr)
{
    int count = 0;
    for(int i= 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) count += arr[i];
    }
    return count;
}
int[] EmptyOutOfBinArray(int[] arr)
{
    
    int j = 0;
    int dif = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 1) break;
        if (arr[i] == 0) dif++;
    }
    int[] newArr = new int[arr.Length - dif];
    for (int i = dif; i < arr.Length; i++)
    {
        newArr[j] = arr[i];
        j++;
    }
    return newArr;
}

void CreateNFillDoubleArray(double[] arr)
{
    Random rand = new Random();
    int j = 0;
    //double[] bas = new double[] {0.72, -6.01, 78.11, 42.0, 91.83, -15.19, 1.99, 54.06, 27.48, -99,38, 21.7, 0.12, 66.3, 8.49};
    Console.Write("Массив псевдослучайных вещественных чисел [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        //j = rand.Next(0, bas.Length);
        arr[i] = Math.Round(rand.NextDouble() * 10 - 5, 2);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

void MaxMinSub(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    Console.WriteLine($"Минимальный элемент массива {min}");
    Console.WriteLine($"Максимальный элемент массива {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {max - min}");
}
void FrstLastElChange(int[] arr)
{
    int temp = 0;
    int halfSize = arr.Length / 2;
    int maxInd = arr.Length - 1;
    for(int i = 0; i < halfSize; i++)
    {
        temp = arr[i];
        arr[i] = arr[maxInd - i];
        arr[maxInd - i] = temp;
    }
}
int Pow(int num, int prod)
{
    int temp = 1;
    for(int i = 0; i < prod; i++)
    {
        temp = temp * num;
    }
    return temp;
}

int DecToBin(int num)
{
    int i = 0;
    int num2 = 0;
    while(num > 0)
    {
        int temp = num % 2;
        num2 = num2 + temp*Pow(10, i);
        num /= 2;
        i++;
    }
    return num2;
}


void Zadacha39()
{
    //Напишите программу, которая перевернёт
    //одномерный массив (последний элемент будет на первом
    //месте, а первый - на последнем и т.д.)
    int size = new Random().Next(2, 11);
    int[] arr = new int[size];
    FillArray(arr, 0, 10);
    PrintArray(arr);
    FrstLastElChange(arr);
    PrintArray(arr);
}

void Zadacha40()
{
    /*Напишите программу, которая принимает на вход три
    числа и проверяет, может ли существовать треугольник с
    сторонами такой длины.*/
    Console.Write("Введите длинну 1й стороны треугольника от 1 до 40:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите длинну 2й стороны треугольника от 1 до 40:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите длинну 3й стороны треугольника от 1 до 40:");
    int num3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if(num1 + num2 > num3 && num2 + num3 > num1 && num3 + num1 > num2) Console.WriteLine($"Треугольник со сторонами {num1}, {num2} и {num3} существует!");
    else Console.WriteLine($"Треугольник со сторонами {num1}, {num2} и {num3} НЕсуществует!");

}

void Zadacha41()
{
    //Пользователь вводит с клавиатуры M чисел.
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.

    int[] arr = new int[11];
    int count = 0;
    Console.WriteLine("Введите 10 чисел от -5 до +5 включительно:");
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0) count++;
    }
    PrintArray(arr);
    Console.WriteLine($"Среди введенных чисел положительных {count}");
    

}

void Zadacha42()
{
    //Напишите программу, которая будет преобразовывать
    //десятичное число в двоичное.
    Console.Write("Введите число от 0 до 1000:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(DecToBin(num));
}

void Zadacha43()
{
    //Напишите программу, которая найдёт точку
    //пересечения двух прямых, заданных уравнениями y = k1 *
    //x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
    //пользователем.
    Console.Write("Введите значение b1:");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите значение k1:");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите значение b2:");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите значение К2:");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if(k1 == k2) Console.WriteLine("Прямые параллельны, точек пересечения нет!");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * x) + b1;
        double y1 = (k2 * x) + b2;
        Console.WriteLine($"Координаты точки пересечения прямых: {x} , {y}");
        Console.WriteLine(y1);
    }
}

void Zadacha44()
{
    /*Не используя рекурсию, выведите первые N чисел
    Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/
    double FrstNum = 0;
    double ScndNum = 1;
    Console.Write("Введите число от 0 до 100:");
    int n = Convert.ToInt32(Console.ReadLine());
    for(int i= 0; i < n; i++)
    {
        Console.WriteLine(FrstNum);
        double temp = FrstNum;
        FrstNum = ScndNum;
        ScndNum = temp + FrstNum;
    }
}

void Zadacha45()
{
    /*Напишите программу, которая будет создавать
    копию заданного массива с помощью поэлементного
    копирования. */
    int size = new Random().Next(2, 100);
    int[] arr = new int[size];
    FillArray(arr);
    PrintArray(arr);
    int[] newArr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    PrintArray(newArr);

}



//Zadacha39();
//Zadacha40();
//Zadacha41();
//Zadacha42();
//Zadacha43();
//Zadacha44();
//Zadacha45();