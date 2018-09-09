namespace FluentHtml.Interfaces
{
    using System.Collections.Generic;
    using System.Text;
    
    public interface INode
    {
        ICollection<IAttribute> Attributes { get; set; }
        ICollection<INode> Children { get; set; }
        INode Parent { get; set; }
        StringBuilder Draw(StringBuilder builder, int indent);
        string WriteOutput();
    }
}
