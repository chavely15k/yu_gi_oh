using System;
using System.Collections.Generic;

namespace YuGiOhTournaments.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FullName { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Deck> Decks { get; set; }
    }

    public class Deck
    {
        public int DeckId { get; set; }
        public int PlayerId { get; set; }
        public string DeckName { get; set; }
        public int MainDeckCardCount { get; set; }
        public int SideDeckCardCount { get; set; }
        public int ExtraDeckCardCount { get; set; }
        public int ArchetypeId { get; set; }

    }

    public class Archetype
    {
        public int ArchetypeId { get; set; }
        public string ArchetypeName { get; set; }
    }

}
