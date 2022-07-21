namespace BethanyPieShopMVC.Models
{
    public interface ICategoryRepository
    {
        //readonly properties
        IEnumerable<Category> AllCategories { get; }
    }
}
