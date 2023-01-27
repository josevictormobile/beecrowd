using System;

namespace bee1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLines = int.Parse(Console.ReadLine());
            int linha =1;
            for(int i=1;linha<=maxLines;i+=4){
                Console.WriteLine($"{i} {i+1} {i+2} PUM");
                linha++;
            }
                
        }

        static string RecursiveSolution(int currentLine, int firstNumberRow, int maxLines){
            if(currentLine==maxLines)
                return $"{firstNumberRow} {firstNumberRow+1} {firstNumberRow+2} PUM";
            return $"{firstNumberRow} {firstNumberRow+1} {firstNumberRow+2} PUM\n"
                + RecursiveSolution(currentLine+1,firstNumberRow+4,maxLines);
        }//solução muito lenta

    }
}
