public class Solution {
    public bool IsPalindrome(int x) {
        string newX = x.ToString();
        //121
        for(int i = 0 ; i<newX.Length; i++)
        {    
            if(newX[i] != newX[newX.Length-1-i])
            {
                return false;
            }
        }

        return true;
    }
}