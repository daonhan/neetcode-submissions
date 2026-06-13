public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length) return false;
		var countS = new Dictionary<char,int>();
		var countT = new Dictionary<char, int>();
		for (var i = 0; i < s.Length; i++)
		{
			countS[s[i]] = countS.GetValueOrDefault(s[i]) + 1;
			countT[t[i]] = countT.GetValueOrDefault(t[i]) + 1;
		}
		return countS.Keys.All(k => countT.GetValueOrDefault(k) == countS[k]);

    }
}
