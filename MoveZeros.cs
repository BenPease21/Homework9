public class Solution
{
    public void MoveZeroes(int[] nums)
    {
     int a = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[a] = nums[i];
                a++;
            }
        }

        for (int i = a; i < nums.Length; i++)
        {
            nums[i] = 0;
        }

    }
}