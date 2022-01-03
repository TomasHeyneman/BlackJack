using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BlackJackCard : Card
    {
        #region Properties
        public bool FaceUp { get; private set; } // whether the face of card is visible
        public int Value //the BlackJack value of this card, 0 if the card is not visible
        {     
            get { return FaceUp ? Math.Min(10, (int) FaceValue) : 0; }
        }
        #endregion

        #region Constructor(s)
        public BlackJackCard(Suit suit, FaceValue faceValue)
           : base(suit, faceValue)
        {
            FaceUp = false;
        }
        #endregion

        #region Methods
        public void TurnCard() //makes the card (in)visible
        {
            FaceUp = !FaceUp;
        } 
        #endregion


    }
}
