using System;

namespace bee1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if(number1<number2){
                Console.WriteLine(RecursiveSum(number1,number2));
            }else{
                Console.WriteLine(RecursiveSum(number2,number1));
            }
        }

        static void DeafaultSolution(){
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = 0;

            if(number1<number2)
                for(int i=number1;i<=number2;i++)
                    if(i%13 != 0)
                        sum+=i;
            for(int i=number2;i<=number1;i++)
                if(i%13 != 0)
                    sum+=i;
            
            Console.WriteLine(sum);
        }

        static int RecursiveSum(int number1, int number2){
            if(number1==number2){
                if(number1%13 != 0){
                    return number1;
                }else{
                    return 0;
                }   
            }  
            if(number1%13 != 0){
                return number1 + RecursiveSum(number1+1,number2);
            } 
            return 0 + RecursiveSum(number1+1,number2);
        }
        
    }
}
