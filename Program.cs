// Развернуть массив:
/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/
// Задача 1: Написать программу, которая принимает на вход три числа и проверяет может ли существоватьть треугольник со сторонами такой длины.
/*
bool Triangle(int a, int b, int c)
{
    bool result = false;
    if(a + b > c && b + c > a && c + a > b)
        result = true;
    return result;
}

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(a,b,c));
*/
// Задача 2: Не используя рекурсию, введите первые N чисел фибаначи. Первые два числа: a и b .
/*
int[] ArrayFibonachi(int firstNum, int secondNum, int length)
{
    int[] array = new int[length];
    array[0] = firstNum;
    array[1] = secondNum;
    for(int i = 2; i < length; i++)
    {
        array[i] = array[i - 1] + array[i-2];
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());

ShowArray(ArrayFibonachi(a, b, length));
*/

// Задача 3: Поэлементное копирование массива.
/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    return copyArray;
}

void InvertArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}

 void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray1 = CreateRandomArray(length, min, max);
int[] myArray2 = CopyArray(myArray1);

InvertArray(myArray2);
ShowArray(myArray1);
ShowArray(myArray2);
*/

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] NumArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        Console.Write($"Input a namber {i} element ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int NumPositiveNumbers(int[] array) 
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            quantity++;
        }
    }
    Console.Write(quantity);
    return quantity;
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = NumArray(length);

ShowArray(myArray);
int numbers = NumPositiveNumbers(myArray);

Console.WriteLine($"Введено чисел больше нуля = {numbers}");
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double[] IntersectionCoordinates(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (b1 == b2)
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> (0, {b1})");
    else if (k1 == k2)
        Console.WriteLine($"don 't overlap");
    else 
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");
    }
    double[] coord = {x,y};
    return coord;
}


Console.WriteLine($"Введите значение b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение k1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение k2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] Coordinattes = IntersectionCoordinates(b1, b2, k1, k2);
Console.WriteLine(Coordinattes);
*/