using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Section15223_GenericsSetDictionary
{
    public class UserStory223
    {
        public static void Main()
        {
            var electionResult = new Dictionary<string, int>();

            string votesPath = Directory.GetCurrentDirectory() + @"..\..\..\..\src\votes.csv";
            string[] ballotBox = File.ReadAllLines(votesPath);

            for (int line = 0; line < ballotBox.Count(); line++)
            {
                string[] content = ballotBox[line].Split(';');

                if (!electionResult.TryAdd(content[0], int.Parse(content[1])))
                {
                    electionResult[content[0]] += int.Parse(content[1]);
                }
            }
          
            foreach (var candidate in electionResult)
            {
                Console.WriteLine(candidate.Key + ": " + candidate.Value);
            }            
        }
    }
}