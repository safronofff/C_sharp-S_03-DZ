﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

for (int y = 1; y <= x; y++)
{
	int z = y * y * y;
	Console.WriteLine(z);
}
