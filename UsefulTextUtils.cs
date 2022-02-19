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
}

