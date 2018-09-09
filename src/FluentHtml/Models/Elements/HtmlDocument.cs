namespace FluentHtml.Models.Elements
{
    using System.Text;

    /// <summary>
    /// The <html> tag tells the browser that this is an HTML document.
    /// This tag represents the root of an HTML document.
    /// This tag is the container for all other HTML elements.
    /// </summary>
    public class HtmlDocument : Node
    {
        public DocType DocumentType;

        public HtmlDocument() : this(DocType.HTML_5)
        {
        }

        public HtmlDocument(DocType docType) : base("html")
        {
            DocumentType = docType;
        }

        public override StringBuilder Draw(StringBuilder builder, int indent)
        {
            return base.Draw(builder, indent);
        }

        private void DrawDocumentType(StringBuilder builder)
        {
            builder.AppendLine("<!DOCTYPE ");

            switch (DocumentType)
            {
                default:
                case DocType.HTML_5:
                    builder.Append("html");
                    break;
                case DocType.HTML_4_01_Strict:
                    builder.Append("HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"");
                    break;
                case DocType.HTML_4_01_Transitional:
                    builder.Append("HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"");
                    break;
                case DocType.HTML_4_01_Frameset:
                    builder.Append("HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"");
                    break;
                case DocType.XHTML_1_0_Strict:
                    builder.Append("html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"");
                    break;
                case DocType.XHTML_1_0_Transitional:
                    builder.Append("html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"");
                    break;
                case DocType.XHTML_1_0_Frameset:
                    builder.Append("html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"");
                    break;
                case DocType.XHTML_1_1:
                    builder.Append("html PUBLIC \" -//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"");
                    break;
            }

            builder.AppendLine(">");
        }
    }
}
