using System.Globalization;

namespace CodeWars.SevenQ;

public class ValidatePin11
{
    public static bool ValidatePin(string pin)
    {
        return (pin.Length == 4 || pin.Length == 6) && !pin.Contains('-') && !pin.Contains('+') && !pin.Contains("\n") && Int32.TryParse(pin, out int res);
    }
}
//       return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);