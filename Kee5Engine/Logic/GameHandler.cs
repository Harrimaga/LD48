using LD48.Logic.AI;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LD48.Logic
{

    public enum TurnState
    {
        PLAYER1,
        PLAYER2,
        EVENT,
        UNDEFINED
    }
    public class GameHandler
    {
        public Board gameBoard;
        public Player player1, player2;
        public TurnState state;
        public GameState gameState;
        public Texture textTex;

        public BasicAI ai;
        public GameHandler()
        {
            player1 = new Player(0);
            player2 = new Player(1);

            ai = new BasicAI();
            StartGame();
        }

        public void StartGame()
        {
            gameBoard = new Board();
            state = TurnState.PLAYER1;
            gameState = GameState.PLAYING;
        }

        public void EndGame(int winner)
        {
            Window.textRenderer.SetSize(24);
            gameState = GameState.GAMEOVER;

            Bitmap text = Window.textRenderer.RenderString($"{(winner == 0 ? "You are" : "The Enemy is")} the winner!", Color.White);
            textTex = Window.textures.LoadTexture(text, $"WinnerText");
        }

        public void EndTurn()
        {
            state = (TurnState)(((int)state + 1) % 2);
            if ((int)state == 0 || (int)state == 1)
            {
                GetPlayerFromID((int)state).BeginTurn();
                gameBoard.BeginTurn((int)state);
            }

            player1.ChangeTexts();
            player2.ChangeTexts();
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

            if (state == TurnState.PLAYER2)
            {
                ai.Activate(delta);
            }
        }

        public void Draw()
        {

            if (gameState == GameState.PLAYING)
            {
                gameBoard.Draw();
                player1.Draw();
                player2.Draw();
            }
            else if (gameState == GameState.GAMEOVER)
            {
                Window.spriteRenderer.DrawSprite(textTex, new Vector2(960, 500), textTex.Size, 5f, 0, Vector4.One);
            }
        }
    }
}
