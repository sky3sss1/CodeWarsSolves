namespace CodeWars;

class Kata
{
  public static int binaryArrayToNumber(int[] BinaryArray)
  {
    return Convert.ToInt32(string.Concat(BinaryArray), 2);
  }
  public static long QueueTime(int[] customers, int n)
  {
    var queues = new int[n];

    foreach (var time in customers)
    {
      var index = Array.IndexOf(queues, queues.Min());

      queues[index] += time;
    }
    
    return queues.Max();
  }
  public static string AlphabetPosition(string text)
  {
    List<string> alphabet = new List<string> {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s",
      "t", "u", "v", "w", "x", "y", "z"};

    var result = "";
    foreach (var letter in text)
    {
      if (alphabet.Contains(letter.ToString().ToLower()))
      {
        result += (alphabet.IndexOf(letter.ToString().ToLower()) + 1) + " ";
      }
    }
    return result.Trim();
  }
}