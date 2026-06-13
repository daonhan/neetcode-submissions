public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        var hs = new HashSet<int>(nums);
		int counter = 0;
		foreach (var num in hs)
		{
			var isBegOfSeq  = !hs.Contains(num - 1);
			if (isBegOfSeq ) 
			{
				int curNum = num;
				int seqCounter = 1;
				while (hs.Contains(curNum + 1))
				{
					seqCounter++;
					curNum+=1;
				}
				
				counter = Math.Max(counter, seqCounter);
			}
		}
		
		return counter;        
    }
}
