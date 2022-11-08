using System.Text;

namespace Builder
{
    public class HtmlElement
    {
        public string? Name, Text;

        public List<HtmlElement> Elements = new List<HtmlElement>();

        protected HtmlElement() { }
        protected HtmlElement(string name, string? text)
        {
            Name = name;
            Text = text;
        }

        public void AddChildElement(string name, string? text)
        {
            Elements.Add(new HtmlElement(name, text));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<{Name}>");
            foreach (var element in Elements)
            {
                sb.AppendLine($"<{element.Name}>{element.Text}</{element.Name}>");
            }
            sb.Append($"</{Name}>");

            return sb.ToString();
        }

        public static HtmlBuilder Create(string name) => new HtmlBuilder(new HtmlElement(name, null));
    }
}
