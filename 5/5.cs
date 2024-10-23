namespace _5
{
    internal class _5
    {
        static void Main(string[] args)
        {
            {
                List<int> numbers = new List<int> { 10, 12, 15, 18, 11 };
                Console.WriteLine("Исходный список: ");
                PrintList(numbers);
                ReverseList(numbers);
                Console.WriteLine("Реверсированный список: ");
                PrintList(numbers);
            }
            static void ReverseList(List<int> numbers)
            {
                int left = 0;
                int right = numbers.Count - 1;
                while (left < right)
                {
                    int temp = numbers[left];
                    numbers[left] = numbers[right];
                    numbers[right] = temp;
                    left++;
                    right--;
                }
            }
            static void PrintList(List<int> numbers)
            {
                foreach (var number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
