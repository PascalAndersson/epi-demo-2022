using EPiServer.Core;

namespace demo_episerver11.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
