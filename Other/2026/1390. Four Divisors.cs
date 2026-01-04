public class Solution {
    public int SumFourDivisors(int[] nums)
    {
        int totalSum = 0;
        foreach (int num in nums)
        {
            int count = 0, sum = 0;
            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    int j = num / i;
                    count++;
                    sum += i;
                    if (i != j)
                    {
                        count++;
                        sum += j;
                    }
                    if (count > 4) break;
                }
            }
            if (count == 4) totalSum += sum;
        }
        return totalSum;
    }
}
