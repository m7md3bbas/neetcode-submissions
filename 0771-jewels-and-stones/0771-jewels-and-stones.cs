public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count =0;
        HashSet<char> set = new (jewels);
        foreach(var i in stones)
        {
            if(set.Contains(i))
            {
                count++;
            }
        }
    return count;
    }
}