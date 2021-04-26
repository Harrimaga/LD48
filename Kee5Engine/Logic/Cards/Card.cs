using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD48.Logic.Cards
{
    public enum CardState
    {
        DECK = 0,
        HAND = 1,
        BOARD = 2,
        UNDEFINED = -1
    }

    public abstract class Card
    {

        protected Button _card;
        protected bool front;
        protected Vector2 position;
        protected string name, frontTexture;
        public int playerID;

        protected CardState cardState;

        public Card(string name, Vector2 position, bool front, int playerID, string frontTexture = "TestCard")
        {
            this.position = position;
            this.name = name;
            this.front = front;
            this.playerID = playerID;

            if(Window.textures.CheckIfTextureExists(frontTexture))
            {
                this.frontTexture = frontTexture;
            }
            else
            {
                this.frontTexture = "TestCard";
            }
            

            cardState = CardState.DECK;

            if (front)
            {
                if (!(this is Event))
                {
                    _card = new Button(position.X, position.Y, 100, 180, 5, this.frontTexture, Vector4.One, false, () => { OnClick(); });
                }
                else
                {
                    _card = new Button(position.X, position.Y, 100, 180, 5, this.frontTexture, name, Vector4.One, Vector3.Zero, TextAlignment.CENTER, false, () => { OnClick(); });
                }
            }
            else
            {
                _card = new Button(position.X, position.Y, 100, 180, 5, "CardBack", Vector4.One, false, () => { OnClick(); });
            }
        }

        public void SetActive()
        {
            Globals.activeButtons.Add(_card);
        }

        public void SetLayer(float layer)
        {
            _card.layer = layer;
        }

        public void SetRotation(float degrees)
        {
            _card.SetRotation(degrees);
        }

        public void SetPosition(Vector2 position)
        {
            this.position = position;
            _card.SetPosition(position);
        }

        public virtual void OnClick()
        {
            Globals.cardSelected = null;
            if ((int)Globals.gameHandler.state == playerID)
            {
                Console.WriteLine($"Card Clicked! State: {cardState} | Name: {name}");
                switch (cardState)
                {
                    case CardState.DECK:
                        Globals.gameHandler.GetPlayerFromID(playerID).DrawCard();
                        break;
                    case CardState.HAND:
                        if(Play())
                        {
                            cardState = CardState.BOARD;
                        }
                        break;
                }
            }
        }

        public void SetState(CardState state)
        {
            cardState = state;
        }

        public void Update(double delta)
        {
            _card.Update();
        }

        public void Draw()
        {
            _card.Draw();
        }

        public void Flip()
        {
            bool removed = false;
            if (Globals.activeButtons.Contains(_card)) 
            {
                Globals.activeButtons.Remove(_card);
                removed = true;
            }

            if (front)
            {
                _card = new Button(position.X, position.Y, 100, 180, 5, "CardBack", Vector4.One, false, () => { OnClick(); });
            }
            else
            {
                if (!(this is Event))
                {
                    _card = new Button(position.X, position.Y, 100, 180, 5, this.frontTexture, Vector4.One, false, () => { OnClick(); });
                }
                else
                {
                    _card = new Button(position.X, position.Y, 100, 180, 5, this.frontTexture, name, Vector4.One, Vector3.Zero, TextAlignment.CENTER, false, () => { OnClick(); });
                }
            }

            if (removed)
            {
                Globals.activeButtons.Add(_card);
            }

            front = !front;
        }

        public virtual bool Play()
        {
            return Globals.gameHandler.gameBoard.PlayCard(this, playerID);
        }

        public virtual void Activate()
        {

        }

        public virtual bool Play(int x, int y)
        {
            return false;
        }

        public virtual void OnEnter(int playerID) { }

        public virtual void OnLeave() 
        {
            Globals.activeButtons.Remove(_card);
        }

    }
}
