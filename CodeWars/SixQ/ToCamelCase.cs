namespace CodeWars.SixQ;

public class ToCamelCase11
{
    public static string ToCamelCase(string str)
    {
        var words = str.Split(new char[]{'-', '_'});
        string result = "";
        foreach (var word in words)
        {
            result += result == "" ? word : word.Substring(0, 1).ToUpper() + word.Substring(1);
        }
        return result;
    }
}