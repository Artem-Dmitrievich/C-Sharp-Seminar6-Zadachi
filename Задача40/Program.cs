/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
