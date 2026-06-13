public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefexMap = new int[nums.Length];
		prefexMap[0] = 1;
		prefexMap[1] = nums[0];
		for (var i = 2; i < nums.Length; i++) 
		{
			prefexMap[i] = prefexMap[i-1] * nums[i-1];
		}
		var suffixMap = new int[nums.Length];
		suffixMap[nums.Length -1] = 1;
		suffixMap[nums.Length -2] = nums[nums.Length -1];	
		for (int i = nums.Length -3; i>= 0 ; i--)
		{
			suffixMap[i] = suffixMap[i+1] * nums[i+1];
		}
		var res = new int[nums.Length];
		for (int i = 0; i < nums.Length; i++)
		{
			res[i]=prefexMap[i]*suffixMap[i];
		}
		return res;
    }
}
