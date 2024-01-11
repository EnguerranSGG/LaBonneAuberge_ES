using LaBonneAuberge.Models;

namespace LaBonneAuberge.ViewModels
{
    public class HomeViewModel
    {
        public List<Category>? Categories { get; set; }
        public List<FeedBackModel>? FeedBacks { get; set; }
    }
}