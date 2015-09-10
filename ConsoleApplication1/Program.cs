using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complex1 = new ComplexNumber(1, 3);
            ComplexNumber complex2 = new ComplexNumber(2, 4);
            ComplexNumber sum = complex1 + complex2;
            ComplexNumber sub = complex1 - complex2;
            ComplexNumber mult = complex1 * complex2;

            Console.WriteLine("Sum of two complex numbers: {0}", sum);
            Console.WriteLine("Substraction of two complex numbers: {0}", sub);
            Console.WriteLine("Multiplication of two complex numbers: {0}", mult);
            Console.ReadLine();

        }
    }

    struct ComplexNumber
    {
        int real;
        int imaginary;
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.real + number2.real, number1.imaginary + number2.imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.real - number2.real, number1.imaginary - number2.imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.real * number2.real - number1.imaginary * number2.imaginary, number1.real * number2.imaginary + number2.real * number1.imaginary);
        }
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }
}
