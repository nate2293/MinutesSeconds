namespace MinutesSeconds
{
    internal class Conversion
    {
        public static int Convert(int minutes)      // Expects an int and outputs an int.
        {
            return minutes * 60;        
        }

        public static void Main()
        {
            int resultOne = Convert(6);
            Console.WriteLine(resultOne);
            Console.WriteLine();

            int resultTwo = Convert(15);
            Console.WriteLine(resultTwo);
            Console.WriteLine();

            int resultThree = Convert(5);
            Console.WriteLine(resultThree);
            Console.WriteLine();

        }
    }
}

// Create a method that converts minutes into seconds and display output.