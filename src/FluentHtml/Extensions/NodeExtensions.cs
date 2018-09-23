namespace FluentHtml.Extensions
{
    using System;
    using FluentHtml.Interfaces;
    using FluentHtml.Models;
    using FluentHtml.Models.Attributes;

    public static class NodeExtensions
    {
        public static INode AddAttribute(this INode node, string name, string value)
        {
            return node.AddAttribute(new HtmlAttribute
            {
                Name = name,
                Value = value
            });
        }

        public static INode AddAttribute<TAttribute>(this INode node, TAttribute attribute)
               where TAttribute : IAttribute
        {
            node.Attributes.Add(attribute);
            return node;
        }

        public static INode AddElement<TElement>(this INode node, TElement element)
               where TElement : INode
        {
            element.Parent = node;
            node.Children.Add(element);
            return node;
        }

        public static INode AddElement<TElement>(this INode node)
              where TElement : INode
        {
            var element = Activator.CreateInstance<TElement>();
            return node.AddElement(element);
        }

        public static INode AddInnerText(this INode node, string text)
        {
            return node.AddElement(new InnerText
            {
                Content = text
            });
        } 

        public static TElement BeginElement<TElement>(this INode node)
               where TElement : INode
        {
            var element = Activator.CreateInstance<TElement>();
            node.AddElement(element);
            return element;
        } 

        public static INode EndElement(this INode node)
        {
            if (node.Parent == default(INode))
            {
                return node;
            }

            return node.Parent;
        }
    }
}
