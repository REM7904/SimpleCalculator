namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUTS
            double firstNum = 0, secondNum = 0, sum;

            Console.WriteLine("Enter a the first whole numer:");
            firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a the second whole numer:");
            secondNum = double.Parse(Console.ReadLine());

            //Process
            sum = firstNum + secondNum;

            //OUTPUTS
            //String concatination
            //Console.WriteLine($"The total sum of" + firstNum + "and" + secondNum ":" + sum");
            //String interpolation: $ indicates that you'll use interpolation
            Console.WriteLine($"The total sum of {firstNum} and {secondNum}: {sum}");
            Console.ReadKey();
        }
    }
}
