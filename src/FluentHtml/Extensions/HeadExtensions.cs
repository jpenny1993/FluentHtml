namespace FluentHtml.Extensions
{
    using FluentHtml.Models.Elements;

    public static class HeadExtensions
    {
        public static Head AddLink(this Head node, string rel, string type, string href)
        {            
            return node.AddElement(new Link(rel, type, href));
        }

        public static Head AddScript(this Head node, string href)
        {
            return node.AddElement(new Script(href));
        }

        public static Head AddScript(this Head node, string type, string content)
        {
            return node.AddElement(new Script(type, content));
        }
    }
}
