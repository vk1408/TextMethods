using System;

class UsefulTextUtils
{
    public static string PascalCase(string input)
    {
        //    Gets sentence as an input and returns a pascal case string.
        //    For example: 
        //    "number of students"-->"NumberOfStudents".
        //    For "NUMBER OF STUDENTS"-->"NumberOfStudents".
        //    Null of whitespace will return an empty string

        if (String.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        var pascalCase = "";
        var words = input.Split(' ');

        foreach (var word in words)
        {
            var caseword = Char.ToUpper(word[0]) + word.Substring(1).ToLower();
            pascalCase += caseword;
        }
        return pascalCase;

    }
    public static Boolean CheckTimeFormat(string input)
    {
        //    A valid input should be between 00:00 and 23:59.
        //    If the input is valid, returns true, otherwise, 
        //    returns false. If the input is empty, returns false.

        if (String.IsNullOrEmpty(input))
        {
            return false;
        }

        var input_spl = input.Split(':');

        var hour = Convert.ToInt32(input_spl[0]);
        var minute = Convert.ToInt32(input_spl[1]);

        if ((hour >= 0) && (hour <= 23) && (minute >= 0) && (minute <= 59))
            return true;
        else
            return false;
    }
}

