using System;
using System.Collections.Generic;

namespace WhatDoYouMeme.Model;

public class Player
{
    private string PlayerName { get; set; }
    private int PlayerScore { get; set; }
    //player image will be fetched from the database
    private string PlayerImagePath { get; set; }
    private int lobbyID { get; set; }

    public Player(string playerName)
    {
        PlayerName = playerName;
        PlayerScore = 0;
    }

    public void UpdateScore(int score)
    {
        PlayerScore += score;
    }
}
