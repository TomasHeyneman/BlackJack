using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hand
    {

        #region Fields
        private readonly IList<BlackJackCard> _cards;
        #endregion

        #region Properties
        //returns the player's cards
        public IEnumerable<BlackJackCard> Cards { get { return _cards; } }
        //NrOfCards
        public int NrOfCards { get { return Cards.Count(); } }
        //Value
        public int Value { get { return CalculateValue(); } }
        #endregion

        #region Constructors
        public Hand()
        {
            _cards = new List<BlackJackCard>();
        }
        #endregion

        #region Methods
        public void AddCard(BlackJackCard card)
        {
            if(card != null)
                _cards.Add(card);
        }

        public void TurnAllCardsFaceUp()
        {
              
            foreach (BlackJackCard card in _cards)
                if(!card.FaceUp)
                    card.TurnCard();
        }

        public int CalculateValue()
        {
            int sum = 0;
            bool hasAce = false;

            foreach (var card in Cards)
            {
                sum += card.Value;
                if (card.FaceUp && card.FaceValue == FaceValue.Ace)
                    hasAce = true;
            }

            if (hasAce && (sum + 10) <= 21)
                sum += 10;

            return sum;
        }
        #endregion

    }
}
