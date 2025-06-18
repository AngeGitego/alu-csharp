namespace System

{
    public class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0)
            {
                // If length is 0 or less, just print a new line
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < length; i++)
            {
                // Print spaces equal to the current line number
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                // Print the backslash character
                Console.WriteLine("\\");
            }
        }
    }
}
