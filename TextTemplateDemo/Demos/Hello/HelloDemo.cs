using Scriban.Runtime;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.TextTemplating;

namespace TextTemplateDemo.Demos.Hello
{
    public class HelloDemo : ITransientDependency
    {
        private readonly ITemplateRenderer _templateRenderer;

        public HelloDemo(ITemplateRenderer templateRenderer)
        {
            _templateRenderer = templateRenderer;
        }

        public async Task RunAsync()
        {
            var model = new HelloModel
            {
                Name = "Johnson Will",
                Report = new Report { Name = "Mismo1004", SubjectProperty = new SubjectProperty { Name = "HaloGlobal",StreetAddressLine1 ="Newyork 111" } }
            };
   
            var result = await _templateRenderer.RenderAsync(
                "Hello", //the template name
               model
            );

            Console.WriteLine(result);
        }

        public async Task RunWithAnonymousModelAsync()
        {
            var result = await _templateRenderer.RenderAsync(
                "Hello", //the template name
                new
                {
                    Name = "John"
                }
            );

            Console.WriteLine(result);
        }
    }
}
