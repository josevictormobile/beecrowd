using System;

namespace bee1164
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(RecursiveSolution(1,n));
        }

        static string RecursiveSolution(int current_number, int max_number_test_case)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for(int i=x-1; i>0; i--){
                if(x%i==0){
                    sum+=i;
                }
            }
            if(current_number==max_number_test_case){
                if(sum==x){
                    return $"{x} eh perfeito";
                }else{
                    return $"{x} nao eh perfeito";
                }
            }
            if(sum==x){
                    return $"{x} eh perfeito\n"
                    + RecursiveSolution(++current_number, max_number_test_case);
                }else{
                    return $"{x} nao eh perfeito\n"
                    + RecursiveSolution(++current_number, max_number_test_case);
                }
        }
    }
}
