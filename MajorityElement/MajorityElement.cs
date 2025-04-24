public class Solution
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

            if (num == a) { i++; }
            else { i--; }
        
        }

        return a;
    }
}