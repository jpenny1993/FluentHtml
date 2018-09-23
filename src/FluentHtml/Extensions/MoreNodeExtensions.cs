namespace FluentHtml.Extensions
{
    using FluentHtml.Interfaces;
    using FluentHtml.Models.Elements;

    public static class MoreNodeExtensions
    {
        public static TElement AddAnchor<TElement>(this TElement node, string target, string href, string text)
               where TElement : class, INode
        {
            return node.Begin<Anchor>()
                .AddAttribute(Constants.target, target)
                .AddHref(href)
                .AddText(text)
                .End()
                .As<TElement>();
        }

        public static TElement AddHref<TElement>(this TElement node, string href)
               where TElement : INodeWithHref
        {
            return node.AddAttribute(Constants.href, href);
        }
    }
}
