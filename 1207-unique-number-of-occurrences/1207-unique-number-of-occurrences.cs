public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < arr.Length; i++)
        {
            if (dict.ContainsKey(arr[i]))
            {
                dict[arr[i]]++;
            }
            else
            {
                dict[arr[i]] = 1;
            }
        }

        HashSet<int> set = new();

        foreach (var count in dict.Values)
        {
            if (!set.Add(count))
            {
                return false;
            }
        }

        return true;
    }
}