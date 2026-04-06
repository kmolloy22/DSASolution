namespace BestTimeToBuySellStock_Example;

public class BuySellStock
{
    // Brute Force
    // Try every buy day with every later sell day
    // Time: O(n^2)  Space: O(1)
    // Simple, good for first-pass reasoning

    public static int MaxProfitBruteForce(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }

    // Optimized Approach
    // Track the minimum price seen so far and calculate potential profit at each step
    // Time: O(n)  Space: O(1)
    // More efficient, but requires careful reasoning about state
    public static int MaxProfitOptimized(int[] prices)
    {
        if (prices.Length < 2)
            return 0;

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            if(price < minPrice)
            {
                minPrice = price;
            }

            int profit = price - minPrice;
            if(profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }
}