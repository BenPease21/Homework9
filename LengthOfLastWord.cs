public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();

        int a = s.LastIndexOf(' ');

        return s.Length - a - 1;
    }
}
