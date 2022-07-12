using System.ComponentModel.DataAnnotations;

namespace Delivery.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public string SendСity { get; set; }
        public string SendAddress { get; set; }
        public string GetСity { get; set; }
        public string GetAddress { get; set; }
        public int Weight { get; set; }
        public DateTime Date { get; set; }
    }
}
