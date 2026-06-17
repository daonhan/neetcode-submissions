public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var map = new Dictionary<int, int>();
		foreach (var n in nums)
			map[n] = map.GetValueOrDefault(n) + 1;

        //return map.OrderByDescending(m => m.Value).Take(k).Select(x => x.Key).ToArray();			

        List<int>[] freq = new List<int>[nums.Length + 1];

		foreach (var kvp in map)
		{
			if (freq[kvp.Value] == null) 
			{
				freq[kvp.Value] = new List<int>();
			}
			
			freq[kvp.Value].Add(kvp.Key);
		}

		var result = new int[k];
		int index =0;
		for (int i = freq.Length - 1; i >= 0 && index < k; i--)
			
			if(freq[i] != null)
			foreach (int n in freq[i]) 
			{
				result[index++] = n;
				if(index == k) return result;
			}
			
			
		return result;
		
    }
}
