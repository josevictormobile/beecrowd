using System;
using System.Globalization;

namespace beecrowd1118
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputResult = ProcessScore(null) + ProgramLoop();
            Console.WriteLine(outputResult);
        }
        static bool ValidateScore(float score)
        {
            if (score > 10 || score < 0)
                return false;
            return true;
        }
        static bool ValidateOption(int option)
        {
            if (option > 2 || option < 1)
                return false;
            return true;
        }
        static string ProgramLoop()
        {
            int option = int.Parse(Console.ReadLine());
            
            if (ValidateOption(option))
            {
                if(option==1)
                    return "novo calculo (1-sim 2-nao)\n" + ProcessScore(null) + ProgramLoop();
                return "novo calculo (1-sim 2-nao)";
            }
            else
            {
                return "novo calculo (1-sim 2-nao)\n"+ ProgramLoop();
            }
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
                float media =  (((float)firstValidScore + score) / 2.0f);
                var mediaFormatada = media.ToString("N2").Replace(",",".");
                return $"media = {mediaFormatada}\n";
            }
            return "nota invalida\n"+ProcessScore(firstValidScore);
        }
    }
}
