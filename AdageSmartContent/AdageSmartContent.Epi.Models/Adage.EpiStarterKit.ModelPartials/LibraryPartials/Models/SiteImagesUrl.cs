using EPiServer.DataAnnotations;

namespace Adage.EpiStarterKit.ModelPartials.Models
{
    public class SiteImagesUrl : ImageUrlAttribute
    {
        protected static string RootFileName { get; } = "{0}/{1}";
        protected static string AdageIconRoot { get; } = "/Static-Adage/img/Epi-Thumbs";
        protected static string ClientIconRoot { get; } = "/ClientResources/Client-Epi-icons";

        public SiteImagesUrl(string path) : base(path)
        {

        }

        public override string Path
        {
            get
            {
                var basePath = base.Path;
                var clientPath = string.Format(RootFileName, ClientIconRoot, basePath);
                var eskPath = string.Format(RootFileName, AdageIconRoot, basePath);

                var truepath = System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(clientPath)) ? clientPath : eskPath;

                return truepath;
            }
        }
    }
}
