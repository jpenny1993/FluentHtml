namespace FluentHtml.Models
{
    using System.Text;

    public sealed class InnerText : Node
    {
        public string Content { get; set; }

        public InnerText() : base()
        {
        }
        
        public override StringBuilder Draw(StringBuilder builder, int indent)
        {
            return builder.Append(Content);
        }
    }
}
