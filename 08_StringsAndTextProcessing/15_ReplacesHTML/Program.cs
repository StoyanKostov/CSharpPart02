/// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplacesHTML
{
    static void Main(string[] args)
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string replaced = text.Replace(@"<a href=""", "[URL=").Replace(@"</a>", "[/URL]").Replace(@""">", "]");

        // Console OutPut
        Console.WriteLine(replaced);
    }
}