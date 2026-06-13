public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var map = new Dictionary<int, int>();
		foreach (var n in nums)
			map[n] = map.GetValueOrDefault(n) + 1;
		return map.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}
