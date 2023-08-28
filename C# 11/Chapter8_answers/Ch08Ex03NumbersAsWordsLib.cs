using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    public static class Ch08Ex03NumbersAsWordsLib
    {
        public static string ToWords(this int number)
        {
            string prefix = string.Empty;
            if (number < 0)
            {
                prefix = "Negative ";
            }
            prefix += millionth_place(number);
            return prefix;
        }

        private static string millionth_place(int number)
        {
            int place = number / 1_000_000;
            string end = thousandth_place(number % 1_000_000);
            if (number < 1_000_000)
            {
                return thousandth_place(number);
            }
            else if (number < 10_000_000)
            {
                return $"{single_digit(place)} million, {end}";
            }
            else if (number < 100_000_000)
            {
                return $"{double_digit(place)} million, {end}";
            }
            return $"{hundredth_place(place)} million, {end}";
        }
        private static string thousandth_place(int number)
        {
            int place = number / 1000;
            string end = hundredth_place(number % 1000);
            if (number < 1000)
            {
                return hundredth_place(number);
            }
            else if (number < 10000)
            {
                return $"{single_digit(place)} thousand, {end}";
            }
            else if (number < 100000)
            {
                return $"{double_digit(place)} thousand, {end}";
            }
            return $"{hundredth_place(place)} thousand, {end}";
        }
        private static string hundredth_place(int number)
        {
            if (number < 100) { 
                return double_digit(number);
            }
            int last_digit = number / 100;
            return $"{single_digit(last_digit)} hundred and {double_digit(number % 100)}" ;
        }
        private static string double_digit(int number)
        {
            string last_digit = single_digit(number % 10);
            if (number < 10)
            {
                return single_digit(number);
            }
            else if (number < 19)
            {
                return less_than_twenty(number);
            }
            else if (number < 29)
            {
                return $"twenty-{last_digit}";
            }
            else if (number < 39)
            {
                return $"thirty-{last_digit}";
            }
            else if (number > 49 && number < 60)
            {
                return $"fifty-{last_digit}";
            }
            else if (number > 79 && number < 90)
            {
                return $"eighty-{last_digit}";
            }
            string second_digit = single_digit(number / 10) + "ty";
            return $"{second_digit}-{last_digit}";
        }
        private static string less_than_twenty(int number)
        {
            return number switch
            {
                10 => "ten",
                11 => "eleven",
                12 => "twelve",
                13 => "thirteen",
                14 => "fourteen",
                15 => "fifteen",
                _ => single_digit(number % 10) + "teen"
            };
        }
        private static string single_digit(int number)
        {
            return number switch {
                0 => "",
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                _ => "nine"
            };
        }
    }
}
