using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    class ArithProgression : ISeries
    {
        private int arithStep;      //задает шаг прогрессии
        public int ArithStep
        {
            get
            {
                return arithStep;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Шаг арифметической прогрессии равен 0, прогрессия стационарна");
                }
                arithStep = value;
            }
        }
        public int StartValue { get; set; }     //стартовое значение
        public int ProgMember { get; set; }     //следующий член прогрессии
        public ArithProgression(int arithStep)
        {
            StartValue = 0;
            ArithStep = arithStep;
            ProgMember = 0;
            Console.WriteLine($"Шаг арифметической прогрессии {ArithStep}");
        }
        public void SetStart(int startNumber)
        {
            ProgMember = startNumber;
            StartValue = ProgMember;
            Console.WriteLine($"Первый член прогрессии: {StartValue}");
        }
        public int GetNext()
        {
            return ProgMember += ArithStep;
        }
        public void Reset()
        {
            ProgMember = StartValue;
            Console.WriteLine($"Выполнено обнуление до первого члена прогрессии: {StartValue}");
        }
    }    
}