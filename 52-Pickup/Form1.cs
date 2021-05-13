using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52_Pickup
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int xPos = 5;
            int yPos = 50;

            resetDeck();

            foreach(string cCard in cardDeck.Images.Keys)
            {
                PictureBox newCard = new PictureBox();
                newCard.Image = cardDeck.Images[cCard];
                newCard.Width = 50;
                newCard.Height = 70;
                newCard.Name = cCard;
                newCard.Location = new Point(xPos, yPos);
                this.Controls.Add(newCard);
                newCard.BringToFront();
                newCard.DoubleClick += pbSelect_DoubleClick;

                xPos += 15;
            }


        }

        private void resetDeckWrong()
        {
            foreach (Control cCont in this.Controls)
            {
                Type tp = cCont.GetType();

                if (tp.Equals(typeof(PictureBox)))
                {
                    this.Controls.Remove(cCont);
                }
            }
        }

        private void resetDeck()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Type tp = this.Controls[i].GetType();

                if (tp.Equals(typeof(PictureBox)))
                {
                    this.Controls.Remove(this.Controls[i]);
                }
            }
        }

        private void pbSelect_DoubleClick(object sender, EventArgs e)
        {
            // Get a reference to the current PictureBox.
            // Change the location of the control.

            PictureBox currentBox = (PictureBox)sender;
            Point oldLoc = currentBox.Location;
            currentBox.Location = new Point(oldLoc.X, oldLoc.Y += 100);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
