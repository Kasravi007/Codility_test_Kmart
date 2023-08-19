namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(FindLongestIncreasingSubsequence("6 1 5 9 2"));
        }

        public static string FindLongestIncreasingSubsequence(string inputString)
        {

            var stringArray = inputString.Split(' ');
            var integerArray = stringArray.Select(x => int.Parse(x)).ToArray();

            var longestSubsequence = new List<int> { integerArray[0] };
            var currentSubsequence = new List<int> { integerArray[0] };

            for (var i = 1; i < integerArray.Length; i++)
            {
                if (integerArray[i] > integerArray[i - 1])
                {
                    currentSubsequence.Add(integerArray[i]);
                }
                else
                {
                    if (currentSubsequence.Count > longestSubsequence.Count)
                    {
                        longestSubsequence = new List<int>(currentSubsequence);
                    }

                    currentSubsequence.Clear();
                    currentSubsequence.Add(integerArray[i]);
                }
            }

            var longestSubsequenceResult = currentSubsequence.Count > longestSubsequence.Count ? currentSubsequence : longestSubsequence;
            return string.Join(" ", longestSubsequenceResult);
        }
    }
}