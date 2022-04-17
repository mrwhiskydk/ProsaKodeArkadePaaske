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
            this.buttonEggBot = new System.Windows.Forms.Button();
            this.buttonEggMid = new System.Windows.Forms.Button();
            this.buttonEggTop = new System.Windows.Forms.Button();
            this.buttonEggBase = new System.Windows.Forms.Button();
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
            this.panelEgg.Size = new System.Drawing.Size(402, 600);
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
            // buttonEggBot
            // 
            this.buttonEggBot.Location = new System.Drawing.Point(472, 546);
            this.buttonEggBot.Name = "buttonEggBot";
            this.buttonEggBot.Size = new System.Drawing.Size(75, 23);
            this.buttonEggBot.TabIndex = 6;
            this.buttonEggBot.Text = "Bot Pattern";
            this.buttonEggBot.UseVisualStyleBackColor = true;
            // 
            // buttonEggMid
            // 
            this.buttonEggMid.Location = new System.Drawing.Point(472, 336);
            this.buttonEggMid.Name = "buttonEggMid";
            this.buttonEggMid.Size = new System.Drawing.Size(78, 23);
            this.buttonEggMid.TabIndex = 5;
            this.buttonEggMid.Text = "Mid Pattern";
            this.buttonEggMid.UseVisualStyleBackColor = true;
            // 
            // buttonEggTop
            // 
            this.buttonEggTop.Location = new System.Drawing.Point(475, 127);
            this.buttonEggTop.Name = "buttonEggTop";
            this.buttonEggTop.Size = new System.Drawing.Size(75, 23);
            this.buttonEggTop.TabIndex = 4;
            this.buttonEggTop.Text = "Top Pattern";
            this.buttonEggTop.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 621);
            this.Controls.Add(this.buttonEggBot);
            this.Controls.Add(this.panelEgg);
            this.Controls.Add(this.buttonEggBase);
            this.Controls.Add(this.buttonEggTop);
            this.Controls.Add(this.buttonEggMid);
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
        private System.Windows.Forms.Button buttonEggBot;
        private System.Windows.Forms.Button buttonEggMid;
        private System.Windows.Forms.Button buttonEggTop;
        private System.Windows.Forms.Button buttonEggBase;
    }
}
