namespace CodeWars.SevenQ;

public static class DescendingOrder11
{
    public static int DescendingOrder(int num)
    {
        var result = num.ToString().ToCharArray();
        Array.Sort(result);
        var finalResult = new String(result.Reverse().ToArray());
        return Convert.ToInt32(finalResult);
    }
}