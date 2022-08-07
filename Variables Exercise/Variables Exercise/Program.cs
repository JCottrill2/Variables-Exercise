using System;

namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            string dogName = "Buster";
            int dogAge = 27;
            char exclamation = '!';
            bool isLab = false;
            double vetBill = 300.46;
            decimal milesRun = 43.31678989049m;

            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old{exclamation} \n" +
                    $"People think she is a lab, but that is {isLab}. \n" +
                    $"Her vet bill yesterday was ${vetBill}. Despite being sick, she still ran \n" +
                    $"{milesRun} miles.");


        }
    }
}
