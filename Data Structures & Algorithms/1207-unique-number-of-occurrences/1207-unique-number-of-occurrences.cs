public class Solution {
    public bool UniqueOccurrences(int[] arr) {
      
           Dictionary<int , int> n = new Dictionary<int , int>();
           HashSet<int> hash = new HashSet<int>();
           for(int i = 0 ;i < arr.Length; i++)
           {
            if(!n.ContainsKey(arr[i]) )
            {
                n[arr[i]] =1;
            }else{
                n[arr[i]]++;
            }
           }
            foreach (int value in n.Values)
        {
            hash.Add(value);
        }

          
          return hash.Count == n.Count;
      }
}