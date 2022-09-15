using System; 

class URI {

    static void Main(string[] args) { 

            int[] entrada = new int[100];
            int maior;
            int position=0;
            for (var i = 0; i < 100; i++)
            {
                entrada[i] = int.Parse(Console.ReadLine());
                
            }
            maior = entrada[0];
            for (var i = 0; i < 100; i++)
            {
                if (entrada[i] > maior) { maior = entrada[i]; position = i; }
            }

            
            Console.WriteLine(maior);
            Console.WriteLine(position+1);

    }

}