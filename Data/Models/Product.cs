namespace TrekkingStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Product
    {
        public int Id { get; init; }


        [Required]
        [MaxLength(ProductNameMaxLenght)]
        public string Name { get; set; }


        [Required]
        [MaxLength(ProductBrandMaxLenght)]
        public string Brand { get; set; }


        [Required]
        [MaxLength(DescriptionMaxLenght)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; init; }
    }
}
