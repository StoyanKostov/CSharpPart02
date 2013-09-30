/* Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements.
 * For example from the URL http://www.devbg.org/forum/index.php
 * the following information should be extracted:
 *		[protocol] = "http"
 *		[server] = "www.devbg.org"
 *		[resource] = "/forum/index.php" */

using System;
using System.Text;
using System.Text.RegularExpressions;

class ParseURLAddress
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        string urlPattern = @".*(?<protocol>\b.+?)://(?<server>.+?)(?<resource>/\S*).*";
        Match matches = Regex.Match(url, urlPattern);
        string protocol = matches.Groups["protocol"].Value;
        string server = matches.Groups["server"].Value;
        string resource = matches.Groups["resource"].Value;
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}