public class Solution {

    public int[] TwoSum(int[] nums, int target) {

        var HashMap = new Dictionary<int,int>();
        HashMap.TryAdd(nums[0],0);

        for(int i =1 ; i<nums.Length;i++)
        {
            if(HashMap.TryGetValue(target-nums[i],out int index)){

                return new[]{i,index};
            }
            HashMap.TryAdd(nums[i],i);
        }
        return null;
    }

}