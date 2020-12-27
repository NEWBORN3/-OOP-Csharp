using System;
using System.Collections.Generic;
using System.Text;

public static class ExtensionMethods 
{
    public static string[] countNow (this string str) {
        var wordcount = str.Split(new char[] { ' ','.','?'}, StringSplitOptions.RemoveEmptyEntries);
        return wordcount;
    }
}