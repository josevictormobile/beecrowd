using System;

namespace bee1159
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = RecursiveSolution();
            Console.WriteLine(resultado.Remove(resultado.Length-1));
        }

        static string RecursiveSolution(){
            int x = Convert.ToInt32(Console.ReadLine());
            if(x==0) return string.Empty;
            int sum=0;
            int amount_even=0;
            while(amount_even<5){
                if(x%2==0){
                    sum+=x;
                    amount_even++;
                }
                x++;
            }
            return sum.ToString() + "\n" + RecursiveSolution();
        }
    }
}
