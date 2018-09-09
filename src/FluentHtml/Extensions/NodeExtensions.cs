namespace FluentHtml.Extensions
{
    using System;
    using FluentHtml.Interfaces;

    public static class NodeExtensions
    {
        public static INode AddElement<TElement>(this INode node)
               where TElement : INode
        {
            return node.Begin<TElement>().End();
        }

        public static TElement Begin<TElement>(this INode node)
               where TElement : INode
        {
            var element = Activator.CreateInstance<TElement>();
            element.Parent = node;
            node.Children.Add(node);
            return element;
        }

        public static INode End(this INode node)
        {
            if (node.Parent == default(INode))
            {
                return node;
            }

            return node.Parent;
        }
    }
}
