namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FizzBuzz(100, new Dictionary<int, string>()
            {
                { 2, "Fizz"},
                { 3, "Buzz"},
                { 5, "Zap" }
            });
        }

        /// <summary>
        /// Outputs a string if a number is dividable without remainder inside numpaírs
        /// </summary>
        /// <param name="maxnum"></param>
        /// <param name="NumOutputPairs"></param>
        static void FizzBuzz(int maxnum, Dictionary<int, string> NumOutputPairs)
        {
            for (int i = 1; i <= maxnum; i++)
            {
                string outputstr = "";
                foreach (KeyValuePair<int, string> pair in NumOutputPairs)
                {
                    if (i % pair.Key == 0)
                    {
                        outputstr += pair.Value;
                    }
                }
                Console.WriteLine(outputstr.Length > 0 ? (outputstr + " " + i) : i);
            }
        }
    }
}