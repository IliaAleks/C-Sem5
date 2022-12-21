//Task 34
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
Console.WriteLine($"Количество четных чисел равно = {numChet(masiv)}");

//Task 36
int [] createMas2(int sizeMas)
{
    int [] mas= new int [sizeMas];
    Random rs=new Random();
    for (int i=0; i<sizeMas; i++)
    {
        mas[i]=rs.Next(0, 100);
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

int sumNechet(int [] mas)
{
    int num=0;
    for (int i=0; i<mas.Length; i++)
    {
        if (i%2!=0)
        {
            num=num+mas[i];
        }
    }
    return num;
}
Console.WriteLine("Task 36");
Console.WriteLine("Введите размер массива: ");
int [] masiv2=createMas2(int.Parse(Console.ReadLine()));
Console.WriteLine($"Сумма элементов на нечетных позициях массива = {sumNechet(masiv2)}");

//Task 38
double [] mas38=new double [] {4, 99, 45.6, 78.1, 345.1, 17};
double difMinMax (double [] masIn)
{
    double max=masIn[0];
    double min=masIn[0];
    for (int i=0; i<masIn.Length; i++)
    {
        if (max<masIn[i])
            max=masIn[i];
        if (masIn[i]<min)
            min=masIn[i];
        if (i<masIn.Length-1)
            Console.Write($"{masIn[i]}, ");
        else
            Console.Write($"{masIn[i]}");
    }
    Console.WriteLine();
    Console.WriteLine($"max={max}, min={min}");
    return max-min;
}
Console.WriteLine("Task 38");
Console.WriteLine($"Разница между минимальным и максимальным числом массива равна = {difMinMax(mas38)}");
