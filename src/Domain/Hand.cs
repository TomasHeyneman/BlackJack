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
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new NotImplementedException();
        }

        public int CalculateValue()
        {
            throw new NotImplementedException();
        } 
        #endregion

    }
}
