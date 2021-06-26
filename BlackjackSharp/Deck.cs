using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackSharp
{
  class Deck
  {
    public static List<Card> _deckList = new List<Card>();
    private static Random _rng = new Random();

    public Deck()
    {
      GetNew();
    }

    public void GetNew()
    {
      _deckList.Clear();
      for (int s = 0; s <= 3; s++) {
        for (int v = 1; v <= 13; v++) {
          Card newCard = new Card();
          newCard.Value = (Card.Values)v;
          newCard.Suit = (Card.Suits)s;
          _deckList.Add(newCard);
        }
      }
      Shuffle();
    }

    public void Shuffle()
    {
      //Rearrange the elements of the list in a random order
      _deckList.OrderBy(a => _rng.Next()).ToList(); //https://stackoverflow.com/questions/273313/randomize-a-listt/4262134#4262134
    }

    public static Card DealCard()
    {
      Card newCard = _deckList.First();
      _deckList.Remove(newCard);
      return newCard;
    }
  }
}
