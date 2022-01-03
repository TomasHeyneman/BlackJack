using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Domain.Tests
{
    public class BlackJackCardTest
    {
        [Fact]
        public void Card_Is_Set_Visible()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            card.TurnCard();
            Assert.True(card.FaceUp);
        }

        [Fact]
        public void Card_Is_Set_Invisible()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            card.TurnCard();
            card.TurnCard();
            Assert.False(card.FaceUp);
        }

        [Fact]
        public void Card_Is_Created_Correctly()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            Assert.Equal(Suit.Hearts, card.Suit);
            Assert.Equal(FaceValue.Ace, card.FaceValue);
            Assert.False(card.FaceUp);
        }

        [Fact]
        public void Card_TurnCard_Cart_Given_Correct_Value()
        {
            BlackJackCard card = new BlackJackCard(Suit.Spades, FaceValue.Queen);
            card.TurnCard();
            Assert.Equal(10,card.Value);
        }

        [Fact]
        public void Card_TurnCard_Cart_FacedDown()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            Assert.Equal(0, card.Value);
        }

    }
}
