using System;

namespace desafios.desafio
{
    public class Media
    {
        public void Med()
        {
            int cont = 0;
            double media = 0;
            while (cont < 2)
            {
                double nota = Double.Parse(Console.ReadLine());
                if ((nota >= 0) && (nota < 11))
                {
                    media = media + nota;
                    cont++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            media = media / 2;
            Console.WriteLine("media = "+media.ToString("N2"));
        }
    }
}