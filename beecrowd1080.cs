using System; 

class URI {

        static void Main(string[] args)
        {
            int[] entradas = new int[100];
            int maior,indice=0;
            for (int i= 0;i<entradas.Length;i++)
            {
                entradas[i] = int.Parse(Console.ReadLine());
            }
            maior = entradas[0];
            for (int i = 0; i < entradas.Length; i++)
            {
                if (entradas[i] > maior)
                {
                    maior = entradas[i];
                    indice = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(indice);
        }

}