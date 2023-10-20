namespace Instructions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number=");
            string numberAsString = Console.ReadLine();
            int number = int.Parse(numberAsString);

            for (int i = 1; i <= number; i++)
            {
                /* 1
                bool isOdd = i % 2 == 0;
                if (isOdd)
                {
                    Console.WriteLine(i);
                }
                */

                bool isEven = i % 2 == 1;
                if (isEven)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

        }

        public static bool EvaluateCondition(bool condition, string message)
        {
            Console.WriteLine(message);
            return condition;
        }

        public static void SamplesWithIf()
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
        }

        public static void SamplesWitSwitch()
        {
            Console.WriteLine("Meniu:");
            Console.WriteLine("1) File");
            Console.WriteLine("2) Edit");
            Console.WriteLine("3) View");
            Console.Write("Your option is:");
            string option = Console.ReadLine();

            int optionNumber;
            if (int.TryParse(option, out optionNumber))
            {
                switch (optionNumber)
                {
                    case 1:
                        {
                            int var = 1;
                            Console.WriteLine("You have selected File menu.");
                            Console.WriteLine("Available sub-options are:");
                            Console.WriteLine("1) New");
                            Console.WriteLine("2) Open");
                        }
                        break;

                    case 2:
                        {
                            int var = 1;
                            Console.WriteLine("You have selected Edit menu.");
                            Console.WriteLine("Available sub-options are:");
                            Console.WriteLine("1) Copy");
                            Console.WriteLine("2) Paste");
                        }
                        break;

                    case 3:
                        Console.WriteLine("You have selected View menu.");
                        Console.WriteLine("Available sub-options are:");
                        Console.WriteLine("1) Open");
                        Console.WriteLine("2) Open With");
                        break;

                    default:
                        Console.WriteLine("You selected an invalid menu option.");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Please enter a valid numeric option.");
            }
        }
    }
}