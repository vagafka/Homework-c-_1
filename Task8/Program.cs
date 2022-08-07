// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
if(number>0)
{
int i = 2;
while (i<number)
{
Console.WriteLine(i);
i=i+2;
}
}
else
{
 int i = 0;
while (i>number)
{
Console.WriteLine(i);
i=i-2;   
}
}