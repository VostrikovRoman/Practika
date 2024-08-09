using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika
{
    internal class TimeToStart
    {
        public int value; //Значение объекта
        string imenit_padej; //Объект в И.П.
        string rodit_padej; //Объект в Р.П.
        string rodit_padej_ed_number; //Объект в Р.П. в ед.ч.

        public TimeToStart (string imenit_padej, string rodit_padej, string rodit_padej_ed_number)
        {
            value = 0;
            this.imenit_padej = imenit_padej;
            this.rodit_padej= rodit_padej;
            this.rodit_padej_ed_number = rodit_padej_ed_number;
        }

        public string ChangeValue()
        {
            int ValueTime = value;
            if (ValueTime > 100)
                ValueTime = ValueTime % 100;
            if (ValueTime >= 11 && ValueTime <= 14)
                return " " + rodit_padej + " ";
            ValueTime = ValueTime % 10;

            switch (ValueTime)
            {
                case 1:
                    return " " + imenit_padej + " ";
                case 2:
                case 3:
                case 4:
                    return " " + rodit_padej_ed_number + " ";
                default:
                    return " " + rodit_padej + " ";

            }
        }
    }
}
