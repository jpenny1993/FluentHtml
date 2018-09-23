
namespace FluentHtml.Models.Elements
{ 
    using FluentHtml.Models.Attributes;

    /// <summary>
    /// The <script> element is used to define client-side JavaScripts.
    /// </summary>
    public class Script : Node
    {
        public Script() : base("script")
        {
        }

        public Script(string type, string content) : this()
        {
            Attributes.Add(new HtmlAttribute(Constants.type, type));
            Children.Add(new InnerText(content));
        }

        public Script(string source) : this()
        {
            Attributes.Add(new HtmlAttribute(Constants.type, MimeTypes.javascript));
            Attributes.Add(new HtmlAttribute(Constants.src, source));
        }
    }
}
