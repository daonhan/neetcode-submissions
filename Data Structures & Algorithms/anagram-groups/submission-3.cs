public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new System.Collections.Generic.Dictionary<string, List<string>>();
		foreach (var s in strs)
		{
			//var key = new string(s.OrderBy(c => c).ToArray());
            int[] count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
			if (!map.ContainsKey(key)) map[key] = new System.Collections.Generic.List<string>();
			map[key].Add(s);
		}
		return map.Values.ToList();
    }    
}
