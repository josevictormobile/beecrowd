using System;

namespace bee1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecursiveSolution(n,0));
        }

        static string RecursiveSolution(int max_iterations, int current_iteration)
        {
            string line = Console.ReadLine();
            string[] broken_line = line.Split(' ');
            int x = Convert.ToInt32(broken_line[0]);
            int y = Convert.ToInt32(broken_line[1]);
            int sum = 0;
            int odd_amount = 0;
            while(odd_amount!=y){
                if(x%2!=0)
                {
                    sum+=x;
                    odd_amount++;
                }
                x++;
            }

            current_iteration++;
            if(current_iteration==max_iterations)
                return sum.ToString();
            return sum.ToString() + "\n" + RecursiveSolution(max_iterations, current_iteration);
        }
    }
}
