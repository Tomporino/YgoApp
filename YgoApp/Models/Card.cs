using System.ComponentModel.DataAnnotations;

namespace YgoApp.Models
{
    public class Card
    {
        [Key]
        public long Id { get; set; }
        public long CardId { get; set; }
        public string CardUrl { get; set; }
    }
}