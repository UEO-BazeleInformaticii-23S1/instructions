namespace Instructions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (EvaluateCondition(false, "Eval condition1"))
            {
                Console.WriteLine("Condition1 is true");
            }
            else if (EvaluateCondition(false, "Eval condition2"))
            {
                Console.WriteLine("Condition2 is true");
            }
            else if (EvaluateCondition(true, "Eval condition3"))
            {
                Console.WriteLine("Condition3 is true");
            }
            else
            {
                Console.WriteLine("None of Condition1, Condition2, Condition3 are true");
            }

            Console.WriteLine("Hello, World!");
        }

        public static bool EvaluateCondition(bool condition, string message)
        {
            Console.WriteLine(message);
            return condition;
        }
    }
}