using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    class GeomProgression : ISeries
    {
        private int geomStep;      //задает шаг прогрессии
        public int GeomStep
        {
            get
            {
                return geomStep;
            }
            set
            {
                if (value == 1)
                {
                    Console.WriteLine("Шаг геометрической прогрессии равен 1, прогрессия стационарна");
                }
                geomStep = value;
            }
        }
        public int StartValue { get; set; }     //стартовое значение
        public int ProgMember { get; set; }     //следующий член прогрессии
        public GeomProgression(int geomStep)
        {
            StartValue = 0;
            GeomStep = geomStep;
            ProgMember = 0;
            Console.WriteLine($"Шаг геометрической прогрессии {GeomStep}");
        }
        public void SetStart(int startNumber)
        {
            ProgMember = startNumber;
            StartValue = ProgMember;
            Console.WriteLine($"Первый член прогрессии: {StartValue}");
        }
        public int GetNext()
        {
            return ProgMember *= GeomStep;
        }
        public void Reset()
        {
            ProgMember = StartValue;
            Console.WriteLine($"Выполнено обнуление до первого члена прогрессии: {StartValue}");
        }
    }
}
