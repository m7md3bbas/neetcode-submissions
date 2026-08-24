public class Solution {
    public int MaximizeExpressionOfThree(int[] nums) {
  // the experssion value should be a + b - c

    nums.Sort();

    int a = nums[nums.Length-1]; 
    int b = nums[nums.Length-2]; 
    int c = nums[0];


    return a+b-c;
    }
}