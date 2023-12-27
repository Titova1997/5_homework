Задача 1: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
4 3 1  (1, 2) => 9
2 6 9

Создать двумерный массив и сделать так что бы пользователь указал 
2 числа. Первое число номер строчки, второе столбца 
такого элемента нет 

Console.Write("Введите номер строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int n = 5;
int m = 7;

Random random = new Random();

int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует  ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();






Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.
4 3 1 => 4 6 2
2 6 9    2 6 9
4 6 2    4 3 1

решаем с помощью пузырькового метода 



int[,] array = new int[3, 4];

void CreateArray()   //заполняем массив 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray()   //выводим
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); //выводим всю строку
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReversionArray()
{
    for (int i = 0; i < array.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int Temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - 1 - i, j];
            array[array.GetLength(0) - 1 - i, j] = Temp;
        }
    }
}

void PrintReversArray()   //выводим
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); //выводим всю строку
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

CreateArray();
Console.WriteLine("Исходник");
PrintArray();
Console.WriteLine("Реверс");
ReversionArray();
PrintReversArray();



Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.
4 3 1 => Строка с индексом 0
2 6 9
4 6 2 


int[,] array = new int[5, 9];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindElementsArray()
{
    int min = 0;
    int minString = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            while (j < array.GetLength(1))
            {
                sumElement += array[i, j];  //сумма строки
                j++;
            }
            if (min == 0)
            {
                min = sumElement;
                minString = i;
            }
            if (sumElement < min)
            {
                min = sumElement;
                minString = i;
            }
        }
        Console.WriteLine("Сумма строки: " + sumElement);
    }
    Console.WriteLine("Строка c наименьшей суммой элементов: " + minString);
}


CreateArray();
Console.WriteLine("Исходный массив: ");
PrintArray();
FindElementsArray();





