namespace SOLID_PRINCIPLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***Liskov Substitution Principle
            //Below are the regular form of declarations.

            //var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            //SumCalculator sum = new SumCalculator(numbers);
            //Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
            //Console.WriteLine();
            //EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            //Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");


            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
            Console.WriteLine();
            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");


            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            Console.ReadKey();


            //***
        }
    }
}