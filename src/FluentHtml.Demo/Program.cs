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
                .Begin<Head>()
                .End()
                .Begin<Body>()
                    .Begin<Div>()
                        .AddElement<Paragraph>()
                    .End()
                .End();

            Console.WriteLine(webpage);
            Console.ReadKey();
        }
    }
}
