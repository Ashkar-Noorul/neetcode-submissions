public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         Dictionary<int, int> dict = new Dictionary<int, int>();

 for(int i=0;i<nums.Length;i++)
 {
     var pair = target - nums[i];
     if(dict.ContainsKey(pair))
     
         return [dict[pair], i];

     else
     {
         dict.Add(nums[i], i);
     }

 }

 return [0, 0];
    }
}
