using System;







double num01;
double num02;
double num03;
string key;
Console.Write("Input a number ");

num01 = Convert.ToDouble( Console.ReadLine() );

Console.Write("Input a second number ");

num02 = Convert.ToDouble( Console.ReadLine() );

Console.Write("Input a third number ");

num03 = Convert.ToDouble( Console.ReadLine() );

double sum = num01 + num02 + num03;

double avg = sum / 3;

Console.WriteLine("The result is " + avg);
Console.Read(key);
Console.Write(key);
Console.ReadKey();

