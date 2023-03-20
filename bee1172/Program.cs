using System;

namespace bee1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[10];
            for(int i=0;i<10;i++){
                arrayInt[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<10;i++){
                if(arrayInt[i]<=0){
                    arrayInt[i] = 1;
                }
                Console.WriteLine($"X[{i}] = {arrayInt[i]}");
            }
        }
    }
}
