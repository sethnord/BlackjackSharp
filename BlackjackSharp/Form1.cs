using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackSharp
{
  public partial class Form1 : Form
  {
    Deck _deck;
    public Form1()
    {
      InitializeComponent();
    }

    private void NewDeckDebug_Click(object sender, EventArgs e)
    {
      ClearTable();
      Deck _deck = new Deck();
    }

    private void DealDebug_Click(object sender, EventArgs e)
    {
      StartDeal();
    }

    private void ClearTable()
    {
      player1Card1.Visible = false;
      player1Card2.Visible = false;
      player1Card3.Visible = false;
      player1Card4.Visible = false;
      player1Card5.Visible = false;
      player2Card1.Visible = false;
      player2Card2.Visible = false;
      player2Card3.Visible = false;
      player2Card4.Visible = false;
      player2Card5.Visible = false;
      dealerCard1.Visible = false;
      dealerCard2.Visible = false;
    }

    private void StartDeal()
    {
      //Deal starts with player 1, then 2, then dealer. Each player gets two cards. Dealer second card is face-up.
      //Dealing positions:
      //0=Dealer
      //1=Player1
      //2=Player2
      //3=Player3
      //4=Player4
      ClearTable();
      Card card = Deck.DealCard();
      player1Card1.Visible = true;
      player1Card1.Image = card.Image;
    }
  }
}
