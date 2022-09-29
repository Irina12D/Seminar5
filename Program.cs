/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
*/
/*
int[] Mas_Input(int len)
{
    Random rnd = new Random();
    int[] a = new int[len];
    for (int i=0; i< len; i++)
        a[i] = rnd.Next(100,1000);
    return a;    
}

void Mas_Print(int[] a)
{
    for (int i=0; i< a.Length; i++)
        Console.Write(a[i] + " ");
    Console.WriteLine();    
}

int Count(int[] a)
{
    int k = 0;
    for (int i=0; i< a.Length; i++)
        if(a[i] % 2 == 0)
            k++;
    return k;     
}

int n = new Random().Next(5,13);
int [] mas = Mas_Input(n);
Mas_Print(mas);
Console.WriteLine($"количество чётных элементов массива = {Count(mas)}");
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/

int[] Mas_Input(int len)
{
    Random rnd = new Random();
    int[] a = new int[len];
    for (int i=0; i< len; i++)
        a[i] = rnd.Next(0,21);
    return a;    
}

void Mas_Print(int[] a)
{
    for (int i=0; i< a.Length; i++)
        Console.Write(a[i] + " ");
    Console.WriteLine();    
}

int Sum(int[] a)
{
    int s = 0;
    for (int i=1; i< a.Length; i+=2)
        s += a[i];
    return s;     
}

int n = new Random().Next(5,11);
int [] mas = Mas_Input(n);
Mas_Print(mas);
Console.WriteLine($"суммa элементов, стоящих на нечётных позициях, равна {Sum(mas)}");