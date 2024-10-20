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
}