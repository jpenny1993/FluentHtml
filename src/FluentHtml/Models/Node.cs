namespace FluentHtml.Models
{
    using System.Collections.Generic;
    using System.Text;
    using FluentHtml.Extensions;
    using FluentHtml.Interfaces;

    public abstract class Node : INode
    {
        public static int DefaultIndent = 4;

        protected bool IsSingleTag;
        protected string TagName;

        public ICollection<IAttribute> Attributes { get; set; } = new HashSet<IAttribute>();
        public ICollection<INode> Children { get; set; } = new HashSet<INode>();
        public INode Parent { get; set; }

        public Node()
        {
        }

        public Node(string tag)
        {
            IsSingleTag = false;
            TagName = tag;
        }

        public Node(string tag, bool isSingleTag)
        {
            IsSingleTag = isSingleTag;
            TagName = tag;
        }
        
        public virtual StringBuilder Draw(StringBuilder builder, int indent)
        {
            if (IsSingleTag)
            {
                return builder
                .DrawIndent(indent)
                .BeginOpenTag(TagName)
                .DrawAttributes(Attributes)
                .EndOpenTagSingle();
            }

            // An indent is only required if we have child elements
            var hasChildren = Children.Count > 0;
            var closingIndent = hasChildren ? indent : 0;

            return builder
                .DrawIndent(indent)
                .BeginOpenTag(TagName)
                .DrawAttributes(Attributes)
                .EndOpenTag(newLine: hasChildren)
                .DrawChildren(Children, indent + DefaultIndent)
                .DrawIndent(closingIndent)
                .DrawCloseTag(TagName);
        }
        
        public override string ToString()
        {
            return Draw(new StringBuilder(), 0).ToString();
        }
    }
}
