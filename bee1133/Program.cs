using System;

namespace bee1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if(number1<number2){
               Console.WriteLine(RecursiveSolution(number1+1, number2));
            }else{
                Console.WriteLine(RecursiveSolution(number2+1, number1));
            }       
        }
        static void DefaultSolution(){
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if(number1<number2){
                for(int i = number1+1;i<number2;i++)
                    if(i%5==2||i%5==3)
                        Console.WriteLine(i);
            }else{
                for(int i = number2+1;i<number1;i++)
                    if(i%5==2||i%5==3)
                        Console.WriteLine(i);
            }       
        }

        static string RecursiveSolution(int number1, int number2){
            if(number1==number2){
                return string.Empty;
            }
            if(number1%5==2||number1%5==3){
                    return number1.ToString()+"\n"+RecursiveSolution(number1+1,number2);
                } else{
                    return RecursiveSolution(number1+1,number2);
                }
        }


        
    }
}
