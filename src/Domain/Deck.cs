namespace Domain
{
    public class Deck
    {
        #region Fields
        private Random _random;
        private IList<BlackJackCard> _cards;

        private const int PACK = 52;
        #endregion

        #region Constructors
        public Deck()
        {
            _random = new Random();
            _cards = new List<BlackJackCard>(PACK);

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                foreach (FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                    _cards.Add(new BlackJackCard(suit, faceValue));
            Shuffle();
        }
        #endregion

        #region Methods
        public BlackJackCard Draw()
        {
            if (_cards.Count == 0)
                throw new InvalidOperationException("Deck is empty!!");

            //take the first card of the pack
            BlackJackCard blackjackcard = _cards[0];
            _cards.RemoveAt(0);
            return blackjackcard;

        }

        private void Shuffle()
        {
            //Shuffle the pack few times 
            for (int i = 0; i < _cards.Count * 3; i++)
            {
                int randomPosition = _random.Next(0, _cards.Count);
                var card = _cards[randomPosition];
                _cards.RemoveAt(randomPosition);
                _cards.Add(card);
            } 
            /*throw new NotImplementedException();*/
        } 
        #endregion
    }
}