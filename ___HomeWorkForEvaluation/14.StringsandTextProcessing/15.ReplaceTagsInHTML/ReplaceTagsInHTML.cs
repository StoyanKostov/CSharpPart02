/* Write a program that replaces in a HTML document given as string all the tags
 * <a href="…">…</a> with corresponding tags [URL=…]…/URL]. */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTagsInHTML
{
    static void Main()
    {
        string inString = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        string patern = @"<a\s+href=""(?<url>[^>]+)"">(?<content>(.|\s)*?)</a>";
        string newPatern = @"[URL=${url}]${content}[/URL]";

        string newString = Regex.Replace(inString, patern, newPatern);

        Console.WriteLine(newString);
    }
}