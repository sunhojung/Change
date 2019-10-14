using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("this program returns the minimum number of coins for the amount of change required");
        Console.WriteLine("Please input change to be returned:");
        int change = Convert.ToInt32(Console.ReadLine());
        var dict1 = Coin.Change(change);
        foreach (KeyValuePair<int, int> kvp in dict1)
        {
            if(kvp.Key == 100)
            {
                Console.WriteLine("1 dollar coin x {0}", kvp.Value);
            }
            else if (kvp.Key == 200)
            {
                Console.WriteLine("2 dollar coin x {0}", kvp.Value);
            }
            else
            {
                Console.WriteLine("{0} cent coin x {1}", kvp.Key, kvp.Value);
            }
        }
        
        Console.ReadLine();
    }
}


