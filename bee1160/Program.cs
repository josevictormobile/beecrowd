using System;

namespace bee1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecursiveSolution(1,t));
        }

        static string RecursiveSolution(int current_number, int test_case_amount){
            int pa, pb;
            double ga, gb;
            int years=0;
            
            string line = Console.ReadLine();
            string[] broken_line = line.Split(' ');
            pa = Convert.ToInt32(broken_line[0]);
            pb = Convert.ToInt32(broken_line[1]);
            ga = Convert.ToDouble(broken_line[2]);
            gb = Convert.ToDouble(broken_line[3]);

            while(pa<=pb){
                if(years>100) break;
                pa += Convert.ToInt32(Math.Floor(pa*ga/100));
                pb += Convert.ToInt32(Math.Floor(pb*gb/100));
                years++;
            }
            
            if(current_number==test_case_amount){
                return $"{years} anos.";
            }
            if(years>100){
                return $"Mais de 1 seculo.\n" 
                + RecursiveSolution(++current_number, test_case_amount);
            }
            return $"{years} anos.\n"
            + RecursiveSolution(++current_number, test_case_amount);
        }
    }
}
