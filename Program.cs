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

void CopyArray(int[] array)
{
    for(int i = 0; i < array.Length / 2 ; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1]
    }
    
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
