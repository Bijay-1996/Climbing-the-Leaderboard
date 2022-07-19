using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Climbing_the_Leaderboard
    {
        //List<int> Result = new List<int>();
        public void Main(string[] args)
        {
            List<int> ranked = new List<int> { 100, 90, 90, 50, 23 };
            List<int> player = new List<int> { 105, 55, 99 };
            List<int> list = climbingLeaderboard(ranked,player);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();

            var cleanerRank = ranked.ToHashSet().ToArray();
            int i = cleanerRank.Length - 1;

            for (int j = 0; j < player.Count; j++)
            {
                bool rankFound = false;
                while (!rankFound && i >= 0)
                {
                    if (player[j] < cleanerRank[i])
                    {
                        result.Add(i + 2);
                        rankFound = true;
                    }
                    else if (player[j] == cleanerRank[i])
                    {
                        result.Add(i + 1);
                        rankFound = true;
                    }
                    else
                    {
                        i--;
                    }
                }

                if (!rankFound)
                {
                    result.Add(1);
                }
            }

            return result;
        }

    }
}