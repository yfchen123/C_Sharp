using System.Text.RegularExpressions;

namespace Chapter8
{
    public class Ch08Ex02RegularExpressions
    {
        public void RegularExpressions()
        {
            Console.WriteLine("The default regular expression checks for at least one digit.");
            while (true)
            {
                Console.WriteLine("Enter a regular expression (or press ENTER to use the default): ");
                string? regular_expression = Console.ReadLine();
                Console.WriteLine("Enter some input: ");
                string? user_input = Console.ReadLine();
                
                if (string.IsNullOrEmpty(regular_expression))
                {
                    Regex my_re = new(@"\d");
                    Console.WriteLine($"{user_input} matches {my_re}?");
                    if (string.IsNullOrEmpty(user_input))
                    {
                        Console.WriteLine("False");
                    }
                    else if (my_re.IsMatch(user_input))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Regex my_re = new(regular_expression);
                    Console.WriteLine($"{user_input} matches {regular_expression}?");
                    if (user_input == null)
                    {
                        Console.WriteLine("False");
                    }
                    else if (my_re.IsMatch(user_input))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                Console.WriteLine("Press ESC to end or any key to try again.");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if(info.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            

        }
    }
}
