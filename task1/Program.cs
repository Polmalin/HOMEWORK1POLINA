//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a>b) 
{
    Console.WriteLine("первое число больше второго");
}
else if (a<b) 
{
    Console.WriteLine("второе число больше первого");
}
else
{
Console.WriteLine("второе и первое числа равны");
}