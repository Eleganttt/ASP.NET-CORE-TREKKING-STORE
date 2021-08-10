

namespace TrekkingStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    public class Category
    {
        public int Id { get; init; }


        [Required]
        [MaxLength(CategoryNameMaxLenght)]
        public string Name { get; init; }

        public IEnumerable<Product> Products { get; init; } = new List<Product>();
    }
}
