// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Numbers (int n)
{
    int sum = 0;
    while(n>0)
    {
       sum = sum + n % 10;
       n/=10;
    }
    return sum;
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int nu = Numbers(num);

Console.WriteLine($"Сумма чисел {nu}");

