
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
            Attributes.Add(new HtmlAttribute("type", type));
            Children.Add(new InnerText(content));
        }
    }
}
