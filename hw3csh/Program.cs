using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3csh
{
    class ComplexNumber
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>

        public double im;

        public ComplexNumber()
        {

        }
        public ComplexNumber(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        //Задание 1 б)
        public ComplexNumber Minus(ComplexNumber x) { return new ComplexNumber(re - x.re, im - x.im); }

        public ComplexNumber Plus(ComplexNumber x) { return new ComplexNumber(re + x.re, im + x.im); }

        public ComplexNumber Multiply(ComplexNumber x) { return new ComplexNumber(re * x.re, im * x.im); }


        public override string ToString()
        {
            return $"{re} + {im}i";
        }



    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            int enterSwitch;
            ComplexNumber number1 = new ComplexNumber(10, 5);
            ComplexNumber number2 = new ComplexNumber(1, 6);
            ComplexNumber number3 = new ComplexNumber();
            //Задание 1 в)
            do
            {
                Console.WriteLine("Выберите операцию которую хотите произвести:");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычитание");
                Console.WriteLine("3.Умножение");
                Console.WriteLine("0.Что бы завершить работу");


                switch (enterSwitch = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        number3 = number1.Plus(number2);
                        Console.WriteLine($"{number1} + {number2} = {number3}");
                        break;
                    case 2:
                        number3 = number1.Minus(number2);
                        Console.WriteLine($"{number1} - {number2} = {number3}");
                        break;
                    case 3:
                        number3 = number1.Multiply(number3);
                        Console.WriteLine($"{number1} * {number2} = {number3}");
                        break;




                }
            } while (enterSwitch != 0);




            PositiveNumber();

        }
        //Задание 2
        public static void PositiveNumber()
        {
            Console.WriteLine("Введите целое число или 0 чтобы завершить работу");
            int inputNumber;
            int sum = 0;

            string inputString = "Нечетные числа которые вы ввели: ";

            do
            {
                if (int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    Console.WriteLine($"Вы ввели число {inputNumber}");
                    if (inputNumber % 2 != 0 && inputNumber > 0)
                    {
                        inputString += inputNumber + ",";
                        sum += inputNumber;
                    }


                }
                else { Console.WriteLine("Вы ввели не правильное значение"); Console.ReadLine(); }
            } while (inputNumber != 0);
            Console.WriteLine($"{inputString} и их сумма: {sum}");
            Console.ReadLine();


        }


    }
}
