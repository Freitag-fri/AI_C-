using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ai_first
{
    class NeironHidden : Neiron
    {
        private double[] libra;
        public double[] Libra { get; set; }

        public NeironHidden(int sizeLedLayer)
        {
            libra = new double[sizeLedLayer];
        }


        public void FuncshenActivation()            //Функция активации
        {
            if(Value > 0.5) { Status = true;}
            else { Status = false;}
        }

        public void Adder(double[] ledLayer)                         //Сумматор
        {
            if(ledLayer.Count() != Libra.Count())  { return; }      //дописать оповещение

            Value = 0;                                              //зброс значения нейронов
            for (int i = 0; i < Libra.Count(); i++)
            {
                Value += Libra[i] * ledLayer[i];   
            }
            FuncshenActivation();
        }
    }
}
