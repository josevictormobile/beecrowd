using System;

namespace beecrowd1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdIteracoes = int.Parse(Console.ReadLine());
            Console.WriteLine(DividingXByY(qtdIteracoes));
        }

        static string DividingXByY(int qtdIteracoes){
            if(qtdIteracoes==0){
                return "";
            }
            var linha = Console.ReadLine();
            double x = double.Parse(linha.Split(' ')[0]);
            double y = double.Parse(linha.Split(' ')[1]);
            
            if(y==0&&x!=0){
                return "divisao impossivel\n"+DividingXByY(qtdIteracoes-1);
            }else
            {
                var resultado = x/y;
                return resultado.ToString()+"\n"+DividingXByY(qtdIteracoes-1);
            }
        }
    }
}
