namespace FluentHtml.Models
{
    using System.Collections.Generic;
    using System.Text;
    using FluentHtml.Extensions;
    using FluentHtml.Interfaces;

    public abstract class Node : INode
    {
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

            return builder
                .DrawIndent(indent)
                .BeginOpenTag(TagName)
                .DrawAttributes(Attributes)
                .EndOpenTag()
                .DrawChildren(Children, indent)
                .DrawIndent(indent)
                .DrawCloseTag(TagName);
        }
        
        public string WriteOutput()
        {
            return Draw(new StringBuilder(), 0).ToString();
        }
    }
}
