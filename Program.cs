﻿int year;
Console.WriteLine("Enter a year: ");
year = Convert.ToInt32(Console.ReadLine());
if (year %4 ==0 || year%100 ==0 || year%400==0)
{
    Console.WriteLine("{0} is a leap year", year);
}else
{
    Console.WriteLine("{0} is NOT a leap year", year);
}
