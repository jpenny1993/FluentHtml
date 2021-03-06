﻿namespace FluentHtml.Extensions
{
    using System.Collections.Generic;
    using System.Text;
    using FluentHtml.Interfaces;

    public static class StringBuilderExtensions
    {
        public static StringBuilder BeginOpenTag(this StringBuilder builder, string tag)
        {
            return builder.Append($"<{tag}");
        }

        public static StringBuilder EndOpenTag(this StringBuilder builder, bool newLine)
        {
            builder.Append(">");
            if (newLine)
            {
                builder.AppendLine();
            }

            return builder;
        }

        public static StringBuilder EndOpenTagSingle(this StringBuilder builder)
        {
            return  builder.AppendLine("/>");
        }

        public static StringBuilder DrawAttributes(this StringBuilder builder,
            ICollection<IAttribute> Attributes)
        {
            foreach (var attr in Attributes)
            {
                builder.Append($" {attr.Name}=\"{attr.Value}\"");
            }

            return builder;
        }

        public static StringBuilder DrawChildren(this StringBuilder builder,
            ICollection<INode> Children, int indent)
        {
            foreach (var elem in Children)
            {
                elem.Draw(builder, indent);
            }

            return builder;
        }

        public static StringBuilder DrawCloseTag(this StringBuilder builder, string tag)
        {
            return builder.AppendLine($"</{tag}>");
        }

        public static StringBuilder DrawIndent(this StringBuilder builder, int indent)
        {
            for (var i = 0; i < indent; i++)
            {
                builder.Append(" ");
            }
            return builder;
        }
    }
}
