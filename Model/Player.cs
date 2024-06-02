namespace WhatDoYouMeme.Model
{
    public class Player
    {
        private string PlayerName { get; set; }
        private int PlayerScore { get; set; }
        //player image will be fetched from the database
        private string PlayerImagePath { get; set; }

        public Player(string playerName, int playerScore)
        {
            PlayerName = playerName;
            PlayerScore = playerScore;
        }

        public void UpdateScore(int score)
        {
            PlayerScore += score;
        }
    }
}