using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPControls.Models
{
    public enum Category
    {
        Electronics = 1,
        Books = 2,
        Clothing = 3
    }

    public class Language
    {
        public string Name { get; set; }
        public string code { get; set; }
    }

    public class ProductViewModel
    {
        public List<SelectListItem> Categories { get; set; }
        public List<Language> Languages { get; set; }
        public string SelectedLanguageCode { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<string> Students { get; set; }
        public string selectedStudent { get; set; }
    }
}
