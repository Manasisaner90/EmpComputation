﻿// See https://aka.ms/new-console-template for more information
using System;
namespace MyFirstProject
{ 
    class Program
    { 
        static void Main(string[] args)
{
    int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empWage = 0;
            int empHrs = 0;
    Random obj = new Random();
        int empCheck = obj.Next(0,2);
        if(empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
        else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : + empwage");

}
}
}
