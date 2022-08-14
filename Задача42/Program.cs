/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
int n = Convert.ToInt32(Console.ReadLine());
string end = "";
while (n > 0)
{
    int x = n % 2;
    end = Convert.ToString(x) + end;
    n /= 2;
}
Console.WriteLine(end);
