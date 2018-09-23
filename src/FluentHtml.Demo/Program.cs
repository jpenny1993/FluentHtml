namespace FluentHtml.Demo
{
    using System;
    using FluentHtml.Extensions;
    using FluentHtml.Models.Elements;

    class Program
    {
        static void Main(string[] args)
        {
            var webpage = new HtmlDocument()
                .BeginElement<Head>()
                    .BeginElement<Script>()
                        .AddAttribute("type", "text/javascript")
                        .AddInnerText("(function () { alert('Hello World'); })();")
                    .EndElement()
                .EndElement()
                .BeginElement<Body>()
                    .BeginElement<Div>()
                        .AddAttribute("id", "box1")
                        .AddElement<Paragraph>()
                    .EndElement()
                .EndElement();

            Console.WriteLine(webpage);
            Console.ReadKey();
        }
    }
}
