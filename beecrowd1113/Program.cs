
using System;

namespace beecrowd1113
{
    class Program
    {
        static void Main(string[] args)
        {   
            string saida = AscendingAndDescending();
            System.Console.WriteLine(saida.Remove(saida.Length - 1)); 
        }

        static string AscendingAndDescending(){
            int x,y;
            string line;
            line = Console.ReadLine();
            x= int.Parse(line.Split(' ')[0]);
            y= int.Parse(line.Split(' ')[1]);
            if(x==y)
                return "";
            return x<y ? "Crescente\n"+AscendingAndDescending():"Decrescente\n"+AscendingAndDescending();
        }

    }
}
