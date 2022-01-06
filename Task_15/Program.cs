using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression ar = new ArithProgression();
            GeomProgression ge = new GeomProgression();

            Console.WriteLine("Введите первый элемент для арифметической и геометрической прогрессий:\t");
            double elementsFirst = double.Parse(Console.ReadLine());
            ar.setStart(elementsFirst);
            ge.setStart(elementsFirst);



            Console.WriteLine("Введите шаг:\t");
            double elementStep = double.Parse(Console.ReadLine());
            ar.setStep(elementStep);
            ge.setStep(elementStep);


            Console.WriteLine("Введите количество элементов до сброса:\t");
            uint elementsCount1 = uint.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ряд арифметической прогрессии:\n");

            for (int i = 0; i < elementsCount1; i++)
            {
                Console.WriteLine("Следующий элемент арифметической прогрессии:\t");
                Console.WriteLine(ar.getNext());
            }

            Console.WriteLine();
            Console.WriteLine("Ряд геометрической прогрессии:\n");

            for (int i = 0; i < elementsCount1; i++)
            {
                Console.WriteLine("Следующий элемент геометрической прогрессии:\t");
                Console.WriteLine(ge.getNext());
            }


            Console.WriteLine("\t");

            Console.WriteLine("Сброс до начальных значений:\t");
            ar.reSet();

            Console.WriteLine("\t");

            Console.WriteLine("Введите количество элементов после сброса:\t");
            uint elementsCount2 = uint.Parse(Console.ReadLine());

            Console.WriteLine(); 
            Console.WriteLine("Ряд арифметической прогрессии после сброса:\n");

            for (int i = 0; i < elementsCount2; i++)
            {
                Console.WriteLine("Следующий элемент арифметической прогрессии:\t");
                Console.WriteLine(ar.getNext());
            }

            Console.WriteLine();
            Console.WriteLine("Ряд геометрической прогрессии после сброса:\n");

            for (int i = 0; i < elementsCount2; i++)
            {
                Console.WriteLine("Следующий элемент геометрической прогрессии:\t");
                Console.WriteLine(ge.getNext());
            }
            Console.ReadKey();



        }
    }
}
