namespace FluentHtml.Demo
{
    using System;
    using FluentHtml.Extensions;
    using FluentHtml.Models;
    using FluentHtml.Models.Elements;

    class Program
    {
        static void Main(string[] args)
        {
            Node.DefaultIndent = 2;
            var webpage = new HtmlDocument()
                .Begin<Head>()
                    .AddLink(Constants.icon, "image/x-icon", "favicon.ico")
                    .Begin<Link>()
                        .AddAttribute("rel", "stylesheet")
                        .AddAttribute("type", "text/css")
                        .AddAttribute("href", "theme.css")
                    .End().As<Head>()
                    .AddScript("text/javascript", "(function () { alert('Hello World'); })();")
                .End()
                .Begin<Body>()
                    .Begin<Div>()
                        .Id("box1")
                        .Begin<Paragraph>()
                            .AddText("Hello World")
                            .Begin<Anchor>()
                                .AddHref("https://www.google.co.uk")
                                .AddText("click here")
                            .End()
                        .End()
                    .End()
                .End();

            Console.WriteLine(webpage);
            Console.ReadKey();
        }
    }
}
