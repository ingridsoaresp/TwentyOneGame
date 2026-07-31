namespace TwentyOneGame
{
    partial class TwentyOneGame
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
            this.RollBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Dice1Lbl = new System.Windows.Forms.Label();
            this.Dice2Lbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.Dice1Pic = new System.Windows.Forms.PictureBox();
            this.Dice2Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // RollBtn
            // 
            this.RollBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollBtn.Location = new System.Drawing.Point(93, 22);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(136, 50);
            this.RollBtn.TabIndex = 0;
            this.RollBtn.Text = "Roll";
            this.RollBtn.UseVisualStyleBackColor = false;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Yellow;
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(93, 291);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(136, 50);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "Play Again";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(93, 361);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(136, 35);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Dice1Lbl
            // 
            this.Dice1Lbl.AutoSize = true;
            this.Dice1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice1Lbl.ForeColor = System.Drawing.Color.Blue;
            this.Dice1Lbl.Location = new System.Drawing.Point(59, 104);
            this.Dice1Lbl.Name = "Dice1Lbl";
            this.Dice1Lbl.Size = new System.Drawing.Size(87, 29);
            this.Dice1Lbl.TabIndex = 3;
            this.Dice1Lbl.Text = "Dice 1";
            // 
            // Dice2Lbl
            // 
            this.Dice2Lbl.AutoSize = true;
            this.Dice2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice2Lbl.ForeColor = System.Drawing.Color.Blue;
            this.Dice2Lbl.Location = new System.Drawing.Point(183, 104);
            this.Dice2Lbl.Name = "Dice2Lbl";
            this.Dice2Lbl.Size = new System.Drawing.Size(87, 29);
            this.Dice2Lbl.TabIndex = 4;
            this.Dice2Lbl.Text = "Dice 2";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.Red;
            this.TotalLbl.Location = new System.Drawing.Point(122, 241);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(73, 29);
            this.TotalLbl.TabIndex = 5;
            this.TotalLbl.Text = "Total";
            // 
            // Dice1Pic
            // 
            this.Dice1Pic.Location = new System.Drawing.Point(51, 136);
            this.Dice1Pic.Name = "Dice1Pic";
            this.Dice1Pic.Size = new System.Drawing.Size(95, 90);
            this.Dice1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice1Pic.TabIndex = 6;
            this.Dice1Pic.TabStop = false;
            // 
            // Dice2Pic
            // 
            this.Dice2Pic.Location = new System.Drawing.Point(175, 136);
            this.Dice2Pic.Name = "Dice2Pic";
            this.Dice2Pic.Size = new System.Drawing.Size(95, 90);
            this.Dice2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice2Pic.TabIndex = 7;
            this.Dice2Pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 435);
            this.Controls.Add(this.Dice2Pic);
            this.Controls.Add(this.Dice1Pic);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.Dice2Lbl);
            this.Controls.Add(this.Dice1Lbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.RollBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dice1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Dice1Lbl;
        private System.Windows.Forms.Label Dice2Lbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.PictureBox Dice1Pic;
        private System.Windows.Forms.PictureBox Dice2Pic;
    }
}

