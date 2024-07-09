namespace eph_task_21_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            var max = a > b ? a : b;
            max = max > c ? max : c;
            Console.WriteLine(max);
            var min = a < b ? a : b;
            min = min < c ? min : c;
            Console.WriteLine(min);
            bool one_exists = (a == 1 || b == 1 || c == 1) ? true : false;
            Console.WriteLine($"One of the numbers equals to one: {one_exists}");
            bool exactly_two_exists = (a == 2 && b == 2) || (b == 2 && c == 2) || (a == 2 && b == 2) ? true : false;
            Console.WriteLine($"Exactly two numbers equal to 2: {exactly_two_exists}");
            string possible_triange = (a + b > c && a + c > b && b + c > a) ? "y=1" : "y=0";
            Console.WriteLine($"Is it possible to make a triangle with those numbers on hte sides (y=1 - Yes , y=0 - No): {possible_triange}");
            int even_number = (a % 2 == 0 || b % 2 == 0 || c % 2 == 0) ? 1 : 2;
            Console.WriteLine($"At least one of the numbers is even(1 - True, 2 - False): {even_number}");
            bool arithmetic_sequence = b - a == c - b ? true : false;
            Console.WriteLine($"The sequence of these numbers is arithmetic: {arithmetic_sequence}");
            bool geometric_sequence = b / a == c / b ? true : false;
            Console.WriteLine($"The sequence of these numbers is geometric: {geometric_sequence}");;
            var middle_number = a + b + c - min - max;
            Console.Write(min + " " + middle_number + " " + max);
            Console.Write(max + " " + middle_number + " " + min);
        }
    }
}
