using LaBonneAuberge.Models;

namespace LaBonneAuberge.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Menu> Menus { get; set; }
    }
}