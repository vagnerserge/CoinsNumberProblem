namespace CoinsNumberSolution
{
    public class CoinsNumber
    {
        // используется алгоритм динамического программирования
        public static int GetMinCoins(int amount, int[] coins)
        {
            if (amount < 0) return -99;

            var CoinsNumber = new int[amount + 1];
            Array.Fill(CoinsNumber, amount + 1);
            CoinsNumber[0] = 0;

            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    CoinsNumber[i] = Math.Min(CoinsNumber[i], CoinsNumber[i - coin] + 1);
                }
            }
            return CoinsNumber[amount] > amount ? -99 : CoinsNumber[amount];
        }
    }
}