using System; 

class URI {

    static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            float[] respostas = new float[n];
            for(int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                float x = float.Parse(linha[0]);
                float y = float.Parse(linha[1]);
                float z = float.Parse(linha[2]);
                respostas[i] = (float)Math.Round((x * 2 + y * 3 + z * 5) / 10,1);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(respostas[i]);
            }
            
            Console.Read();
        }

}