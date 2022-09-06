// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Vvedite 5-zn chislo ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 10000 || a > 99999)
{
    Console.WriteLine("Vvedite drugoe chislo ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a % 10 == a / 10000 && (a % 100) / 10 == (a / 1000) % 10)
    Console.WriteLine("da");
else
    Console.WriteLine("net");