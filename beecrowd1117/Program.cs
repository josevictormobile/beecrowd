using System.Dynamic;
using System;

namespace beecrowd1117
{
    class Program
    {
        static void Main(string[] args)
        {
           float number1=0f, number2=0f;
           int count=0;
           float score = float.Parse(Console.ReadLine());
           if(ValidateScore(score)){
                if(count==1){
                    number2=score;
                    Console.WriteLine("media = {0}", 
                    AverageBetweenTwoNumbers(number1,number2).ToString("N2"));
                }else{
                    count++;
                    number1=score;
                }   
           }
           else{
                Console.WriteLine("nota invalida");
           }
           
        }

        static bool ValidateScore(float score){
            if(score>10 || score<0)
                return false;
            return true;
        }
        static float AverageBetweenTwoNumbers(float number1, float number2){
            return (number1+number2)/2;
        }    
    }
}
