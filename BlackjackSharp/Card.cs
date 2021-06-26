using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSharp
{
  class Card
  {
    public Suits Suit { get; set; }
    public Values Value { get; set; }
    public bool IsVisible { get; set; } = false;

    public enum Suits
    {
      Spades,
      Hearts,
      Diamonds,
      Clubs
    }
    public enum Values
    {
      Ace = 1,
      Two = 2,
      Three = 3,
      Four = 4,
      Five = 5,
      Six = 6,
      Seven = 7,
      Eight = 8,
      Nine = 9,
      Ten = 10,
      Jack = 11,
      Queen = 12,
      King = 13
    }

    public int Score {
      get {
        switch (Value) {
          case Values.King:
            return 10;
          case Values.Queen:
            return 10;
          case Values.Jack:
            return 10;
          case Values.Ace:
            return 11;
          default:
            return (int)Value;
        }
      }
    }

    public bool IsTenCard {
      get {
        return Value == Values.Ten
           || Value == Values.King
           || Value == Values.Queen
           || Value == Values.Jack;
      }
    }

    public System.Drawing.Bitmap Image {
      get {
        switch ((int)Suit) {
          case 0:
            switch ((int)Value) {
              case 1:
                return Properties.Resources.AS;
              case 2:
                return Properties.Resources._2S;
              case 3:
                return Properties.Resources._3S;
              case 4:
                return Properties.Resources._4S;
              case 5:
                return Properties.Resources._5S;
              case 6:
                return Properties.Resources._6S;
              case 7:
                return Properties.Resources._7S;
              case 8:
                return Properties.Resources._8S;
              case 9:
                return Properties.Resources._9S;
              case 10:
                return Properties.Resources._10S;
              case 11:
                return Properties.Resources.JS;
              case 12:
                return Properties.Resources.QS;
              case 13:
                return Properties.Resources.KS;
              default:
                return Properties.Resources.red_back;
            }
          case 1:
            switch ((int)Value) {
              case 1:
                return Properties.Resources.AH;
              case 2:
                return Properties.Resources._2H;
              case 3:
                return Properties.Resources._3H;
              case 4:
                return Properties.Resources._4H;
              case 5:
                return Properties.Resources._5H;
              case 6:
                return Properties.Resources._6H;
              case 7:
                return Properties.Resources._7H;
              case 8:
                return Properties.Resources._8H;
              case 9:
                return Properties.Resources._9H;
              case 10:
                return Properties.Resources._10H;
              case 11:
                return Properties.Resources.JH;
              case 12:
                return Properties.Resources.QH;
              case 13:
                return Properties.Resources.KH;
              default:
                return Properties.Resources.red_back;
            }
          case 2:
            switch ((int)Value) {
              case 1:
                return Properties.Resources.AD;
              case 2:
                return Properties.Resources._2D;
              case 3:
                return Properties.Resources._3D;
              case 4:
                return Properties.Resources._4D;
              case 5:
                return Properties.Resources._5D;
              case 6:
                return Properties.Resources._6D;
              case 7:
                return Properties.Resources._7D;
              case 8:
                return Properties.Resources._8D;
              case 9:
                return Properties.Resources._9D;
              case 10:
                return Properties.Resources._10D;
              case 11:
                return Properties.Resources.JD;
              case 12:
                return Properties.Resources.QD;
              case 13:
                return Properties.Resources.KD;
              default:
                return Properties.Resources.red_back;
            }
          case 3:
            switch ((int)Value) {
              case 1:
                return Properties.Resources.AC;
              case 2:
                return Properties.Resources._2C;
              case 3:
                return Properties.Resources._3C;
              case 4:
                return Properties.Resources._4C;
              case 5:
                return Properties.Resources._5C;
              case 6:
                return Properties.Resources._6C;
              case 7:
                return Properties.Resources._7C;
              case 8:
                return Properties.Resources._8C;
              case 9:
                return Properties.Resources._9C;
              case 10:
                return Properties.Resources._10C;
              case 11:
                return Properties.Resources.JC;
              case 12:
                return Properties.Resources.QC;
              case 13:
                return Properties.Resources.KC;
              default:
                return Properties.Resources.red_back;
            }
          default:
            return Properties.Resources.red_back;
        }
      }
    }
  }
}
