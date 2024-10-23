namespace _4
{
    internal class _4
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите строку: ");
                string input = Console.ReadLine();
                bool isBalanced = IsBalanced(input);
                Console.WriteLine($"Строка сбалансирована: {isBalanced}");
            }
            static bool IsBalanced(string s)
            {
                Stack<char> stack = new Stack<char>();
                foreach (char c in s)
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')' || c == '}' || c == ']')
                    {
                        if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c))
                        {
                            return false;
                        }
                    }
                }
                return stack.Count == 0;
            }
            static bool IsMatchingPair(char opening, char closing)
            {
                return (opening == '(' && closing == ')') ||
                       (opening == '{' && closing == '}') ||
                       (opening == '[' && closing == ']');
            }
        }
    }
}