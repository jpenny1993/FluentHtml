
namespace FluentHtml.Models.Elements
{
    using System.Text;
    using FluentHtml.Extensions;
    using FluentHtml.Models.Attributes;

    /// <summary>
    /// The <link> tag defines a link between a document and an external resource.
    /// The<link> tag is used to link to external style sheets.
    /// </summary>
    public class Link : Node
    {
        public Link() : base("link", isSingleTag: true)
        {
        }

        public Link(string rel, string type, string href) : this()
        {
            Attributes.Add(new HtmlAttribute("rel", rel));
            Attributes.Add(new HtmlAttribute("type", type));
            Attributes.Add(new HtmlAttribute("href", href));
        }

        public override StringBuilder Draw(StringBuilder builder, int indent)
        {
            return builder
            .DrawIndent(indent)
            .BeginOpenTag(TagName)
            .DrawAttributes(Attributes)
            .EndOpenTag(newLine: true);
        }
    }
}
