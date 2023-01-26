using System;

namespace bee1134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecursiveSolution(0,0,0));
        }

        static string RecursiveSolution(int alcohol, int gas, int diesel){
            int typeOfFuel = int.Parse(Console.ReadLine());
            switch(typeOfFuel){
                case 1:
                    return RecursiveSolution(alcohol+1,gas,diesel);
                case 2:
                    return RecursiveSolution(alcohol,gas+1,diesel);
                case 3:
                    return RecursiveSolution(alcohol,gas,diesel+1);
                case 4:
                    return "MUITO OBRIGADO\n"
                    +$"Alcool: {alcohol}\n"
                    +$"Gasolina: {gas}\n"
                    +$"Diesel: {diesel}";
                default:
                    return RecursiveSolution(alcohol,gas,diesel);
            } 
        }
    }
}
