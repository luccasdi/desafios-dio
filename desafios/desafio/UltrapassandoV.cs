using System;

namespace desafios.desafio
{
    public class UltrapassandoV
    {
        public void UltraV() {
            {
                int R = Convert.ToInt32(Console.ReadLine());
                int V = R - 1;
                int i = 2;
                int aux = R;
                int s = 1;
                while (V <= R)
                {
                    V = Convert.ToInt32(Console.ReadLine());
                }
                while (aux <= V)
                {
                    aux = aux + R + s;

                    if (aux <= V)
                    {
                        i++;
                        s++;
                    }
                }
                Console.WriteLine(i);
            }
        }
    }
}