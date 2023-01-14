using System;

namespace bee1131
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = new GrenalSummary();
            Console.WriteLine(NewGrenal(summary)); 
        }

        static string NewGrenal(GrenalSummary summary)
        {
            string scores = Console.ReadLine();
            string[] splittedScore = scores.Split(' ');
            int golsInter = int.Parse(splittedScore[0]);
            int golsGremio = int.Parse(splittedScore[1]);
            var gameResult = GetGrenalResult(golsInter, golsGremio);
            summary.GrenalsAmount++;
            switch (gameResult)
            {
                case GrenalResult.Draw:
                    summary.DrawsAmount++;
                    break;
                case GrenalResult.InterWon:
                    summary.InterVictories++;
                    break;
                case GrenalResult.GremioWon:
                    summary.GremioVictories++;
                    break;
            }
            int wasThereNewGrenal = int.Parse(Console.ReadLine());
            if (ThereWasNewGrenal(wasThereNewGrenal))
                return AskNewGrenalQuestion() + NewGrenal(summary);
            return AskNewGrenalQuestion() + OutputGrenalSummary(summary);
        }

        static GrenalResult GetGrenalResult(int golsInter, int golsGremio)
        {
            if (golsInter == golsGremio)
                return GrenalResult.Draw;
            if (golsInter > golsGremio)
                return GrenalResult.InterWon;
            return GrenalResult.GremioWon;
        }

        static bool ThereWasNewGrenal(int answear)
        {
            if (answear == 1)
                return true;
            return false;
        }

        static string AskNewGrenalQuestion()
        {
            return "Novo grenal (1-sim 2-nao)\n";
        }

        static string OutputGrenalSummary(GrenalSummary summary)
        {
            return $"{summary.GrenalsAmount} grenais\n"
                +$"Inter:{summary.InterVictories}\n"
                +$"Gremio:{summary.GremioVictories}\n"
                +$"Empates:{summary.DrawsAmount}\n"
                +WhoWonMore(summary.InterVictories, summary.GremioVictories);
        }

        static string WhoWonMore(int interVictories, int gremioVictories)
        {
            if (interVictories == gremioVictories)
                return "Nao houve vencedor";
            if (interVictories > gremioVictories)
                return "Inter venceu mais";
            return "Gremio venceu mais";
        }
    }

    public enum GrenalResult
    {
        InterWon,
        GremioWon,
        Draw
    }

    public class GrenalSummary
    {
        public int GrenalsAmount { get; set; }
        public int InterVictories { get; set; }
        public int GremioVictories { get; set; }
        public int DrawsAmount { get; set; }
    }
    
}
