using System;
using System.Collections.Generic;
using WhatDoYouMeme.Model;

namespace WhatDoYouMeme.PlayingCards;
    public class NickAvacado : Cards {
        public NickAvacado() {
            CardName = "Nick's Avacado";
            CardDescription = "Nick's avacado. grants heals and small defence. When playing Nick its status effects are increased";
            CardImagePath = "NickAvacado.png";
            CardCategory = "Heal";
            CardAbility1 = "Heal 10 HP";
            CardAbility2 = "Defence +2";
            CardSpecialAbility = "Status effects +2";
    }
}