namespace CodeWars.SixQ;

public class TwoSum11
{   
    public static int[] TwoSum(int[] numbers, int target)
    {
        var result = new int[2];
        var firstIndex = 0;
        foreach (var number in numbers)
        {
            var secondIndex = 0;
            foreach (var num in numbers)
            {
                if (number + num == target && firstIndex != secondIndex)
                {
                    result[0] = firstIndex; 
                    result[1] = secondIndex;
                    break;
                }
                secondIndex++;
            }
            firstIndex++;
        }
        
        return result;
    }
}