// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Text.RegularExpressions;
/* 
 * Have the function SnakeCase(str) take the str parameter being passed 
 * and return it in proper snake case format where each word is lowercased 
 * and separated from adjacent words via an underscore. The string will 
 * only contain letters and some combination of delimiter punctuation 
 * characters separating each word.
 * 
 * For example: if str is "BOB loves-coding" then your program should 
 * return the string bob_loves_coding.
 * 
 * Examples: 
 *   Input:  BOB loves-coding
 *   Output: bob_loves_coding
 *   
 *   Input:  I like cats&dogs
 *   Output: i_like_cats_dogs
 *   
 *   Input:  a b c d-e-f%g
 *   Output: a_b_d_d_e_f_g
 * 
 */

class SampleClass
{

    public static string SnakeCase(string str)
    {

        // get lowercase letter-only string, separated by underscore(s), and trim any underscores from beginning and end
        Regex rgx = new Regex("[^a-z_]");
        str = rgx.Replace(str.ToLower(), "_").Trim('_');

        // remove excessive underscores and keep only one between words before returning the string
        return Regex.Replace(str, "_{2,}", "_");
    }


    static void Main()
    {

        // keep this function call here
        Console.WriteLine(SnakeCase(Console.ReadLine()));

    }

}