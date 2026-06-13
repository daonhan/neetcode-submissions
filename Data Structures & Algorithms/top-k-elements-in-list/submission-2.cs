public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var map = new Dictionary<int, int>();
		foreach (var n in nums)
			map[n] = map.GetValueOrDefault(n) + 1;
		
        // return map.OrderByDescending(m => m.Value).Take(k).Select(x => x.Key).ToArray();
			
		var pq = new PriorityQueue<int, int>();
		foreach (var item in map)
		{
			pq.Enqueue(item.Key, item.Value);
			if (pq.Count > k) 
			{
				pq.Dequeue();			
			}
		}
		var results = new int[k];
		for (int i = 0; i < k; i++)
		{
			results[i] = pq.Dequeue();
		}
		return results;
    }
}
