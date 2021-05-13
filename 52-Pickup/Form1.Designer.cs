
namespace _52_Pickup
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cardDeck = new System.Windows.Forms.ImageList(this.components);
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardDeck
            // 
            this.cardDeck.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.cardDeck.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardDeck.ImageStream")));
            this.cardDeck.TransparentColor = System.Drawing.Color.Transparent;
            this.cardDeck.Images.SetKeyName(0, "2_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(2, "2_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(3, "2_Spades.bmp");
            this.cardDeck.Images.SetKeyName(4, "3_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(6, "3_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(7, "3_Spades.bmp");
            this.cardDeck.Images.SetKeyName(8, "4_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(10, "4_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(11, "4_Spades.bmp");
            this.cardDeck.Images.SetKeyName(12, "5_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(14, "5_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(15, "5_Spades.bmp");
            this.cardDeck.Images.SetKeyName(16, "6_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(18, "6_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(19, "6_Spades.bmp");
            this.cardDeck.Images.SetKeyName(20, "7_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(22, "7_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(23, "7_Spades.bmp");
            this.cardDeck.Images.SetKeyName(24, "8_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(26, "8_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(27, "8_Spades.bmp");
            this.cardDeck.Images.SetKeyName(28, "9_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(30, "9_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(31, "9_Spades.bmp");
            this.cardDeck.Images.SetKeyName(32, "10_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(34, "10_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(35, "10_Spades.bmp");
            this.cardDeck.Images.SetKeyName(36, "Ace_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(37, "Ace_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(38, "Ace_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(39, "Ace_Spades.bmp");
            this.cardDeck.Images.SetKeyName(40, "Backface_Blue.bmp");
            this.cardDeck.Images.SetKeyName(41, "Backface_Red.bmp");
            this.cardDeck.Images.SetKeyName(42, "Jack_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(43, "Jack_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(44, "Jack_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(45, "Jack_Spades.bmp");
            this.cardDeck.Images.SetKeyName(46, "Joker_Black.bmp");
            this.cardDeck.Images.SetKeyName(47, "Joker_Red.bmp");
            this.cardDeck.Images.SetKeyName(48, "King_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(49, "King_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(50, "King_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(51, "King_Spades.bmp");
            this.cardDeck.Images.SetKeyName(52, "Queen_Clubs.bmp");
            this.cardDeck.Images.SetKeyName(53, "Queen_Diamonds.bmp");
            this.cardDeck.Images.SetKeyName(54, "Queen_Hearts.bmp");
            this.cardDeck.Images.SetKeyName(55, "Queen_Spades.bmp");
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(766, 482);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(118, 23);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "Deal Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeal);
            this.Name = "Main";
            this.Text = "52-Pickup";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList cardDeck;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnClose;
    }
}

