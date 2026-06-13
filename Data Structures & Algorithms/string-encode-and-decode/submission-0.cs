public class Solution {

    public string Encode(IList<string> strs) {
        return string.Join("", strs.Select(s => $"{s.Length}#{s}"));
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
		int i = 0;
		while (i < s.Length)
		{
			int j = s.IndexOf('#', i);
			int len = int.Parse(s.Substring(i, j - i));
			result.Add(s.Substring(j + 1, len));
			i = j + 1 + len;
		}
		return result;
   }
}
