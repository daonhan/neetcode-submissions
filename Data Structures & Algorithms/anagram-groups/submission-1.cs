public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new System.Collections.Generic.Dictionary<string, List<string>>();
		foreach (var s in strs)
		{
			var key = GetKey(s);// new string(s.OrderBy(c => c).ToArray());
			if (!map.ContainsKey(key)) map[key] = new System.Collections.Generic.List<string>();
			map[key].Add(s);
		}
		return map.Values.ToList();
    }
    public string GetKey(string s)
    {
        int[] counts = new int[26];
        foreach(char ch in s)
        {
            counts[ch - 'a']++;
        }
        return string.Join(',',counts);
    }
}
