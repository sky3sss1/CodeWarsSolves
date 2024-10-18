namespace CodeWars.SevenQ;

public class GetMiddle1
{
    public static string GetMiddle(string s)
    {
        return s.Length > 1 ? s.Length % 2 == 0 ? s.Substring(s.Length / 2-1, 2) : s[s.Length / 2].ToString() : s;
    }
}