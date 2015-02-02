
namespace NancyApp
{
    public class Bootstrapper : Nancy.DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            this.Conventions.ViewLocationConventions.Add((viewName, model, context) =>
            {
                return string.Concat("bin/Views/", viewName);
            });
        }
    }
}
