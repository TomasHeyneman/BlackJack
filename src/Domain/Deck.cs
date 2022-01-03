namespace Domain
{
    public class Deck
    {
        #region Fields
        private static readonly Random _random = new Random();
        private IList<BlackJackCard> _cards;
        #endregion

        #region Constructors
        public Deck()
        {
            _cards = new List<BlackJackCard>();
            Shuffle();
        }
        #endregion

        #region Methods
        public BlackJackCard Draw()
        {
            throw new NotImplementedException();
        }

        private void Shuffle()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}