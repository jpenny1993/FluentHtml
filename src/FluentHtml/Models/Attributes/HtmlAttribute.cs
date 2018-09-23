namespace FluentHtml.Models.Attributes
{
    using FluentHtml.Interfaces;

    public class HtmlAttribute : IAttribute
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public HtmlAttribute()
        {
        }

        public HtmlAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
