using System;
using System.Collections.Generic;

namespace desafios.desafio
{
    public class MundoDeOz
    {
        public void MundoOz()
        {
            List<string> lista = new List<string>();
            string linha;

            while ((linha = System.Console.ReadLine()) != null)
            {
                if (!lista.Contains(linha))
                {
                    lista.Add(linha);
                }
            }

            Console.WriteLine(lista.Count);
        }
    }
}