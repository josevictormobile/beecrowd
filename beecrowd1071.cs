using Internal;
using System; 

class URI {

    static void Main(string[] args) { 

        int x, y, sum=0;
        x=Convert.ToInt32(Console.ReadLine());
        y=Convert.ToInt32(Console.ReadLine());
        if (x < y)
        {
            for (int i = x + 1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
        }
        else
        {
            for (int i = y + 1; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
        }
        
        Console.WriteLine(sum);
        
    }
    
}