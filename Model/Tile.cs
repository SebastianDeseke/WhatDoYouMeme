using System;
using System.Collections.Generic;
using WhatDoYouMeme.Model;
using WhatDoYouMeme.PlayingCards;

namespace WhatDoYouMeme.Model;

public class Tile {
    private int TileID { get; set;}
    private string? TileProperty { get; set;}
    private boolean TileIsOccupied { get; set;}
    private PlayingCards TileOccupant { get; set;}

//first instance is empty
    public Tile(int tileID, string tileProperty) {
        TileID = tileID;
        TileProperty = tileProperty;
        TileIsOccupied = false;
    }

    //insantiate the tile with a card
    public Tile(int tileID, string tileProperty, PlayingCards tileOccupant) {
        TileID = tileID;
        TileProperty = tileProperty;
        TileIsOccupied = true;
        TileOccupant = tileOccupant;
    }
}