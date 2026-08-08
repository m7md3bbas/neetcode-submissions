public class Solution {
    public bool hasDuplicate(int[] nums) {
        var map = new Dictionary<int,int>();
        for(int i =0 ;i < nums.Length ;i++)
        {
            if(map.ContainsValue(nums[i]))
            {
                return true;
            }else
            {
                map[i] = nums[i];
            }

        }
        return false;
    }
}