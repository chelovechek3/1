namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        { //1
            {
                int[] nums = { 4, 5, 2, 10, 8 };
                int[] result = FindNextGreaterElements(nums);
                Console.WriteLine("Результат: ");
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            static int[] FindNextGreaterElements(int[] nums)
            {
                int n = nums.Length;
                int[] result = new int[n];
                Stack<int> stack = new Stack<int>();
                for (int i = n - 1; i >= 0; i--)
                {
                    while (stack.Count > 0 && stack.Peek() <= nums[i])
                    {
                        stack.Pop();
                    }
                    result[i] = stack.Count > 0 ? stack.Peek() : -1;
                    stack.Push(nums[i]);
                }
                return result;
            }
        }
    }
}
