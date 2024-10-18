namespace CodeWars.SevenQ;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> result = new();

        foreach (var item in listOfItems)
            if (item is int)
                result.Add(Convert.ToInt32(item));

        return result;
    }

    //best
    //public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    //{
    //    return listOfItems.OfType<int>();
    //}
}
