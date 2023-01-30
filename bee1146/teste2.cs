using System;

class URI
{

    static void Main(string[] args)
    {
        string result = string.Empty;
        int x;
        while (true)
        {
            x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
            for (int i = 1; i < x; i++)
            {
                result += i + " ";
            }
            result += x + "\n";
        }
        Console.WriteLine(result);
    }

}