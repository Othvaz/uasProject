using System;

namespace InputLibrary
{
    public static class InputHandler
    {
        public static string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int GetInt(string prompt)
        {
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            return -1;
        }
    }
}
