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
            ISeries aprog = new ArithProgression(4);
            aprog.SetStart(2);
            Console.WriteLine(aprog.GetNext());
            aprog.Reset();
            Console.WriteLine(aprog.GetNext());
            ISeries gprog = new GeomProgression(4);
            gprog.SetStart(4);
            Console.WriteLine(gprog.GetNext());
            gprog.Reset();
            Console.WriteLine(gprog.GetNext());
            Console.ReadKey();
        }
    }    
}
