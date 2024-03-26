namespace Calculator
{
    internal class Program
    {
        static double operation(int choice, double a, double b)
        {
            double result=0;
            switch (choice)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    result = a / b;
                    break;
                   
                        
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Would you like to:" + "\n" + " 1) Add" + "\n" + " 2) Subtract" + "\n" + " 3) Multiply" + "\n" + " 4) Divide");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result selected is: " + operation(choice, a, b));
        }
    }
}
 