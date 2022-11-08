namespace Builder
{
    public class HtmlBuilder
    {
        protected HtmlElement _root;

        public HtmlBuilder(HtmlElement root)
        {
            _root = root;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            _root.AddChildElement(childName, childText);

            return this;
        }

        public HtmlElement Build() => _root;
    }
}
