using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPolygons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");
          
            Regex coor = new Regex(@"((?<Coord> \d{6,}.\d+ \d+.\d+,)+ \d+.\d+ \d+.\d+)");

            Regex sample = new Regex(@"(\d+.\d+ \d+.\d+)");
           
            MatchCollection coorMatch = coor.Matches(string.Join("",input));
            List<string> coordinatesList = new List<string>();
            int counter = 0;

            StringBuilder str = new StringBuilder();

            foreach (Match match in coorMatch)
            {
                string fileName = "polygon"+counter.ToString()+".txt";
                List<string> singleCoord = new List<string>(); 
                
                MatchCollection sampleCollection = sample.Matches(match.Value);
                foreach (Match sampleMatch in sampleCollection)
                {
                    singleCoord.Add(sampleMatch.ToString());
                }
                File.AppendAllLines(fileName, singleCoord);
                counter++;

            }
        }
    }
}
