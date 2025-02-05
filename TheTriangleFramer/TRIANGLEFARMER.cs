// yuwenyoh ankinimbom nfi
// 01/28/2025

// prompting user for inputs.

using System;

Console.Write("Enter the base size of the triangle: ");
double baseSize = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the height of the triangle: ");
double height = Convert.ToDouble(Console.ReadLine());

// calculating the area

double area = (baseSize * height) / 2;

// displaying results
Console.WriteLine("the area is: " + area);
