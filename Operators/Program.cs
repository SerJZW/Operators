using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            
            int choice = 8;
            RationalNumbers a = new RationalNumbers(3, 5);
            RationalNumbers b = new RationalNumbers(4, 7);

            while (true)
            {
                a.ToString();
                b.ToString();
                Console.WriteLine("Что вы хотите сделать?\n1)Сложение \n2)Вычитание \n3)Умножение \n4)Деление \n5)Первая больше второй \n6)Первая меньше второй \n7)Равны ли дроби \n8)Не равны ли дроби");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    
                    
                    case 1:
                        //Сумма
                        RationalNumbers addition = a + b;
                        Console.WriteLine($"Результат сложения: {addition}\n");
                        continue;
                    case 2:
                        //Вычитание
                        RationalNumbers substraction = a - b;
                        Console.WriteLine($"Результат вычитания: {substraction}\n");
                        continue;
                    case 3:
                        //Умножение
                        RationalNumbers multiplication = a * b;
                        Console.WriteLine($"Результат умножения: {multiplication}\n");
                        continue;
                    case 4:
                        //Деление
                        RationalNumbers division = a / b;
                        Console.WriteLine($"Результат деления: {division}\n");
                        continue;
                        //Все остальное методы сравнения дробей
                    case 5:
                        bool isGreater = a > b;
                        Console.WriteLine($"Первая дробь больше второй? {isGreater}\n");
                        continue;
                    case 6:
                        bool isLess = a < b;
                        Console.WriteLine($"Первая дробь меньше второй? {isLess}\n");
                        continue;
                    case 7:
                        bool isEquals = a == b;
                        Console.WriteLine($"Обе дроби равны? {isEquals}\n");
                        continue;
                    case 8:
                        bool isNotEquals = a != b;
                        Console.WriteLine($"Обе дроби не равны? {isNotEquals}\n");
                        continue;
                    default:
                        break;
                }
                break;
            }

        }
    }
}

