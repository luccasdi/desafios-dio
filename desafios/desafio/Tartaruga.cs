using System;

namespace desafios.desafio
{
    class Tartaruga
    {
        public void Tartarug()
        {
            for (int j = 0; j <= 5; j++)
            {
                string valorStr = Console.ReadLine();
                string[] valorStrV = valorStr.Split(" ");
                int aux = 0;

                for (int i = 0; i < valorStrV.Length; i++)
                {
                    if (i == 0)
                    {
                        aux = Int32.Parse(valorStrV[i]);
                        //Console.WriteLine(i);
                    }
                    else if (aux < Int32.Parse(valorStrV[i]))
                    {
                        aux = Int32.Parse(valorStrV[i]);
                        //Console.WriteLine(aux);
                    }
                }

                if (aux >= 20)
                {
                    Console.WriteLine(3);
                }
                else if (aux < 10)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(2);
                }
            }
        }
    }
}