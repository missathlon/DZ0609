// Задача 23

// Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Vvedite chislo N = ");
int N = Convert.ToInt16(Console.ReadLine());
int i = 1;
for (i = 1; i <= N; i++)
    Console.WriteLine(i + "^3 = " + i * i * i);