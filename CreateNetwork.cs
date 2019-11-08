using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ai_first
{
    class CreateNetwork
    {
        public Neiron[] inputLayer;

        public NeironHidden[,] hiddenLayer;


        public CreateNetwork(int[] sizeNetwork)
        {
            inputLayer = new Neiron[sizeNetwork[0]];
            hiddenLayer = new NeironHidden[sizeNetwork.Count(), 10];

            for (int i = 0; i < sizeNetwork[0]; i++)     //создание входного слоя
            {
                inputLayer[i] = new Neiron();
            }

            for (int i = 0; i < sizeNetwork.Count() - 1; i++)     //создание скрытого и выходного слоя
            {
                for (int c = 0; c < sizeNetwork[i+1]; c++)     
                {
                    hiddenLayer[i , c] = new NeironHidden(sizeNetwork[i]);
                }
            }
        }
    }
}
