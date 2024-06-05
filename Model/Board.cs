namespace WhatDoYouMeme.Model
{
    public class Board implements Tile
    {
        private int BoardSize { get; set; }
        private string BoardName { get; set; }
        private string BoardBackgroundImagePath { get; set; }
        private Tile[] tiles { get; set; }

        //only the boardname is required, the rest will be found in the database
        public Board(string boardName)
        {
            BoardSize = boardSize;
            BoardName = boardName;
            BoardBackgroundImagePath = boardBackgroundImagePath;
            tiles = tiles;
        }

        public int getBoardSize()
        {
            //depending on the name of the board, the size will be fetched from the database
            return BoardSize;
        }

        public string getBoardBackgroundImagePath()
        {
            //depending on the name of the board, the image will be fetched from the database
            return BoardBackgroundImagePath;
        }

        public Tile[] getTiles()
        {
            //depending on the name of the board, the tiles will be fetched from the database
            return tiles;
        }
    }
}