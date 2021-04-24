using System;
using System.Collections.Generic;
using System.Text;

namespace LD48.Logic
{
    public class GameHandler
    {
        public Board gameBoard;
        public Player player1, player2;
        public GameHandler()
        {
            player1 = new Player(0);
            player2 = new Player(1);
            StartGame();
        }

        public void StartGame()
        {
            gameBoard = new Board();
        }

        public Player GetPlayerFromID(int id)
        {
            return id == 0 ? player1 : player2;
        }

        public void Update(double delta)
        {
            gameBoard.Update(delta);
            player1.Update(delta);
            player2.Update(delta);
        }

        public void Draw()
        {
            gameBoard.Draw();
            player1.Draw();
            player2.Draw();
        }
    }
}
