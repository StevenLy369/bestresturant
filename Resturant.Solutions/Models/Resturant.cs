namespace Resturant.Models
{
    public class Resturant
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Cuisine Name { get; set; }
    }
}