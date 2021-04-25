using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using LD48.Logic.Cards;
using LD48;
using OpenTK.Mathematics;

namespace LD48.Logic
{
    public class Player
    {

        public Hand hand;
        private Deck deck;
        private int debt = 0, playerID, cardsDrawn, housing = 0, electicity = 0, internet = 0, travel = 0, illegal = 0, happiness = 0;

        Bitmap text, textDeck, textCost, textHouse, textElec, textInternet, textTravel, textIllegal, textHappiness;
        Texture textTex, deckTex, costTex, houseTex, elecTex, interTex, travTex, illTex, hapTex;


        public Player(int id)
        {
            hand = new Hand(id);
            deck = new Deck(id);
            playerID = id;

            ChangeTexts();
        }

        public void Update(double delta)
        {
            hand.Update(delta);
            deck.Update(delta);
        }

        public void BeginTurn()
        {
            cardsDrawn = 0;
            debt += Balance.GetElecticityCost(electicity);
            debt += Balance.GetHousingCost(housing);
            debt += Balance.GetInternetCost(internet);
            debt += Balance.GetTravelCost(travel);
        }

        public int getDebt()
        {
            return debt;
        }

        public void DrawCard()
        {
            if (!hand.CheckForSpace())
            {
                return;
            }
            Card card = deck.DrawCard();

            hand.AddCardToHand(card);
            card.Flip();
            card.SetState(CardState.HAND);

            cardsDrawn++;
            debt += Balance.GetDrawCost(cardsDrawn);
            ChangeTexts();
        }

        public void ChangeTexts()
        {
            text = Window.textRenderer.RenderString($"Debt: {((float)debt /*/ 100*/)}", Color.Black);
            textDeck = Window.textRenderer.RenderString($"Cards left: {deck.GetCardsRemaining()}", Color.Black);
            textCost = Window.textRenderer.RenderString($"Cost: {Balance.GetDrawCost(cardsDrawn + 1)}", Color.Black);
            textHouse = Window.textRenderer.RenderString($"Housing: {housing}", Color.Black);
            textElec = Window.textRenderer.RenderString($"Electricity: {electicity}", Color.Black);
            textInternet = Window.textRenderer.RenderString($"Internet: {internet}", Color.Black);
            textTravel = Window.textRenderer.RenderString($"Travel: {travel}", Color.Black);
            textIllegal = Window.textRenderer.RenderString($"Illegal: {illegal}", Color.Black);
            textHappiness = Window.textRenderer.RenderString($"Happiness: {happiness}", Color.Black);

            textTex = Window.textures.LoadTexture(text, $"DebtPlayer{playerID}Text");
            deckTex = Window.textures.LoadTexture(textDeck, $"DeckPlayer{playerID}Text");
            costTex = Window.textures.LoadTexture(textCost, $"CostPlayer{playerID}Text");
            houseTex = Window.textures.LoadTexture(textHouse, $"HousingPlayer{playerID}Text");
            elecTex = Window.textures.LoadTexture(textElec, $"ElectricityPlayer{playerID}Text");
            interTex = Window.textures.LoadTexture(textInternet, $"InternetPlayer{playerID}Text");
            travTex = Window.textures.LoadTexture(textTravel, $"TravelPlayer{playerID}Text");
            illTex = Window.textures.LoadTexture(textIllegal, $"IllegalPlayer{playerID}Text");
            hapTex = Window.textures.LoadTexture(textHappiness, $"HappinessPlayer{playerID}Text");
        }

        public void Draw()
        {
            hand.Draw();
            deck.Draw();

            Window.textRenderer.SetSize(24);

            Window.spriteRenderer.DrawSprite(textTex, new Vector2(175, 590 - 300 * playerID), textTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(deckTex, new Vector2(175, 630 - 300 * playerID), deckTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(costTex, new Vector2(175, 670 - 300 * playerID), costTex.Size, 5f, 0, Vector4.One);

            Window.spriteRenderer.DrawSprite(houseTex, new Vector2(1800, 860 - 840 * playerID), houseTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(elecTex, new Vector2(1800, 900 - 840 * playerID), elecTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(interTex, new Vector2(1800, 940 - 840 * playerID), interTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(travTex, new Vector2(1800, 980 - 840 * playerID), travTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(illTex, new Vector2(1800, 1020 - 840 * playerID), illTex.Size, 5f, 0, Vector4.One);
            Window.spriteRenderer.DrawSprite(hapTex, new Vector2(1800, 1060 - 840 * playerID), hapTex.Size, 5f, 0, Vector4.One);
        }
    
        public void AddDebt(int amount)
        {
            debt += amount;
        }
    
        public void AddElecticity(int amount)
        {
            electicity += amount;
        }

        public void AddInternet(int amount)
        {
            internet += amount;
        }

        public void AddTravel(int amount)
        {
            travel += amount;
        }

        public void AddIllegal(int amount)
        {
            illegal += amount;
        }

        public void AddHappiness(int amount)
        {
            happiness += amount;
        }

        public int GetHappiness()
        {
            return happiness;
        }

        public void AddHousing(int amount)
        {
            housing += amount;
        }


    }
}
