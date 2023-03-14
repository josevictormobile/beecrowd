using System;

namespace bee1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecursiveSolution(input1, 1));
        }

        static string RecursiveSolution(int max_iterations, int current_iteration){
            int input2 = Convert.ToInt32(Console.ReadLine());
            if(current_iteration == max_iterations){
                var result = $"{input2} eh primo";
                for(int i=input2-1;i>1;i--){
                    if(input2%i==0){
                        result = $"{input2} nao eh primo";
                        return result;
                    }
                }
                return result;
            }else{
                var result = $"{input2} eh primo\n";
                for(int i=input2-1;i>1;i--){
                    if(input2%i==0){
                        result = $"{input2} nao eh primo\n";
                        return result + RecursiveSolution(max_iterations, ++current_iteration);
                    }
                }
                return result + RecursiveSolution(max_iterations, ++current_iteration);
            }
            
        }
    }
}
