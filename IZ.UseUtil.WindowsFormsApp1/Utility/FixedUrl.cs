
namespace IZ_ORM.Utility
{
    public interface IFixedUrl
    {
        string FixedUrlHelper(string url);
        string UnFixedUrlHelper(string url);
    }

    public class FixedUrl : IFixedUrl
    {
        public string FixedUrlHelper(string url)
        {
            return url?.Replace(" ", "-");
        }

        public string UnFixedUrlHelper(string url)
        {
            return url?.Replace("-", " ");
        }
    }
}
