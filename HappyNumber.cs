﻿public class Solution
{
    public bool IsHappy(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += (n % 10) * (n % 10);
            n /= 10;
        }
        if (sum == 1) return true;
        if (sum == 4) return false;
        return IsHappy(sum);
    }
}