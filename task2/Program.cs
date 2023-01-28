//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int n = 3;
double max = 0;
for (int i = 1; i <= n; i++) {
    Console.WriteLine("Введите число " + i + ": ");
    double current = Convert.ToDouble(Console.ReadLine());   
    if (i == 1 || current > max) {
        max = current;
    } 
}
 Console.WriteLine("Максимальное число: " + max);