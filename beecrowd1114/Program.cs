using System;

namespace bee1114
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(FixedPassword());
        }

        static string FixedPassword(){
            string pass = Console.ReadLine();
            if(pass!="2002"){
                return "Senha Invalida\n"+FixedPassword();
            }else{
                return "Acesso Permitido";
            }
        }
    }
}
