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
