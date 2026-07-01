public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
	{
		var map = new Dictionary<int, int>();
		foreach (var num in nums)
		{
			map[num] = map.GetValueOrDefault(num) + 1;
		}
		
		List<int>[] freq = new List<int>[nums.Length +1];
		
		foreach (var kpv in map)
		{
			if (freq[kpv.Value] == null) 
			{
				freq[kpv.Value] = new List<int>();
			}
			freq[kpv.Value].Add(kpv.Key);
		}
		
		int index =0;
		int[] result = new int[k];
		for (int i = freq.Length -1; i >0 && index < k ; i--)
		{
			if(freq[i] == null) continue;
			foreach (var num in freq[i])
			{
				result[index++] = num;
				if(index == k)
					return result;
			}
		}
		
		return result;        
    }
}
