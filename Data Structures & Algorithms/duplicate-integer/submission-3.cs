public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0)
        {
            return false;
        }
        var map = new Dictionary<int,int>();
        map[0]=nums[0];
        for(int i =1;i < nums.Length ;i++)
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