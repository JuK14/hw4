// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = int.Parse(Console.ReadLine());
int count = 1;
for (int i = 1; i<=b; i++)
{
    count = count*a;
}
Console.WriteLine(count);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int count = 0;
while (a != 0)
{
    int LastDig = a%10;
    count = count + LastDig;
    a = a/10;

}
Console.WriteLine("Сумма цифр в этом числе равна " + count);




// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(0,100);
        index++;
    }
}
void PrintArray(int [] coll)
{
    int count = coll.Length;
    int pos = 0;
    Console.Write("[ ");
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }
    Console.Write("]");
}
int [] array = new int[8];
FillArray (array);
PrintArray (array);
