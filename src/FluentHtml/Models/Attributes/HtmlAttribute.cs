namespace FluentHtml.Models.Attributes
{
    using FluentHtml.Interfaces;

    public class HtmlAttribute : IAttribute
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
