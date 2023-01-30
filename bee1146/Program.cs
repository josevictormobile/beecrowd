
Console.WriteLine(DefaultSolution());//.Remove(answear.Length - 1)
string RecursiveSolution()
{
    string result = string.Empty;
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
    {
        return string.Empty;
    }
    for (int i = 1; i <= x; i++)
    {
        if (i == x)
        {
            result += i.ToString() + "\n";
        }
        else
        {
            result += i.ToString() + " ";
        }
    }
    return result + RecursiveSolution();
}

string DefaultSolution()
{
    string result = string.Empty;
    int x;
    x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
    {
        return result;
    }
    for (int i = 1; i < x; i++)
    {
        result += i.ToString() + " ";
    }
    result += x.ToString();
    while (true)
    {
        x = Convert.ToInt32(Console.ReadLine());
        if (x == 0)
        {
            break;
        }
        else
        {
            result += "\n";
        }
        for (int i = 1; i < x; i++)
        {
            result += i.ToString() + " ";
        }
        result += x.ToString();
    }
    return result;
}