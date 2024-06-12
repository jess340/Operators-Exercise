namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("Please write the radius of the circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {

            var area = Math.PI * Math.Pow(radius, 2);
            return area; 
        }
        
    }
}
