/// Week 13 Project 1
///
/// @author: Julian Trupe
/// Date:  November 19, 2021
///
/// Problem Statement: Allow the user to type a name, tell user the rank of the name on the girls/boys lists
//
/// Overall Plan:
/// 1) Define an object CountRank with properties count and rank as shows above
/// 2) Define BoyNames and GirlNames, two dictionaries
/// 3) Read boynames.txt and girlnames.txt into dictionaries where key= person's name value = CountRank
/// 4) Prompt user to enter a name
/// 5) User ContainsKey to check each Dictionary 
/// 6) Display results message to the console 

using System;
using System.IO;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rankM = 1;
            int rankF = 1;
            Dictionary<string, CountRank> BoyNames = new Dictionary<string, CountRank>();
            Dictionary<string, CountRank> GirlNames = new Dictionary<string, CountRank>();
            foreach(string line in File.ReadLines("D:\\MiraCosta Schoolwork\\CS 155\\Week13\\Project1\\boynames.txt"))
            {
                string[] temp = line.Split();
                CountRank tempCR = new CountRank(Convert.ToInt32(temp[1]), rankM);
                BoyNames.Add(temp[0], tempCR);
                rankM++;

                //Testing fileread to dictionary works properly
                //Console.WriteLine(temp[0] + " " + BoyNames.ContainsKey(temp[0]) + " " + BoyNames[temp[0]].Count + " " + BoyNames[temp[0]].Rank);
            }
            foreach (string line in File.ReadLines("D:\\MiraCosta Schoolwork\\CS 155\\Week13\\Project1\\girlnames.txt"))
            {
                string[] temp = line.Split();
                CountRank tempCR = new CountRank(Convert.ToInt32(temp[1]), rankF);
                GirlNames.Add(temp[0], tempCR);
                rankF++;

                //Testing fileread to dictionary works properly
                //Console.WriteLine(temp[0] + " " + GirlNames.ContainsKey(temp[0]) + " " + GirlNames[temp[0]].Count + " " + GirlNames[temp[0]].Rank);
            }
            Console.WriteLine("Please enter a name and will tell you its rank among boys and girls");
            string inputName = Console.ReadLine();
            if (BoyNames.ContainsKey(inputName))
            {
                Console.WriteLine(inputName + " is ranked " + BoyNames[inputName].Rank + " among boys with " + BoyNames[inputName].Count + " namings.");
            }
            else
            {
                Console.WriteLine(inputName + " is not ranked among the top 1000 boy names.");
            }
            if (GirlNames.ContainsKey(inputName))
            {
                Console.WriteLine(inputName + " is ranked " + GirlNames[inputName].Rank + " among girls with " + GirlNames[inputName].Count + " namings.");
            }
            else
            {
                Console.WriteLine(inputName + " is not ranked among the top 1000 girl names.");
            }
        }
    }

    class CountRank
    {
        public CountRank(int ct, int rk)
        {
            Count = ct;
            Rank = rk;
        }

        public int Count{get; set;}
        public int Rank {get; set;}
    }
}
