using Filip_Ioana_Lab2.Models;
namespace Filip_Ioana_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Category { get; set; }

    }
}