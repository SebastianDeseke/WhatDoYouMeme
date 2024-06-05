using System;

namespace WhatDoYouMeme.Model;

private abstract class Cards
{
    private string CardName { get; set; }
    private string CardDescription { get; set; }
    private string CardImagePath { get; set; }
    private string CardAbility1 { get; set; }
    private string CardAbility2 { get; set; }
    private string CardSpecialAbility { get; set; }

    public enum CardCategory
    {
        Damage, Heal, Defence, Enhancment, Item, Special
    }

    public Cards(string cardName, string cardDescription, string cardImagePath, string cardCategory, string cardAbility1, string cardAbility2, string cardSpecialAbility)
    {
        CardName = cardName;
        CardDescription = cardDescription;
        CardImagePath = cardImagePath;
        CardCategory = cardCategory;
        CardAbility1 = cardAbility1;
        CardAbility2 = cardAbility2;
        CardSpecialAbility = cardSpecialAbility;
    }
}