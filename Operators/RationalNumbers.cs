using System;

namespace Operators
{
    public class RationalNumbers
    {
        //Поля класса
        public int numerator { get; }
        public int denominator { get; }
        // Конструктор
        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }
        // Операция сложения
        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int commonDenominator = a.denominator * b.denominator;
            return new RationalNumbers(numerator, commonDenominator);
        }
        // Операция вычитания
        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int commonDenominator = a.denominator * b.denominator;
            return new RationalNumbers(numerator, commonDenominator);
        }
        // Операция умножения
        public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;

            return new RationalNumbers(numerator, denominator);
        }
        // Операция деления
        public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b)
        {
            int numerator = a.numerator * b.denominator;
            int denominator = a.denominator * b.numerator;
            return new RationalNumbers(numerator, denominator);
        }
        // Операция сравнения что первая дробь больше второй
        public static bool operator >(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }
        // Операция сравнения что первая дробь меньше второй
        public static bool operator <(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }
        // Операция равности дробей
        public static bool operator ==(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }
        // Операция неравности дробей
        public static bool operator !=(RationalNumbers a, RationalNumbers b)
        {
            return a.numerator * b.denominator != b.numerator * a.denominator;
        }
        // Вывод значения
        public override string ToString()
        {
            Console.WriteLine($"{numerator}/{denominator}");
            return $"{numerator}/{denominator}";
            
        }
    }
}
