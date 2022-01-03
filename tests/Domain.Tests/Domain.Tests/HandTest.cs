using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Domain.Tests
{
    public class HandTest
    {
        private Hand _hand;
        public HandTest()
        {
            _hand = new Hand(); 
        }

        [Fact]
        public void Create_Hand_Empty_NrOfCards()
        {
            Assert.Equal(0, _hand.NrOfCards);
        }

        [Fact]
        public void AddsCard_Add_Card_To_Hand()
        {
            var card = new BlackJackCard(Suit.Hearts, FaceValue.Two);
            _hand.AddCard(card);
            Assert.Equal(1, _hand.NrOfCards);
        }


        [Fact]//(Skip = "Not yet implemented")
        public void TurnAllCardsFaceUp_Flips_Card_FaceUp() 
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Seven);
            card.TurnCard();
            _hand.AddCard(card);
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Three));
            _hand.TurnAllCardsFaceUp();
            foreach (BlackJackCard blackJackCard in _hand.Cards)
            Assert.True(blackJackCard.FaceUp);
        }

        [Fact]//(Skip = "Not yet implemented")
        public void EmptyHand_Value_IsZero()
        {
            Assert.Equal(0, _hand.Value);
        }
    }
}
