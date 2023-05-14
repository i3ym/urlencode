using System.Web;

if (args[0] == "-d")
{
    Console.WriteLine(HttpUtility.UrlDecode(string.Join(' ', args[1..])));
    return;
}

Console.WriteLine(HttpUtility.UrlEncode(string.Join(' ', args)));
