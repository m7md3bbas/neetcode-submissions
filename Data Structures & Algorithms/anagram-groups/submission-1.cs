public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<string>> tabulka = new Dictionary<string, List<string>>();
        foreach (string slovo in strs)
        {
            char[] slovoarray = slovo.ToCharArray();
            Array.Sort(slovoarray);
            string klic = new string(slovoarray);
            if (!tabulka.ContainsKey(klic))
            {
                tabulka[klic] = new List<string>();
            }
            tabulka[klic].Add(slovo);
        }
        return new List<List<string>>(tabulka.Values);
    }
}
