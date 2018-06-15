using EPiServer.Core;

namespace EpiserverAngular.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
