using System;

namespace desafios.desafio
{
    class QuadradoaoCubo
    {
        public void QuadCubo()
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
    }
}