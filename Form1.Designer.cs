namespace FinalApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDScore = new System.Windows.Forms.Label();
            this.labelPScore = new System.Windows.Forms.Label();
            this.labelDWins = new System.Windows.Forms.Label();
            this.labelPWins = new System.Windows.Forms.Label();
            this.picD1 = new System.Windows.Forms.PictureBox();
            this.picD2 = new System.Windows.Forms.PictureBox();
            this.picD4 = new System.Windows.Forms.PictureBox();
            this.picD3 = new System.Windows.Forms.PictureBox();
            this.picD5 = new System.Windows.Forms.PictureBox();
            this.picP5 = new System.Windows.Forms.PictureBox();
            this.picP4 = new System.Windows.Forms.PictureBox();
            this.picP3 = new System.Windows.Forms.PictureBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.buttonCont = new System.Windows.Forms.Button();
            this.labelRead = new System.Windows.Forms.Label();
            this.labelBust = new System.Windows.Forms.Label();
            this.labelDBusts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(372, 223);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(88, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(175, 345);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(75, 23);
            this.buttonHit.TabIndex = 3;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Visible = false;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // buttonStay
            // 
            this.buttonStay.Location = new System.Drawing.Point(175, 392);
            this.buttonStay.Name = "buttonStay";
            this.buttonStay.Size = new System.Drawing.Size(75, 23);
            this.buttonStay.TabIndex = 4;
            this.buttonStay.Text = "Stay";
            this.buttonStay.UseVisualStyleBackColor = true;
            this.buttonStay.Visible = false;
            this.buttonStay.Click += new System.EventHandler(this.buttonStay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dealers Wins: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Players Wins: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Players Score: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dealers Score: ";
            // 
            // labelDScore
            // 
            this.labelDScore.AutoSize = true;
            this.labelDScore.Location = new System.Drawing.Point(369, 180);
            this.labelDScore.Name = "labelDScore";
            this.labelDScore.Size = new System.Drawing.Size(13, 13);
            this.labelDScore.TabIndex = 17;
            this.labelDScore.Text = "?";
            this.labelDScore.Visible = false;
            // 
            // labelPScore
            // 
            this.labelPScore.AutoSize = true;
            this.labelPScore.Location = new System.Drawing.Point(370, 428);
            this.labelPScore.Name = "labelPScore";
            this.labelPScore.Size = new System.Drawing.Size(13, 13);
            this.labelPScore.TabIndex = 18;
            this.labelPScore.Text = "0";
            this.labelPScore.Visible = false;
            this.labelPScore.Click += new System.EventHandler(this.labelPScore_Click);
            // 
            // labelDWins
            // 
            this.labelDWins.AutoSize = true;
            this.labelDWins.Location = new System.Drawing.Point(93, 195);
            this.labelDWins.Name = "labelDWins";
            this.labelDWins.Size = new System.Drawing.Size(13, 13);
            this.labelDWins.TabIndex = 19;
            this.labelDWins.Text = "0";
            // 
            // labelPWins
            // 
            this.labelPWins.AutoSize = true;
            this.labelPWins.Location = new System.Drawing.Point(92, 220);
            this.labelPWins.Name = "labelPWins";
            this.labelPWins.Size = new System.Drawing.Size(13, 13);
            this.labelPWins.TabIndex = 20;
            this.labelPWins.Text = "0";
            // 
            // picD1
            // 
            this.picD1.Location = new System.Drawing.Point(283, 43);
            this.picD1.Name = "picD1";
            this.picD1.Size = new System.Drawing.Size(79, 117);
            this.picD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD1.TabIndex = 21;
            this.picD1.TabStop = false;
            // 
            // picD2
            // 
            this.picD2.Location = new System.Drawing.Point(392, 43);
            this.picD2.Name = "picD2";
            this.picD2.Size = new System.Drawing.Size(79, 117);
            this.picD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD2.TabIndex = 22;
            this.picD2.TabStop = false;
            // 
            // picD4
            // 
            this.picD4.Location = new System.Drawing.Point(605, 43);
            this.picD4.Name = "picD4";
            this.picD4.Size = new System.Drawing.Size(79, 117);
            this.picD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD4.TabIndex = 24;
            this.picD4.TabStop = false;
            this.picD4.Visible = false;
            // 
            // picD3
            // 
            this.picD3.Location = new System.Drawing.Point(496, 43);
            this.picD3.Name = "picD3";
            this.picD3.Size = new System.Drawing.Size(79, 117);
            this.picD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD3.TabIndex = 23;
            this.picD3.TabStop = false;
            this.picD3.Visible = false;
            // 
            // picD5
            // 
            this.picD5.Location = new System.Drawing.Point(709, 43);
            this.picD5.Name = "picD5";
            this.picD5.Size = new System.Drawing.Size(79, 117);
            this.picD5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD5.TabIndex = 25;
            this.picD5.TabStop = false;
            this.picD5.Visible = false;
            // 
            // picP5
            // 
            this.picP5.Location = new System.Drawing.Point(712, 298);
            this.picP5.Name = "picP5";
            this.picP5.Size = new System.Drawing.Size(79, 117);
            this.picP5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP5.TabIndex = 30;
            this.picP5.TabStop = false;
            this.picP5.Visible = false;
            // 
            // picP4
            // 
            this.picP4.Location = new System.Drawing.Point(608, 298);
            this.picP4.Name = "picP4";
            this.picP4.Size = new System.Drawing.Size(79, 117);
            this.picP4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP4.TabIndex = 29;
            this.picP4.TabStop = false;
            this.picP4.Visible = false;
            // 
            // picP3
            // 
            this.picP3.Location = new System.Drawing.Point(499, 298);
            this.picP3.Name = "picP3";
            this.picP3.Size = new System.Drawing.Size(79, 117);
            this.picP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP3.TabIndex = 28;
            this.picP3.TabStop = false;
            this.picP3.Visible = false;
            // 
            // picP2
            // 
            this.picP2.Location = new System.Drawing.Point(395, 298);
            this.picP2.Name = "picP2";
            this.picP2.Size = new System.Drawing.Size(79, 117);
            this.picP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP2.TabIndex = 27;
            this.picP2.TabStop = false;
            // 
            // picP1
            // 
            this.picP1.Location = new System.Drawing.Point(286, 298);
            this.picP1.Name = "picP1";
            this.picP1.Size = new System.Drawing.Size(79, 117);
            this.picP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP1.TabIndex = 26;
            this.picP1.TabStop = false;
            // 
            // buttonCont
            // 
            this.buttonCont.Location = new System.Drawing.Point(175, 298);
            this.buttonCont.Name = "buttonCont";
            this.buttonCont.Size = new System.Drawing.Size(75, 23);
            this.buttonCont.TabIndex = 31;
            this.buttonCont.Text = "Continue...";
            this.buttonCont.UseVisualStyleBackColor = true;
            this.buttonCont.Visible = false;
            this.buttonCont.Click += new System.EventHandler(this.buttonCont_Click);
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.BackColor = System.Drawing.Color.Yellow;
            this.labelRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRead.Location = new System.Drawing.Point(210, 226);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(81, 20);
            this.labelRead.TabIndex = 32;
            this.labelRead.Text = "You Win!";
            this.labelRead.Visible = false;
            // 
            // labelBust
            // 
            this.labelBust.AutoSize = true;
            this.labelBust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBust.ForeColor = System.Drawing.Color.Maroon;
            this.labelBust.Location = new System.Drawing.Point(401, 423);
            this.labelBust.Name = "labelBust";
            this.labelBust.Size = new System.Drawing.Size(83, 20);
            this.labelBust.TabIndex = 33;
            this.labelBust.Text = "You Bust";
            this.labelBust.Visible = false;
            // 
            // labelDBusts
            // 
            this.labelDBusts.AutoSize = true;
            this.labelDBusts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDBusts.ForeColor = System.Drawing.Color.Maroon;
            this.labelDBusts.Location = new System.Drawing.Point(395, 180);
            this.labelDBusts.Name = "labelDBusts";
            this.labelDBusts.Size = new System.Drawing.Size(113, 20);
            this.labelDBusts.TabIndex = 34;
            this.labelDBusts.Text = "Dealer Busts";
            this.labelDBusts.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDBusts);
            this.Controls.Add(this.labelBust);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.buttonCont);
            this.Controls.Add(this.picP5);
            this.Controls.Add(this.picP4);
            this.Controls.Add(this.picP3);
            this.Controls.Add(this.picP2);
            this.Controls.Add(this.picP1);
            this.Controls.Add(this.picD5);
            this.Controls.Add(this.picD4);
            this.Controls.Add(this.picD3);
            this.Controls.Add(this.picD2);
            this.Controls.Add(this.picD1);
            this.Controls.Add(this.labelPWins);
            this.Controls.Add(this.labelDWins);
            this.Controls.Add(this.labelPScore);
            this.Controls.Add(this.labelDScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStay);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDScore;
        private System.Windows.Forms.Label labelPScore;
        private System.Windows.Forms.Label labelDWins;
        private System.Windows.Forms.Label labelPWins;
        private System.Windows.Forms.PictureBox picD1;
        private System.Windows.Forms.PictureBox picD2;
        private System.Windows.Forms.PictureBox picD4;
        private System.Windows.Forms.PictureBox picD3;
        private System.Windows.Forms.PictureBox picD5;
        private System.Windows.Forms.PictureBox picP5;
        private System.Windows.Forms.PictureBox picP4;
        private System.Windows.Forms.PictureBox picP3;
        private System.Windows.Forms.PictureBox picP2;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.Button buttonCont;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Label labelBust;
        private System.Windows.Forms.Label labelDBusts;
    }
}

