public class Solution {
    public bool hasDuplicate(int[] nums) {
        System.Collections.Hashtable hashDuplcates = new System.Collections.Hashtable();
		for (var i = 0; i < nums.Length; i++)
		{
			var keyValue = nums[i];
			if (hashDuplcates.ContainsKey(keyValue)) return true;
			hashDuplcates[keyValue] = true;
		}
		
		return false;
    }
}