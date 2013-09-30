/// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
/// [protocol] = "http"
/// [server] = "www.devbg.org"
/// [resource] = "/forum/index.php"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParsesURL
{
    static void Main(string[] args)
    {
        // Console input
        string str = @"http://www.devbg.org/forum/index.php";

        // Main Logic
        int protocolLastIndex = str.IndexOf("//");
        string protocol = str.Substring(0, protocolLastIndex - 1);

        int serverLastIndex = str.IndexOf("/", protocolLastIndex + 2);
        string server = str.Substring(protocolLastIndex + 2, serverLastIndex - protocolLastIndex - 2);

        string resource = str.Substring(serverLastIndex);

        //Consol Output
        Console.WriteLine("[protocol] = \"{0}\"\n[server] = \"{1}\"\n[resource] = \"{2}\"", protocol, server, resource);
    }
}