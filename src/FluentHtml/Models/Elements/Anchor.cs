namespace FluentHtml.Models.Elements
{
    using FluentHtml.Interfaces;

    /// <summary>
    /// The <a> tag defines a hyperlink, which is used to link from one page to another.
    /// </summary>
    public class Anchor : Node, INodeWithHref
    {
        public Anchor() : base("a")
        {
        }
    }
}
