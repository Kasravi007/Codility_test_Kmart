namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(FindLongestIncreasingSubsequence("6 1 5 9 2"));
        }

        public static string FindLongestIncreasingSubsequence(string inputString)
        {

            var stringArray = inputString.Split(' ');
            var integerArray = stringArray.Select(x => int.Parse(x)).ToArray();

            var longestSubsequence = new List<int>();
            var currentSubsequence = new List<int>();

            foreach (var num in integerArray)
            {
                if (currentSubsequence.Count == 0 || num > currentSubsequence[currentSubsequence.Count - 1])
                {
                    currentSubsequence.Add(num);
                }
                else
                {
                    if (currentSubsequence.Count > longestSubsequence.Count)
                    {
                        longestSubsequence = new List<int>(currentSubsequence);
                    }
                    currentSubsequence.Clear();
                    currentSubsequence.Add(num);
                }
            }

            var longestSubsequenceResult = currentSubsequence.Count > longestSubsequence.Count ? currentSubsequence : longestSubsequence;
            return string.Join(" ", longestSubsequenceResult);
        }
    }
}