using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3csh
{
    internal class Class1
    {
        struct Complex
        {
            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            public double re;

            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>

            public double im;


            // Задание 1 а)
            public Complex Minus(Complex x)
            {
                Complex complexRes;
                complexRes.re = re - x.re;
                complexRes.im = im - x.im;
                return complexRes;
            }
            public Complex Plus(Complex x)
            {
                Complex complexRes;
                complexRes.re = re + x.re;
                complexRes.im = im + x.im;
                return complexRes;
            }



            public override string ToString()
            {
                return $"{re} + {im}i";
            }

            static void Main(string[] args)
            {

                Complex complex1;
                Complex complex2;
                complex1.re = 5;
                complex1.im = 10;
                Console.WriteLine($"Первое комплексное число {complex1}");

                complex2.re = 7;
                complex2.im = 11;
                Console.WriteLine($"Второе комплексное число {complex2}");
                Complex complex3 = complex1.Minus(complex2);

                Console.WriteLine($"Результат вычитания {complex3}");
                Console.ReadLine();
            }

        }
    }
}
