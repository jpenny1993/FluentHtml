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
                    .AddLink("icon", "image/x-icon", "favicon.ico")
                    .BeginElement<Link>()
                        .AddAttribute("rel", "stylesheet")
                        .AddAttribute("type", "text/css")
                        .AddAttribute("href", "theme.css")
                    .EndElement().As<Head>()
                    .AddScript("text/javascript", "(function () { alert('Hello World'); })();")
                .EndElement()
                .BeginElement<Body>()
                    .BeginElement<Div>()
                        .AddAttribute("id", "box1")
                        .BeginElement<Paragraph>()
                            .AddInnerText("Hello World")
                        .EndElement()
                    .EndElement()
                .EndElement();

            Console.WriteLine(webpage);
            Console.ReadKey();
        }
    }
}
