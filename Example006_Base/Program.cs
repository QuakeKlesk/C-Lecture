﻿int a = 1;
int b = 5;
int c = 10;
int d = 7;
int e = 3;

int max = a;
if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = c;

Console.Write("max = ");
Console.WriteLine(max);