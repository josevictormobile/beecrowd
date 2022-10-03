using System;

namespace beecrowd1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[n];
            for(int i=0;i<n;i++){
                var linha = Console.ReadLine();
                x[i] = double.Parse(linha.Split(' ')[0]);
                y[i] = double.Parse(linha.Split(' ')[1]);
            }
            for(int i=0;i<n;i++){
                if(y[i]==0&&x[i]!=0){
                    Console.WriteLine("divisao impossivel");
                }else{
                    Console.WriteLine(Math.Round(x[i]/y[i],1));    
                }
            }
        }

    }
}
