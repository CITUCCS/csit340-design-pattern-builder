using System.Text;

var words = new[] { "hello", "world" };
var sb = new StringBuilder();
sb.Clear();
sb.Append("<ul>");
foreach (var word in words)
{
    sb.AppendFormat("<li>{0}</li>", word);
}
sb.Append("</ul>");
Console.WriteLine(sb);