using System; 

class URI {

        static void Main(string[] args)
        {
            int n, tCobaias=0, tCoelhos=0, tRatos=0, tSapos=0;
            decimal pCoelhos, pRatos, pSapos;

            string entrada;
            string[] entradas = new string[2];

            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                entrada = Console.ReadLine();
                entradas = entrada.Split(" ");
                if (entradas[1] == "C")
                {
                    tCoelhos += int.Parse(entradas[0]);
                }
                if (entradas[1] == "R")
                {
                    tRatos += int.Parse(entradas[0]);
                }
                if (entradas[1] == "S")
                {
                    tSapos += int.Parse(entradas[0]);
                }
            }
            tCobaias = tCoelhos + tRatos + tSapos;
            pCoelhos = (decimal)tCoelhos / tCobaias;
            pRatos = (decimal)tRatos / tCobaias;
            pSapos = (decimal)tSapos / tCobaias;

            Console.WriteLine("Total: {0} cobaias", tCobaias);
            Console.WriteLine("Total de coelhos: {0}", tCoelhos);
            Console.WriteLine("Total de ratos: {0}", tRatos);
            Console.WriteLine("Total de sapos: {0}", tSapos);
            Console.WriteLine("Percentual de coelhos: {0} %", Math.Round(pCoelhos*100,2));
            Console.WriteLine("Percentual de ratos: {0} %", Math.Round(pRatos * 100, 2));
            Console.WriteLine("Percentual de sapos: {0} %", Math.Round(pSapos * 100, 2));

        }

}