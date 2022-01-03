using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Domain.Tests
{
    public class DeckTest
    {
        private readonly Deck _deck;

        public DeckTest()
        {
            _deck = new Deck();
        }


        [Fact]
        public void Deck_DrawCards_DeckIsEmpty_Throws_Exception()
        {
            for (int i = 0; i < 52; i++)
                _deck.Draw();
            Assert.Throws<InvalidOperationException>(() => _deck.Draw());
        }

        [Fact]
        public void Deck_DrawCards_Deck_Is_Not_Empty()
        {
            Assert.IsType<BlackJackCard>(_deck.Draw());
        }

        [Fact]
        public void Deck_Shuffle_Cards_Successfully()
        {
            BlackJackCard card;
            var suitValues = new int[4];
            var faceValues = new int[13];
            for (int i = 0; i < 52; i++)
            {
                card = _deck.Draw();
                suitValues[(int)(card.Suit - 1)]++;
                faceValues[(int)(card.FaceValue - 1)]++;  
            }

            for (int i = 0; i < 4; i++)
            {
                Assert.Equal(13, suitValues[i]);
            }

            for (int i = 0; i < 13; i++)
            {
                Assert.Equal(4, faceValues[i]);
            }
        }

        /*public void Deck_Filled_With_52_Cards()
        {
            for (int i = 1; i < 52; i++)
            {
                Assert.IsType<BlackJackCard>(_deck.Draw());
            }
        }*/

    }
}
