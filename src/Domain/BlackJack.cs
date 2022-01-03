using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BlackJack
    {
        #region Fields
        public bool FaceDown = false;
        public bool FaceUp = true;
        private readonly Deck _deck;

        #endregion

        #region Properties
        public GameState GameState { get; private set; }
        public Hand DealerHand { get; private set; }
        public Hand PlayerHand { get; private set; }
        #endregion


        #region Constructors
        public BlackJack() : this(new Deck())
        {

        }

        public BlackJack(Deck deck)
        {
            _deck = deck;
            DealerHand = new Hand();
            PlayerHand = new Hand();
            Deal();
        }
        #endregion

        #region Methods
        private void Deal()
        {
            throw new NotImplementedException();
        }

        public void PassToDealer()
        {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard()
        {
            throw new NotImplementedException();
        }

        private void AddCardToHand(Hand hand, bool faceUp)
        {
            throw new NotImplementedException();
        }

        private void AdjustGameState(GameState? gameState = null)
        {
            throw new NotImplementedException();
        }

        private void LetDealerFinalize()
        {
            throw new NotImplementedException();
        }

        public string GameSummary()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
