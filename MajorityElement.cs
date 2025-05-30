﻿public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int i = 0;
        int a = 0;

        foreach (int num in nums)
        {
            if (i == 0)
            {
                a = num;
            }

            i += (num == a) ? 1 : -1;
        }

        return a;
    }
}
