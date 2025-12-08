namespace Tools
{
    public class Utils
    {
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Determines if a number is even.
        ///</summary> 
        /// <param name="num">The number to evaluate</param>
        /// <returns><c>True</c> if <paramref name="num"/> is even; otherwise, <c>false</c></returns>
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        /// <summary>
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The higher value between <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        /// <summary>
        /// Reverses the given text
        /// </summary>
        /// <param name="text">The text to reverse. Can be <c>null</c></param>
        /// <returns>A new string with the characters reversed or <c>null</c> if the <paramref name="text"/> is <c>null</c> .</returns>
        public static string Reverse(string text)
        {
            if (text == null)
            {
                return null;
            }

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Determines whether a grade is valid (between 0 and 10).
        /// </summary>
        /// <param name="grade">The grade to validate.</param>
        /// <returns><c>true</c> if <paramref name="grade"/> is between 0 and 10 (inclusive), otherwise <c>false</c>. </returns>
        public static bool IsValidGrade(int grade)
        {
            return grade >= 0 && grade <= 10;
        }

        /// <summary>
        /// Counts the number of vowels in a given text.
        /// </summary>
        /// <param name="text">The text to analyze. Can be empty.</param>
        /// <returns>The number of vowels found in <paramref name="text"/>.</returns>
        public static int CountVowels(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            string vowels = "aeiouAEIOU";
            int count = 0;

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

