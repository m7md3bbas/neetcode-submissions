public class Solution {
    public bool IsValid(string s)
   {
    
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char>
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };

            for (int i = 0 ; i< s.Length ; i++ )
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else if (pairs.ContainsKey(s[i]))
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[s[i]])
                        return false;
                }
            }

            return stack.Count == 0;

   }
}