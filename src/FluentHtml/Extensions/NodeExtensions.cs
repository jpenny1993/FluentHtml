namespace FluentHtml.Extensions
{
    using System;
    using FluentHtml.Interfaces;
    using FluentHtml.Models.Attributes;
    using FluentHtml.Models.Elements;

    public static class NodeExtensions
    {
        public static TElement AddAttribute<TElement>(this TElement node, string name, string value)
               where TElement : INode
        {
            return node.AddAttribute(new HtmlAttribute
            {
                Name = name,
                Value = value
            });
        }

        public static TElement AddAttribute<TElement, TAttribute>(this TElement node, TAttribute attribute)
               where TElement : INode
               where TAttribute : IAttribute
        {
            node.Attributes.Add(attribute);
            return node;
        }

        public static PElement AddElement<PElement, TElement>(this PElement node, TElement element)
               where PElement : INode
               where TElement : INode
        {
            element.Parent = node;
            node.Children.Add(element);
            return node;
        }

        public static PElement AddElement<PElement, TElement>(this PElement node)
               where PElement : INode
               where TElement : INode
        {
            var element = Activator.CreateInstance<TElement>();
            return node.AddElement(element);
        }

        public static TElement AddText<TElement>(this TElement node, string text)
               where TElement : INode
        {
            return node.AddElement(new InnerText(text));
        }

        public static TElement As<TElement>(this INode node)
               where TElement : class, INode
        {
            return node as TElement;
        }

        public static TElement Begin<TElement>(this INode node)
               where TElement : INode
        {
            var element = Activator.CreateInstance<TElement>();
            node.AddElement(element);
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

        public static TElement Id<TElement>(this TElement node, string id)
               where TElement : INode
        {
            node.AddAttribute(Constants.id, id);
            return node;
        }

        public static TElement Name<TElement>(this TElement node, string name)
               where TElement : INode
        {
            node.AddAttribute(Constants.name, name);
            return node;
        }
    }
}
