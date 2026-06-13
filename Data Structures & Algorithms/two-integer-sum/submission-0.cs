public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var map = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			var complement = target - nums[i];
			if (map.ContainsKey(complement))
				return new int[] { map[complement], i };
			map[nums[i]] = i;
		}
		return Array.Empty<int>();
    }
}
