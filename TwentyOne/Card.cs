﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }
    }
    public enum Suits
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Faces
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
