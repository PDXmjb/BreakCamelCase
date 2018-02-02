using System;
public class CamelCaseBreaker
{
    public static string BreakCamelCase(string str)
    {
        for (var i = 1; i < str.Length; i++)
        {
            // IF the character is uppercase and we don't have a space before it,
            if (Char.IsUpper(str[i]) && str[i - 1] != ' ')
            {
                // Insert a space before the uppercase character.
                str = str.Insert(i, " ");
            }
        }
        return str;
    }
}