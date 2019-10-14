using System;
using System.Collections.Generic;

public class Coin
{
    public static Dictionary<int, int> Change(int value)       //value in cents
    {
        int[] coins = new int[] { 200, 100, 50, 20, 10 };

        int roundedValue = Convert.ToInt32(Math.Round((value) / 10.0, MidpointRounding.AwayFromZero) * 10);      //rounds to nearest ten cents

        Dictionary<int, int> change = new Dictionary<int, int>();

        while (roundedValue > 0)
        {
            int k = 0;
            foreach (int coin in coins)
            {
                if (coin <= roundedValue)
                {
                    k = coin;
                    break;
                }
            }

            roundedValue -= k;

            if (!change.ContainsKey(k))
            {
                change.Add(k, 1);
            }
            else
            {
                change[k] += 1;
            }

        }

        return change;
    }

}