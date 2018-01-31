using System;
public class CamelCaseBreaker
{
    public static string BreakCamelCase(string str)
    {
        for (var i = 1; i < str.Length; i++)
        {
            // If the first character is lowercase OR uppercase, AND the second char is uppercase...
            if ((Char.IsLower(str[i - 1]) || Char.IsUpper(str[i - 1])) && Char.IsUpper(str[i]))
            {
                // Insert a space before the uppercase character.
                str = str.Insert(i, " ");
            }
        }
        return str;
    }
}