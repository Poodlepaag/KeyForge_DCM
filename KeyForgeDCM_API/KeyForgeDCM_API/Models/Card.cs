using System;
using System.Collections.Generic;

#nullable disable

namespace KeyForgeDCM_API.Models
{
    public partial class Card
    {
        public int? DeckId { get; set; }
        public int? CardId { get; set; }
        public string CardName { get; set; }
        public string CardType { get; set; }
        public string CardText { get; set; }

        public virtual Deck Deck { get; set; }
    }
}
