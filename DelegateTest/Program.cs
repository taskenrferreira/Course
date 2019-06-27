using System;
using DelegateTest.Services;

namespace DelegateTest {

    delegate double BinaryNumericOperation(double n1, double n2);

    class Program {
        static void Main(string[] args) {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op2 = CalculationService.Max;

            double result = op(a, b);
            double max = op2.Invoke(a, b);
            double square = CalculationService.Square(a);

            Console.WriteLine("Result = " + result);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Square = " + square);
        }
    }
}
