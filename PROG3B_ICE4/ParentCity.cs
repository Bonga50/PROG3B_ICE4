using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3B_ICE4
{
    public class ParentCity
    {
        public static void Main(string[] args)
        {
            Dictionary<string,int> map = new Dictionary<string,int>();
            map.Add("South Africa", -1);
            map.Add("Gauteng", 0);
            map.Add("Pretoria", 1);
            map.Add("Cape Town", 0);
            map.Add("Johannnesburg",1);
            map.Add("Sandton", 4);
            map.Add("Morningside",5);
            map.Add("Bronkhorstspruit",2);
            Console.WriteLine("Enter a location");
            string location = Console.ReadLine();
            printParent(map,location);

            Console.ReadLine();

        }

        public static void printParent(Dictionary<string, int> map, string arg) { 
            bool isLastParent=false;
            int parent = map.FirstOrDefault(x => x.Key==arg).Value;
            while (!isLastParent)
            {
                Console.WriteLine(map.ElementAt(parent));
                parent = map.ElementAt(parent).Value;
                if (parent==-1) { isLastParent = true; break; }
            }
        }
    }
}
