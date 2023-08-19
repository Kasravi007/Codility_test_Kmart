namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var number in FindLongestIncreasingSubsequence("6 1 5 9 2"))
            {
                Console.Write(number + " ");
            }
            
        }

        public static List<int> FindLongestIncreasingSubsequence(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return new List<int>();
            }

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

            return currentSubsequence.Count > longestSubsequence.Count ? currentSubsequence : longestSubsequence;
        }
    }
}