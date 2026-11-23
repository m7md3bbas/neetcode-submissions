class Solution {
    public void rotate(int[] nums, int k) {
     int n = nums.length;
        k= k % n;
        //reverse all arr
        reverse(nums,0,n-1);
        //reverse first part
        reverse(nums,0,k-1);
        //reverse the rest
        reverse(nums,k,n-1);
    }
    private void reverse(int [] nums , int start , int end)
    {
      while(start<end)
      {
        int temp = nums[start];
        nums[start]=nums[end];
        nums[end]=temp;
        start++;
        end--;
      }
    }       
    
}