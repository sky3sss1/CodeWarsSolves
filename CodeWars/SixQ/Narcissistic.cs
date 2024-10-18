using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace CodeWars.SixQ;

public class Narcissistic11
{
    public static bool Narcissistic(int value)
    {
        var numbers = value.ToString().ToArray();
        double sum = 0;
        foreach (var number in numbers)
        {
            sum += Math.Pow(Int32.Parse(number.ToString()), numbers.Length);
        }

        return sum == value;
    }
}