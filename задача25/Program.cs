// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());


int St (int a, int b)

{
    int count=1;
for (int i = 1;  i<= b; i++)

{

count = count*a;
}
return count;
}
int result = St(A,B);
Console.WriteLine($"Степень числа {A} = {result}");


