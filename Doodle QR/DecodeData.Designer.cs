namespace Doodle_QR
{
    partial class DecodeData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecodeData));
            this.T = new System.Windows.Forms.Panel();
            this.Title1 = new System.Windows.Forms.Label();
            this.Gsearch = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SaveTxt = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Cdock = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Label();
            this.Sizer = new System.Windows.Forms.Timer(this.components);
            this.DragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.T.SuspendLayout();
            this.Cdock.SuspendLayout();
            this.SuspendLayout();
            // 
            // T
            // 
            this.T.Controls.Add(this.Title1);
            this.T.Controls.Add(this.Gsearch);
            this.T.Controls.Add(this.CloseBtn);
            this.T.Controls.Add(this.SaveTxt);
            this.T.Controls.Add(this.Copy);
            this.T.Dock = System.Windows.Forms.DockStyle.Top;
            this.T.Location = new System.Drawing.Point(0, 0);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(517, 72);
            this.T.TabIndex = 2;
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Location = new System.Drawing.Point(12, 25);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(95, 23);
            this.Title1.TabIndex = 5;
            this.Title1.Text = "Decoder";
            // 
            // Gsearch
            // 
            this.Gsearch.BackColor = System.Drawing.Color.Black;
            this.Gsearch.FlatAppearance.BorderSize = 0;
            this.Gsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Gsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Gsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gsearch.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gsearch.ForeColor = System.Drawing.Color.Gray;
            this.Gsearch.Location = new System.Drawing.Point(268, 22);
            this.Gsearch.Name = "Gsearch";
            this.Gsearch.Size = new System.Drawing.Size(172, 33);
            this.Gsearch.TabIndex = 4;
            this.Gsearch.Text = " Google Search";
            this.Gsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gsearch.UseVisualStyleBackColor = false;
            this.Gsearch.Click += new System.EventHandler(this.Gsearch_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Black;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Gray;
            this.CloseBtn.Location = new System.Drawing.Point(446, 22);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(59, 33);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveTxt
            // 
            this.SaveTxt.BackColor = System.Drawing.Color.Black;
            this.SaveTxt.FlatAppearance.BorderSize = 0;
            this.SaveTxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SaveTxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SaveTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTxt.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTxt.ForeColor = System.Drawing.Color.Gray;
            this.SaveTxt.Location = new System.Drawing.Point(203, 22);
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.Size = new System.Drawing.Size(59, 33);
            this.SaveTxt.TabIndex = 4;
            this.SaveTxt.Text = " Save";
            this.SaveTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveTxt.UseVisualStyleBackColor = false;
            this.SaveTxt.Click += new System.EventHandler(this.SaveTxt_Click);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.Black;
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.Color.Gray;
            this.Copy.Location = new System.Drawing.Point(122, 22);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 33);
            this.Copy.TabIndex = 4;
            this.Copy.Text = " Copy";
            this.Copy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Cdock
            // 
            this.Cdock.BackColor = System.Drawing.Color.Transparent;
            this.Cdock.Controls.Add(this.Data);
            this.Cdock.Location = new System.Drawing.Point(12, 78);
            this.Cdock.Name = "Cdock";
            this.Cdock.Size = new System.Drawing.Size(493, 260);
            this.Cdock.TabIndex = 3;
            // 
            // Data
            // 
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.White;
            this.Data.Location = new System.Drawing.Point(0, 0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(493, 260);
            this.Data.TabIndex = 0;
            this.Data.Text = "Couldn\'t Decode";
            // 
            // Sizer
            // 
            this.Sizer.Enabled = true;
            this.Sizer.Interval = 1;
            this.Sizer.Tick += new System.EventHandler(this.Sizer_Tick);
            // 
            // DragControl1
            // 
            this.DragControl1.Fixed = true;
            this.DragControl1.Horizontal = true;
            this.DragControl1.TargetControl = this.T;
            this.DragControl1.Vertical = true;
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.Title1;
            this.DragControl2.Vertical = true;
            // 
            // DecodeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(517, 350);
            this.Controls.Add(this.Cdock);
            this.Controls.Add(this.T);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(517, 350);
            this.Name = "DecodeData";
            this.Text = "DecodeData";
            this.Load += new System.EventHandler(this.DecodeData_Load);
            this.T.ResumeLayout(false);
            this.T.PerformLayout();
            this.Cdock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel T;
        private System.Windows.Forms.Panel Cdock;
        private System.Windows.Forms.Timer Sizer;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Button Gsearch;
        private System.Windows.Forms.Button SaveTxt;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label Title1;
        private Bunifu.Framework.UI.BunifuDragControl DragControl1;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
    }
}