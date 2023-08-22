using System.Web;


if (args.Length > 0 && args[0] == "-d")
{
    var data = args.Length == 1
        ? await new StreamReader(Console.OpenStandardInput()).ReadToEndAsync()
        : "\n";
    data = data[..^1]; // remove newline

    if (data.Length != 0) Console.WriteLine(HttpUtility.UrlDecode(data));
    if (args.Length > 1) Console.WriteLine(HttpUtility.UrlDecode(string.Join(' ', args[1..])));
}
else
{
    var data = args.Length == 0
        ? await new StreamReader(Console.OpenStandardInput()).ReadToEndAsync()
        : "\n";
    data = data[..^1]; // remove newline

    if (data.Length != 0) Console.WriteLine(HttpUtility.UrlEncode(data));
    if (args.Length > 0) Console.WriteLine(HttpUtility.UrlEncode(string.Join(' ', args)));
}