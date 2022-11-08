using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class HtmlElement
    {
        public string? Name, Text;

        public List<HtmlElement> Elements = new List<HtmlElement>();

        public HtmlElement() { }
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"<{Name}>");
            foreach (var element in Elements)
            {
                sb.AppendLine(element.ToString());
            }
            sb.Append($"</{Name}>");

            return sb.ToString();
        }
    }
}
