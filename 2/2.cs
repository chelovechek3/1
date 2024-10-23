namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 5, 6 };
                int uniqueCount = CountUniqueElements(numbers);
                Console.WriteLine($"Количество уникальных элементов: {uniqueCount}");
            }
            static int CountUniqueElements(List<int> numbers)
            {
                numbers.Sort();
                if (numbers.Count == 0)
                    return 0;
                int uniqueCount = 1;
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers[i - 1])
                    {
                        uniqueCount++;
                    }
                }
                return uniqueCount;
            }
        }
    }
}
