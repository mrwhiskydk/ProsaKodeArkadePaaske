namespace ProsaKodeArkadePåske
{
    partial class Form1
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
            this.panelEgg = new System.Windows.Forms.Panel();
            this.pictureBoxEggBot = new System.Windows.Forms.PictureBox();
            this.pictureBoxEggMid = new System.Windows.Forms.PictureBox();
            this.pictureBoxEggTop = new System.Windows.Forms.PictureBox();
            this.buttonEggBotPattern = new System.Windows.Forms.Button();
            this.buttonEggMidPattern = new System.Windows.Forms.Button();
            this.buttonEggTopPattern = new System.Windows.Forms.Button();
            this.buttonEggBase = new System.Windows.Forms.Button();
            this.buttonEggTopColor = new System.Windows.Forms.Button();
            this.buttonEggMidColor = new System.Windows.Forms.Button();
            this.buttonEggBotColor = new System.Windows.Forms.Button();
            this.panelEgg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEggBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEggMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEggTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEgg
            // 
            this.panelEgg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelEgg.Controls.Add(this.pictureBoxEggBot);
            this.panelEgg.Controls.Add(this.pictureBoxEggMid);
            this.panelEgg.Controls.Add(this.pictureBoxEggTop);
            this.panelEgg.Location = new System.Drawing.Point(31, 12);
            this.panelEgg.Name = "panelEgg";
            this.panelEgg.Size = new System.Drawing.Size(400, 600);
            this.panelEgg.TabIndex = 0;
            // 
            // pictureBoxEggBot
            // 
            this.pictureBoxEggBot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEggBot.Location = new System.Drawing.Point(0, 350);
            this.pictureBoxEggBot.Name = "pictureBoxEggBot";
            this.pictureBoxEggBot.Size = new System.Drawing.Size(400, 250);
            this.pictureBoxEggBot.TabIndex = 2;
            this.pictureBoxEggBot.TabStop = false;
            // 
            // pictureBoxEggMid
            // 
            this.pictureBoxEggMid.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEggMid.Location = new System.Drawing.Point(0, 250);
            this.pictureBoxEggMid.Name = "pictureBoxEggMid";
            this.pictureBoxEggMid.Size = new System.Drawing.Size(400, 100);
            this.pictureBoxEggMid.TabIndex = 1;
            this.pictureBoxEggMid.TabStop = false;
            // 
            // pictureBoxEggTop
            // 
            this.pictureBoxEggTop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEggTop.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEggTop.Name = "pictureBoxEggTop";
            this.pictureBoxEggTop.Size = new System.Drawing.Size(400, 250);
            this.pictureBoxEggTop.TabIndex = 0;
            this.pictureBoxEggTop.TabStop = false;
            // 
            // buttonEggBotPattern
            // 
            this.buttonEggBotPattern.Location = new System.Drawing.Point(472, 474);
            this.buttonEggBotPattern.Name = "buttonEggBotPattern";
            this.buttonEggBotPattern.Size = new System.Drawing.Size(75, 23);
            this.buttonEggBotPattern.TabIndex = 6;
            this.buttonEggBotPattern.Text = "Pattern";
            this.buttonEggBotPattern.UseVisualStyleBackColor = true;
            this.buttonEggBotPattern.Click += new System.EventHandler(this.buttonEggBotPattern_Click);
            // 
            // buttonEggMidPattern
            // 
            this.buttonEggMidPattern.Location = new System.Drawing.Point(472, 281);
            this.buttonEggMidPattern.Name = "buttonEggMidPattern";
            this.buttonEggMidPattern.Size = new System.Drawing.Size(78, 23);
            this.buttonEggMidPattern.TabIndex = 5;
            this.buttonEggMidPattern.Text = "Pattern";
            this.buttonEggMidPattern.UseVisualStyleBackColor = true;
            this.buttonEggMidPattern.Click += new System.EventHandler(this.buttonEggMidPattern_Click);
            // 
            // buttonEggTopPattern
            // 
            this.buttonEggTopPattern.Location = new System.Drawing.Point(475, 127);
            this.buttonEggTopPattern.Name = "buttonEggTopPattern";
            this.buttonEggTopPattern.Size = new System.Drawing.Size(75, 23);
            this.buttonEggTopPattern.TabIndex = 4;
            this.buttonEggTopPattern.Text = "Pattern";
            this.buttonEggTopPattern.UseVisualStyleBackColor = true;
            this.buttonEggTopPattern.Click += new System.EventHandler(this.buttonEggTopPattern_Click);
            // 
            // buttonEggBase
            // 
            this.buttonEggBase.Location = new System.Drawing.Point(475, 12);
            this.buttonEggBase.Name = "buttonEggBase";
            this.buttonEggBase.Size = new System.Drawing.Size(75, 23);
            this.buttonEggBase.TabIndex = 3;
            this.buttonEggBase.Text = "Base Color";
            this.buttonEggBase.UseVisualStyleBackColor = true;
            this.buttonEggBase.Click += new System.EventHandler(this.buttonEggBase_Click);
            // 
            // buttonEggTopColor
            // 
            this.buttonEggTopColor.Location = new System.Drawing.Point(477, 165);
            this.buttonEggTopColor.Name = "buttonEggTopColor";
            this.buttonEggTopColor.Size = new System.Drawing.Size(75, 23);
            this.buttonEggTopColor.TabIndex = 7;
            this.buttonEggTopColor.Text = "Color";
            this.buttonEggTopColor.UseVisualStyleBackColor = true;
            this.buttonEggTopColor.Click += new System.EventHandler(this.buttonEggTopColor_Click);
            // 
            // buttonEggMidColor
            // 
            this.buttonEggMidColor.Location = new System.Drawing.Point(472, 323);
            this.buttonEggMidColor.Name = "buttonEggMidColor";
            this.buttonEggMidColor.Size = new System.Drawing.Size(75, 23);
            this.buttonEggMidColor.TabIndex = 8;
            this.buttonEggMidColor.Text = "Color";
            this.buttonEggMidColor.UseVisualStyleBackColor = true;
            this.buttonEggMidColor.Click += new System.EventHandler(this.buttonEggMidColor_Click);
            // 
            // buttonEggBotColor
            // 
            this.buttonEggBotColor.Location = new System.Drawing.Point(472, 517);
            this.buttonEggBotColor.Name = "buttonEggBotColor";
            this.buttonEggBotColor.Size = new System.Drawing.Size(75, 23);
            this.buttonEggBotColor.TabIndex = 9;
            this.buttonEggBotColor.Text = "Color";
            this.buttonEggBotColor.UseVisualStyleBackColor = true;
            this.buttonEggBotColor.Click += new System.EventHandler(this.buttonEggBotColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 621);
            this.Controls.Add(this.buttonEggBotColor);
            this.Controls.Add(this.buttonEggMidColor);
            this.Controls.Add(this.buttonEggTopColor);
            this.Controls.Add(this.buttonEggBotPattern);
            this.Controls.Add(this.panelEgg);
            this.Controls.Add(this.buttonEggBase);
            this.Controls.Add(this.buttonEggTopPattern);
            this.Controls.Add(this.buttonEggMidPattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEgg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEggBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEggMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEggTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEgg;
        private System.Windows.Forms.PictureBox pictureBoxEggTop;
        private System.Windows.Forms.PictureBox pictureBoxEggBot;
        private System.Windows.Forms.PictureBox pictureBoxEggMid;
        private System.Windows.Forms.Button buttonEggBotPattern;
        private System.Windows.Forms.Button buttonEggMidPattern;
        private System.Windows.Forms.Button buttonEggTopPattern;
        private System.Windows.Forms.Button buttonEggBase;
        private System.Windows.Forms.Button buttonEggTopColor;
        private System.Windows.Forms.Button buttonEggMidColor;
        private System.Windows.Forms.Button buttonEggBotColor;
    }
}
