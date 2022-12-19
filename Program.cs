// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] createMas(int sizeMas)
{
    int [] mas= new int [sizeMas];
    Random rs=new Random();
    for (int i=0; i<sizeMas; i++)
    {
        mas[i]=rs.Next(100, 999);
        if (i<sizeMas-1)
        {
            Console.Write($"{mas[i]}, ");
        } else
        {
            Console.Write($"{mas[i]}");
            Console.WriteLine();
        }
    }
    return mas;
}

int numChet(int [] mas)
{
    int num=0;
    for (int i=0; i<mas.Length; i++)
    {
        if (mas[i]%2==0)
        {
            num=++num;
        }
    }
    return num;
}
Console.WriteLine("Task 34");
Console.WriteLine("Введите размер массива трехзначных чисел");
int [] masiv=createMas(int.Parse(Console.ReadLine()));
Console.WriteLine($"{numChet(masiv)}");
