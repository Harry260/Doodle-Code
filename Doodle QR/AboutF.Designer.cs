namespace Doodle_QR
{
    partial class AboutF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutF));
            this.TitleAF = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // TitleAF
            // 
            this.TitleAF.AutoSize = true;
            this.TitleAF.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleAF.ForeColor = System.Drawing.Color.White;
            this.TitleAF.Location = new System.Drawing.Point(23, 26);
            this.TitleAF.Name = "TitleAF";
            this.TitleAF.Size = new System.Drawing.Size(71, 23);
            this.TitleAF.TabIndex = 0;
            this.TitleAF.Text = "About";
            this.TitleAF.Leave += new System.EventHandler(this.Content_Leave);
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.ForeColor = System.Drawing.Color.White;
            this.Content.Location = new System.Drawing.Point(24, 69);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(395, 146);
            this.Content.TabIndex = 1;
            this.Content.Text = "Doodle Code is a Qr code Encoding and Decoding software for windows 7 and above. " +
    "This software is free to use.\r\n\r\nVersion : 2.0.4 ( UI : 2.0 )\r\nVersion name : Do" +
    "odle Code 4";
            this.Content.Leave += new System.EventHandler(this.Content_Leave);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Gray;
            this.Back.Location = new System.Drawing.Point(360, 226);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 33);
            this.Back.TabIndex = 4;
            this.Back.Text = " &Done";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AboutF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(431, 271);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.TitleAF);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 271);
            this.MinimizeBox = false;
            this.Name = "AboutF";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutF_Load);
            this.Leave += new System.EventHandler(this.Content_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleAF;
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}