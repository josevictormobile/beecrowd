using System; 

class URI {

    static void Main(string[] args) { 

       int adiciona = 0;
            for (int i = 1; i < 10; i += 2)
            {
                for (int j = 7 + adiciona; j > 4 + adiciona; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
                adiciona += 2;
            }

    }

}