using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YgoApp.Models
{
    public class Deck
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("UserId")]
        public long UserId { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}