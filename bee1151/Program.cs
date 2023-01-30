using System.Collections.Generic;

Console.WriteLine(Fibonacci());

string Fibonacci()
{
    int n = Convert.ToInt32(Console.ReadLine());
    string result = string.Empty;
    if (n == 0)
        return result;
    if (n == 1)
        return "0";
    var fibonacci = new List<int> { 0, 1 };
    int next;
    for (int i = 1; i < n - 1; i++)
    {
        next = fibonacci[i] + fibonacci[i - 1];
        fibonacci.Add(next);
    }

    foreach (var number in fibonacci)
    {
        result += number + " ";
    }
    return result.Remove(result.Length-1);
}