using System.Dynamic;
using System;

namespace beecrowd1117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProcessScore(null));
        }
        static bool ValidateScore(float score)
        {
            if (score > 10 || score < 0)
                return false;
            return true;
        }
        
        static string ProcessScore(float? firstValidScore)
        {
            var americanCulture = new CultureInfo("en-US");
            float score = float.Parse(Console.ReadLine(), americanCulture);
            if (ValidateScore(score))
            {
                if (firstValidScore == null)
                {
                    return ProcessScore(score);
                }
                var media =  ((firstValidScore + score) / 2);
                var mediaFormatada = media.ToString().Replace(",",".");
                return $"media = {mediaFormatada}";
            }
            return "nota invalida\n"+ProcessScore(firstValidScore);
        }  
    }
}
