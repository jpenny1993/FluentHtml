namespace FluentHtml.Models
{
    using System;
    using System.Text;
    using FluentHtml.Extensions;

    public sealed class InnerText : Node
    {
        public string Content { get; set; }

        public InnerText() : base(string.Empty, isSingleTag: true)
        {
        }
        
        public override StringBuilder Draw(StringBuilder builder, int indent)
        {
            var lines = Content?.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries) 
                ?? new string[0];

            foreach (var line in lines)
            {
                builder.DrawIndent(indent);
                builder.AppendLine(line);
            }

            return builder;
        }
    }
}
