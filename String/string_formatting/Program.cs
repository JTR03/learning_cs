﻿int[] quarters = {1,2,3,4};
int[] sales = {10000,150000,200000,2254000};
double[] intMixPct = {.386, .413,.421, .457};
string str1 = "Teststr";
int val1 =1234;
decimal val2 = 1245.52145m;

// basic formatting
Console.WriteLine("{0}", str1);
Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}",val1);
Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}",val2);

// precision specifier
Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}",val1);

// alignment and spacing
Console.WriteLine("{0,12} {1,12} {2,12} {3,12}",
quarters[0],quarters[1],quarters[2],quarters[3]);

Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}",
sales[0],sales[1],sales[2],sales[3]);

Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}",
intMixPct[0],intMixPct[1],intMixPct[2],intMixPct[3]);
