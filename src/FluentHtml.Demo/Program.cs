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

            int i = 1;
            
            var htmlOutput = webpage.WriteOutput();

            Console.WriteLine(htmlOutput);
            Console.ReadKey();
        }
    }
}
