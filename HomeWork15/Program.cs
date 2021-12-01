using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    //Разработать интерфейс ISeries генерации ряда чисел.Интерфейс содержит следующие элементы:
    //метод void setStart(int x) - устанавливает начальное значение
    //метод int getNext() - возвращает следующее число ряда
    //метод void reset() - выполняет сброс к начальному значению
    //Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
    //В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
    class Program
    {
        static void Main(string[] args)
        {            
            int arithStep = ReadValue("Введите пожалуйста шаг арифметической прогрессии:");
            int aStartValue = ReadValue("введите стартовое значение ряда:");
            int arithCount = ReadValue("Количество членов, выводимых на консоль:");
            int[] arithArray = new int[arithCount];
            ArithProgression aprog = new ArithProgression(arithStep);
            aprog.SetStart(aStartValue);
            for (int i = 1; i < arithCount; i++)
            {
                arithArray[i] = (aprog.GetNext());
            }
            Console.WriteLine("Следующие члены прогрессии:");
            for (int i = 1; i < arithCount; i++)
            {
                Console.WriteLine(arithArray[i]);
            }
            aprog.Reset();
            Console.WriteLine();
            int geomStep = ReadValue("Введите пожалуйста шаг геометрической прогрессии:");
            int gStartValue = ReadValue("введите стартовое значение ряда:");
            int geomCount = ReadValue("Количество членов, выводимых на консоль:");
            int[] geomArray = new int[geomCount];
            GeomProgression gprog = new GeomProgression(geomStep);
            gprog.SetStart(gStartValue);
            for (int i = 1; i < geomCount; i++)
            {
                geomArray[i] = (gprog.GetNext());
            }
            Console.WriteLine("Следующие члены прогрессии:");
            for (int i = 1; i < geomCount; i++)
            {
                Console.WriteLine(geomArray[i]);
            }
            gprog.Reset();
            Console.ReadKey();
        }
        static int ReadValue(string text)   //метод проверяющий корректность ввода данных
        {
            int value;
            while (true)
            {
                Console.WriteLine(text);
                if (Int32.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Ввод некорректен");
                }
            }
        }
    }
}
