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
Console.WriteLine("Введите размер массива трехзначных чисел");
int [] masiv=createMas(int.Parse(Console.ReadLine()));
Console.WriteLine($"{numChet(masiv)}");
