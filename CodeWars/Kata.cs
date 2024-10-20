namespace CodeWars;

class Kata
{
  public static int binaryArrayToNumber(int[] BinaryArray)
  {
    return Convert.ToInt32(string.Concat(BinaryArray), 2);
  }
}