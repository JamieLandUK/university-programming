using System;

namespace football_scorer
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = "Manchester United 1;Chelsea 0,Arsenal 1;Manchester United 0," +
                             "Manchester United 3;Fulham 1,Liverpool 2;Manchester United 1," +
                             "Swansea 2;Manchester United 4";
            var result = results.Split(',');
            string[,] matches = new string[5,2];
            var draws = 0;
            var wins = 0;
            var losses = 0;
            var goals_scored = 0;
            var goals_conceded = 0;
            var points = 0;

            for (int i = 0; i < result.Length; i++)
            {
                matches[i, 0] = result[i].Substring()
            }
        }
    }
}