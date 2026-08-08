public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;
        var map = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (map.ContainsKey(s[i]))
                map[s[i]]++;
            else
                map[s[i]] = 1;
        }

        for (int j = 0; j < t.Length; j++) {
           if(!map.ContainsKey(t[j]))
          { 
            return false;
          }else
          {
            map[t[j]]--;
            
            if(map[t[j]]== 0)
            {
                map.Remove(t[j]);
            }
          }


        }

        return map.Count == 0;
    }
}
