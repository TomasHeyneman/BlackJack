using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Card
    {
        #region Properties
        public FaceValue FaceValue { get; }

        public Suit Suit { get; set; }
        #endregion

        #region Constructors
        public Card(Suit suit, FaceValue faceValue)
        {
            Suit = Suit;
            FaceValue = faceValue;
        } 
        #endregion
    }
}
