using System;

/*returns change using fewest nz denomination coins*/
public class Coin
{
    public static Dictionary<int, int> Change(int cents)      
    {
        int[] coins = new int[] { 200, 100, 50, 20, 10 };

        int roundedCents = Convert.ToInt32(Math.Round(cents / 10.0) * 10);      //rounds to nearest ten cents

        Dictionary<int, int> change = new Dictionary<int, int>();

        while (roundedCents > 0)
        {
            int k = 0;
            foreach (int coin in coins)
            {
                if (coin <= roundedCents)
                {
                    k = coin;
                    break;
                }
            }

            roundedCents -= k;

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