﻿int a = new Random().Next(0,10);
int b = new Random().Next(0,10);
int c = new Random().Next(0,10);
int d = new Random().Next(0,10);
int maximum = 0;
if (a > maximum) maximum = a;
if (c > maximum) maximum = c;
if (b > maximum) maximum = b;
if (d > maximum) maximum = d;
Console.Write("были загаданы числа: ");
Console.Write(a);
Console.Write(b);
Console.Write(c);
Console.WriteLine(d);
Console.Write("максимальное число: ");
Console.Write(maximum);