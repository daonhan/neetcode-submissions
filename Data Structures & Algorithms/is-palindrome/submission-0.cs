public class Solution {
    public bool IsPalindrome(string s) 
    {
        string str = Regex.Replace(s,"[^A-Za-z0-9]","");
		int left =0;
		int right = str.Length - 1;
		while (left <= right)
		{
			if(char.ToLowerInvariant(str[left]) != char.ToLowerInvariant(str[right])) return false;
			left++;
			right--;
		}
		return true;
    }
}
