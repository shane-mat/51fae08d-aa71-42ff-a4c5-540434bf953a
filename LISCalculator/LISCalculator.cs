namespace LISCalculator
{
    public class LongestIncreasingSubsequence
    {
        public string FindLongestIncreasingSubsequence(string nums)
        {
            if (string.IsNullOrWhiteSpace(nums) || nums.Any(x => x != ' ' && !char.IsDigit(x)))
            {
                return "Invalid input!";
            }

            var arr = nums.Trim().Split(' ').Select(int.Parse).ToArray();

            int currentSSLength = 1;
            int longestSSLength = 1;
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    currentSSLength++;
                    if (currentSSLength > longestSSLength)
                    {
                        longestSSLength = currentSSLength;
                        startIndex = i + 2 - currentSSLength;
                        endIndex = i + 2;
                    }
                }
                else
                {
                    currentSSLength = 1;
                }
            }

            return string.Join(" ", arr[startIndex..endIndex]);
        }
    }
}