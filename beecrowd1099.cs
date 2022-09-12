using System; 

class URI {

   static int SomaImparesIntervalo(int x, int y)
        {
            int soma=0;
            if (x < y)
            {
                for(int i = x+1;i<y;i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            return soma;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            for(int i = 0; i < n; i++)
            {
                string linha = Console.ReadLine();
                x[i] = int.Parse(linha.Split(' ')[0]);
                y[i] = int.Parse(linha.Split(' ')[1]);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(SomaImparesIntervalo(x[i], y[i]));
            }
        }

}