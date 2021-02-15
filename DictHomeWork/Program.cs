using System;
using System.Collections.Generic;

namespace DictHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> InfoDict = new Dictionary<int, string>();

            InfoDict.Add(1, "Aybuke Fırat");
            InfoDict.Add(2, "Cansu Tutar");
            InfoDict.Add(3, "Doğa Keskin");

            foreach(var infodict in InfoDict)
            {
                Console.WriteLine(InfoDict);
            }
            
        }   
    }
}
