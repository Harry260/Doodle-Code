namespace Doodle_QR
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Title_txt = new System.Windows.Forms.Label();
            this.Encode = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.RecentPanel_1 = new System.Windows.Forms.Panel();
            this.StatRecent_1 = new System.Windows.Forms.Label();
            this.TitleRecent_1 = new System.Windows.Forms.Label();
            this.Recent_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Encode_lbl = new System.Windows.Forms.Label();
            this.Decode_lbl = new System.Windows.Forms.Label();
            this.RecentPanel_2 = new System.Windows.Forms.Panel();
            this.StatRecent_2 = new System.Windows.Forms.Label();
            this.TitleRecent_2 = new System.Windows.Forms.Label();
            this.RecentPanel_3 = new System.Windows.Forms.Panel();
            this.StatRecent_3 = new System.Windows.Forms.Label();
            this.TitleRecent_3 = new System.Windows.Forms.Label();
            this.Hi_lbl = new System.Windows.Forms.Label();
            this.Auto = new System.Windows.Forms.Timer(this.components);
            this.E_panel = new System.Windows.Forms.Panel();
            this.Preview = new Guna.UI.WinForms.GunaShadowPanel();
            this.PrePic = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.Preview_btn = new System.Windows.Forms.Button();
            this.SaveQr_btn = new System.Windows.Forms.Button();
            this.Encode_txt = new System.Windows.Forms.RichTextBox();
            this.Encode_title = new System.Windows.Forms.Label();
            this.DragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Mpnl = new Guna.UI.WinForms.GunaShadowPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.CloseClick = new Bunifu.Framework.UI.BunifuImageButton();
            this.Menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.RecentPanel_1.SuspendLayout();
            this.RecentPanel_2.SuspendLayout();
            this.RecentPanel_3.SuspendLayout();
            this.E_panel.SuspendLayout();
            this.Preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrePic)).BeginInit();
            this.Mpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_txt
            // 
            this.Title_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_txt.ForeColor = System.Drawing.Color.White;
            this.Title_txt.Location = new System.Drawing.Point(43, 9);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(201, 20);
            this.Title_txt.TabIndex = 1;
            this.Title_txt.Text = "Doodle Code 4";
            // 
            // Encode
            // 
            this.Encode.BackColor = System.Drawing.Color.Black;
            this.Encode.FlatAppearance.BorderSize = 0;
            this.Encode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Encode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encode.ForeColor = System.Drawing.Color.Gray;
            this.Encode.Location = new System.Drawing.Point(15, 155);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(103, 35);
            this.Encode.TabIndex = 2;
            this.Encode.Text = "Encode";
            this.Encode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Encode.UseVisualStyleBackColor = false;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Decode
            // 
            this.Decode.BackColor = System.Drawing.Color.Black;
            this.Decode.FlatAppearance.BorderSize = 0;
            this.Decode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Decode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decode.ForeColor = System.Drawing.Color.Gray;
            this.Decode.Location = new System.Drawing.Point(12, 243);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(103, 35);
            this.Decode.TabIndex = 2;
            this.Decode.Text = "Decode";
            this.Decode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Decode.UseVisualStyleBackColor = false;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // RecentPanel_1
            // 
            this.RecentPanel_1.BackColor = System.Drawing.Color.Black;
            this.RecentPanel_1.Controls.Add(this.StatRecent_1);
            this.RecentPanel_1.Controls.Add(this.TitleRecent_1);
            this.RecentPanel_1.Location = new System.Drawing.Point(203, 93);
            this.RecentPanel_1.Name = "RecentPanel_1";
            this.RecentPanel_1.Size = new System.Drawing.Size(290, 72);
            this.RecentPanel_1.TabIndex = 3;
            this.RecentPanel_1.Click += new System.EventHandler(this.RecentPanel_1_Click);
            this.RecentPanel_1.MouseLeave += new System.EventHandler(this.TitleRecent_1_MouseLeave);
            this.RecentPanel_1.MouseHover += new System.EventHandler(this.RecentPanel_1_MouseHover);
            // 
            // StatRecent_1
            // 
            this.StatRecent_1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatRecent_1.ForeColor = System.Drawing.Color.White;
            this.StatRecent_1.Location = new System.Drawing.Point(8, 31);
            this.StatRecent_1.Name = "StatRecent_1";
            this.StatRecent_1.Size = new System.Drawing.Size(279, 25);
            this.StatRecent_1.TabIndex = 0;
            this.StatRecent_1.Click += new System.EventHandler(this.RecentPanel_1_Click);
            this.StatRecent_1.MouseLeave += new System.EventHandler(this.TitleRecent_1_MouseLeave);
            this.StatRecent_1.MouseHover += new System.EventHandler(this.RecentPanel_1_MouseHover);
            // 
            // TitleRecent_1
            // 
            this.TitleRecent_1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRecent_1.ForeColor = System.Drawing.Color.White;
            this.TitleRecent_1.Location = new System.Drawing.Point(7, 9);
            this.TitleRecent_1.Name = "TitleRecent_1";
            this.TitleRecent_1.Size = new System.Drawing.Size(279, 25);
            this.TitleRecent_1.TabIndex = 0;
            this.TitleRecent_1.Click += new System.EventHandler(this.RecentPanel_1_Click);
            this.TitleRecent_1.MouseLeave += new System.EventHandler(this.TitleRecent_1_MouseLeave);
            this.TitleRecent_1.MouseHover += new System.EventHandler(this.RecentPanel_1_MouseHover);
            // 
            // Recent_lbl
            // 
            this.Recent_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recent_lbl.ForeColor = System.Drawing.Color.White;
            this.Recent_lbl.Location = new System.Drawing.Point(203, 61);
            this.Recent_lbl.Name = "Recent_lbl";
            this.Recent_lbl.Size = new System.Drawing.Size(201, 20);
            this.Recent_lbl.TabIndex = 4;
            this.Recent_lbl.Text = "Recent";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 66);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nothing was recently Encoded or Decoded. Your recent activities will be visible h" +
    "ere.";
            // 
            // Encode_lbl
            // 
            this.Encode_lbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encode_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Encode_lbl.Location = new System.Drawing.Point(12, 193);
            this.Encode_lbl.Name = "Encode_lbl";
            this.Encode_lbl.Size = new System.Drawing.Size(157, 40);
            this.Encode_lbl.TabIndex = 6;
            this.Encode_lbl.Text = "Create stunning QR codes in seconds!";
            // 
            // Decode_lbl
            // 
            this.Decode_lbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decode_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Decode_lbl.Location = new System.Drawing.Point(12, 281);
            this.Decode_lbl.Name = "Decode_lbl";
            this.Decode_lbl.Size = new System.Drawing.Size(157, 40);
            this.Decode_lbl.TabIndex = 6;
            this.Decode_lbl.Text = "Convert QR code images to text without any effort\r\n\r\n";
            // 
            // RecentPanel_2
            // 
            this.RecentPanel_2.BackColor = System.Drawing.Color.Black;
            this.RecentPanel_2.Controls.Add(this.StatRecent_2);
            this.RecentPanel_2.Controls.Add(this.TitleRecent_2);
            this.RecentPanel_2.Location = new System.Drawing.Point(203, 171);
            this.RecentPanel_2.Name = "RecentPanel_2";
            this.RecentPanel_2.Size = new System.Drawing.Size(290, 72);
            this.RecentPanel_2.TabIndex = 4;
            this.RecentPanel_2.Click += new System.EventHandler(this.RecentPanel_2_Click);
            this.RecentPanel_2.MouseLeave += new System.EventHandler(this.TitleRecent_2_MouseLeave);
            this.RecentPanel_2.MouseHover += new System.EventHandler(this.TitleRecent_2_MouseHover);
            // 
            // StatRecent_2
            // 
            this.StatRecent_2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatRecent_2.ForeColor = System.Drawing.Color.White;
            this.StatRecent_2.Location = new System.Drawing.Point(8, 31);
            this.StatRecent_2.Name = "StatRecent_2";
            this.StatRecent_2.Size = new System.Drawing.Size(279, 25);
            this.StatRecent_2.TabIndex = 0;
            this.StatRecent_2.Click += new System.EventHandler(this.RecentPanel_2_Click);
            this.StatRecent_2.MouseLeave += new System.EventHandler(this.TitleRecent_2_MouseLeave);
            this.StatRecent_2.MouseHover += new System.EventHandler(this.TitleRecent_2_MouseHover);
            // 
            // TitleRecent_2
            // 
            this.TitleRecent_2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRecent_2.ForeColor = System.Drawing.Color.White;
            this.TitleRecent_2.Location = new System.Drawing.Point(7, 9);
            this.TitleRecent_2.Name = "TitleRecent_2";
            this.TitleRecent_2.Size = new System.Drawing.Size(279, 25);
            this.TitleRecent_2.TabIndex = 0;
            this.TitleRecent_2.Click += new System.EventHandler(this.RecentPanel_2_Click);
            this.TitleRecent_2.MouseLeave += new System.EventHandler(this.TitleRecent_2_MouseLeave);
            this.TitleRecent_2.MouseHover += new System.EventHandler(this.TitleRecent_2_MouseHover);
            // 
            // RecentPanel_3
            // 
            this.RecentPanel_3.BackColor = System.Drawing.Color.Black;
            this.RecentPanel_3.Controls.Add(this.StatRecent_3);
            this.RecentPanel_3.Controls.Add(this.TitleRecent_3);
            this.RecentPanel_3.Location = new System.Drawing.Point(203, 249);
            this.RecentPanel_3.Name = "RecentPanel_3";
            this.RecentPanel_3.Size = new System.Drawing.Size(290, 72);
            this.RecentPanel_3.TabIndex = 4;
            this.RecentPanel_3.Click += new System.EventHandler(this.TitleRecent_3_Click);
            this.RecentPanel_3.MouseLeave += new System.EventHandler(this.TitleRecent_3_MouseLeave);
            this.RecentPanel_3.MouseHover += new System.EventHandler(this.TitleRecent_3_MouseHover);
            // 
            // StatRecent_3
            // 
            this.StatRecent_3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatRecent_3.ForeColor = System.Drawing.Color.White;
            this.StatRecent_3.Location = new System.Drawing.Point(8, 31);
            this.StatRecent_3.Name = "StatRecent_3";
            this.StatRecent_3.Size = new System.Drawing.Size(279, 25);
            this.StatRecent_3.TabIndex = 0;
            this.StatRecent_3.Click += new System.EventHandler(this.TitleRecent_3_Click);
            this.StatRecent_3.MouseLeave += new System.EventHandler(this.TitleRecent_3_MouseLeave);
            this.StatRecent_3.MouseHover += new System.EventHandler(this.TitleRecent_3_MouseHover);
            // 
            // TitleRecent_3
            // 
            this.TitleRecent_3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRecent_3.ForeColor = System.Drawing.Color.White;
            this.TitleRecent_3.Location = new System.Drawing.Point(7, 9);
            this.TitleRecent_3.Name = "TitleRecent_3";
            this.TitleRecent_3.Size = new System.Drawing.Size(279, 25);
            this.TitleRecent_3.TabIndex = 0;
            this.TitleRecent_3.Click += new System.EventHandler(this.TitleRecent_3_Click);
            this.TitleRecent_3.MouseLeave += new System.EventHandler(this.TitleRecent_3_MouseLeave);
            this.TitleRecent_3.MouseHover += new System.EventHandler(this.TitleRecent_3_MouseHover);
            // 
            // Hi_lbl
            // 
            this.Hi_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hi_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.Hi_lbl.Location = new System.Drawing.Point(8, 61);
            this.Hi_lbl.Name = "Hi_lbl";
            this.Hi_lbl.Size = new System.Drawing.Size(157, 48);
            this.Hi_lbl.TabIndex = 4;
            this.Hi_lbl.Text = "Hi Dude, What are you gonna do";
            // 
            // Auto
            // 
            this.Auto.Enabled = true;
            this.Auto.Interval = 1;
            this.Auto.Tick += new System.EventHandler(this.Auto_Tick);
            // 
            // E_panel
            // 
            this.E_panel.Controls.Add(this.Preview);
            this.E_panel.Controls.Add(this.Back);
            this.E_panel.Controls.Add(this.Preview_btn);
            this.E_panel.Controls.Add(this.SaveQr_btn);
            this.E_panel.Controls.Add(this.Encode_txt);
            this.E_panel.Controls.Add(this.Encode_title);
            this.E_panel.Location = new System.Drawing.Point(2, 1);
            this.E_panel.Name = "E_panel";
            this.E_panel.Size = new System.Drawing.Size(513, 347);
            this.E_panel.TabIndex = 7;
            this.E_panel.Visible = false;
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.Color.Transparent;
            this.Preview.BaseColor = System.Drawing.Color.White;
            this.Preview.Controls.Add(this.PrePic);
            this.Preview.Location = new System.Drawing.Point(156, 83);
            this.Preview.Name = "Preview";
            this.Preview.ShadowColor = System.Drawing.Color.Black;
            this.Preview.Size = new System.Drawing.Size(200, 200);
            this.Preview.TabIndex = 4;
            this.Preview.Visible = false;
            // 
            // PrePic
            // 
            this.PrePic.Location = new System.Drawing.Point(17, 12);
            this.PrePic.Name = "PrePic";
            this.PrePic.Size = new System.Drawing.Size(167, 170);
            this.PrePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrePic.TabIndex = 0;
            this.PrePic.TabStop = false;
            this.PrePic.MouseLeave += new System.EventHandler(this.PrePic_MouseLeave);
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
            this.Back.Location = new System.Drawing.Point(293, 11);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 33);
            this.Back.TabIndex = 3;
            this.Back.Text = " &Back";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Preview_btn
            // 
            this.Preview_btn.BackColor = System.Drawing.Color.Black;
            this.Preview_btn.FlatAppearance.BorderSize = 0;
            this.Preview_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Preview_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preview_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Preview_btn.Location = new System.Drawing.Point(358, 11);
            this.Preview_btn.Name = "Preview_btn";
            this.Preview_btn.Size = new System.Drawing.Size(77, 33);
            this.Preview_btn.TabIndex = 3;
            this.Preview_btn.Text = " &Preview";
            this.Preview_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Preview_btn.UseVisualStyleBackColor = false;
            this.Preview_btn.Click += new System.EventHandler(this.Preview_btn_Click);
            // 
            // SaveQr_btn
            // 
            this.SaveQr_btn.BackColor = System.Drawing.Color.Black;
            this.SaveQr_btn.FlatAppearance.BorderSize = 0;
            this.SaveQr_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SaveQr_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SaveQr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQr_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQr_btn.ForeColor = System.Drawing.Color.Gray;
            this.SaveQr_btn.Location = new System.Drawing.Point(441, 11);
            this.SaveQr_btn.Name = "SaveQr_btn";
            this.SaveQr_btn.Size = new System.Drawing.Size(62, 33);
            this.SaveQr_btn.TabIndex = 3;
            this.SaveQr_btn.Text = " &Save";
            this.SaveQr_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveQr_btn.UseVisualStyleBackColor = false;
            this.SaveQr_btn.Click += new System.EventHandler(this.SaveQr_btn_Click);
            // 
            // Encode_txt
            // 
            this.Encode_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.Encode_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Encode_txt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encode_txt.ForeColor = System.Drawing.Color.White;
            this.Encode_txt.Location = new System.Drawing.Point(16, 60);
            this.Encode_txt.Name = "Encode_txt";
            this.Encode_txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Encode_txt.Size = new System.Drawing.Size(487, 276);
            this.Encode_txt.TabIndex = 2;
            this.Encode_txt.Text = "Computer programming is the process of telling a computer to do certain things by" +
    " giving it instructions. These instructions are called programs.";
            this.Encode_txt.Enter += new System.EventHandler(this.Encode_txt_Enter);
            // 
            // Encode_title
            // 
            this.Encode_title.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encode_title.ForeColor = System.Drawing.Color.White;
            this.Encode_title.Location = new System.Drawing.Point(12, 11);
            this.Encode_title.Name = "Encode_title";
            this.Encode_title.Size = new System.Drawing.Size(201, 20);
            this.Encode_title.TabIndex = 1;
            this.Encode_title.Text = "Encode";
            // 
            // DragControl1
            // 
            this.DragControl1.Fixed = true;
            this.DragControl1.Horizontal = true;
            this.DragControl1.TargetControl = this.E_panel;
            this.DragControl1.Vertical = true;
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.Title_txt;
            this.DragControl2.Vertical = true;
            // 
            // DragControl3
            // 
            this.DragControl3.Fixed = true;
            this.DragControl3.Horizontal = true;
            this.DragControl3.TargetControl = this.Encode_title;
            this.DragControl3.Vertical = true;
            // 
            // Mpnl
            // 
            this.Mpnl.BackColor = System.Drawing.Color.Transparent;
            this.Mpnl.BaseColor = System.Drawing.Color.Black;
            this.Mpnl.Controls.Add(this.Exit);
            this.Mpnl.Controls.Add(this.About);
            this.Mpnl.Location = new System.Drawing.Point(12, 32);
            this.Mpnl.Name = "Mpnl";
            this.Mpnl.ShadowColor = System.Drawing.Color.Black;
            this.Mpnl.Size = new System.Drawing.Size(121, 65);
            this.Mpnl.TabIndex = 8;
            this.Mpnl.Visible = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Gray;
            this.Exit.Location = new System.Drawing.Point(3, 29);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(115, 31);
            this.Exit.TabIndex = 2;
            this.Exit.Text = " &Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.CloseClick_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Black;
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.Gray;
            this.About.Location = new System.Drawing.Point(3, 3);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(115, 34);
            this.About.TabIndex = 2;
            this.About.Text = " &About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // CloseClick
            // 
            this.CloseClick.BackColor = System.Drawing.Color.Transparent;
            this.CloseClick.Image = global::Doodle_QR.Properties.Resources.Close1;
            this.CloseClick.ImageActive = null;
            this.CloseClick.Location = new System.Drawing.Point(484, 6);
            this.CloseClick.Name = "CloseClick";
            this.CloseClick.Size = new System.Drawing.Size(31, 20);
            this.CloseClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseClick.TabIndex = 0;
            this.CloseClick.TabStop = false;
            this.CloseClick.Zoom = 25;
            this.CloseClick.Click += new System.EventHandler(this.CloseClick_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Image = global::Doodle_QR.Properties.Resources.Menu1;
            this.Menu.ImageActive = null;
            this.Menu.Location = new System.Drawing.Point(12, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(25, 14);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Zoom = 25;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Home
            // 
            this.AccessibleDescription = "Create QR codes";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(517, 350);
            this.Controls.Add(this.E_panel);
            this.Controls.Add(this.RecentPanel_3);
            this.Controls.Add(this.RecentPanel_2);
            this.Controls.Add(this.Decode_lbl);
            this.Controls.Add(this.Encode_lbl);
            this.Controls.Add(this.Recent_lbl);
            this.Controls.Add(this.RecentPanel_1);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.Title_txt);
            this.Controls.Add(this.CloseClick);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mpnl);
            this.Controls.Add(this.Hi_lbl);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(517, 350);
            this.Name = "Home";
            this.Text = "Doodle QR";
            this.Load += new System.EventHandler(this.Home_Load);
            this.DoubleClick += new System.EventHandler(this.Home_DoubleClick);
            this.RecentPanel_1.ResumeLayout(false);
            this.RecentPanel_2.ResumeLayout(false);
            this.RecentPanel_3.ResumeLayout(false);
            this.E_panel.ResumeLayout(false);
            this.Preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrePic)).EndInit();
            this.Mpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton Menu;
        private System.Windows.Forms.Label Title_txt;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Button Decode;
        private Bunifu.Framework.UI.BunifuImageButton CloseClick;
        private System.Windows.Forms.Panel RecentPanel_1;
        private System.Windows.Forms.Label Recent_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Encode_lbl;
        private System.Windows.Forms.Label Decode_lbl;
        private System.Windows.Forms.Label StatRecent_1;
        private System.Windows.Forms.Label TitleRecent_1;
        private System.Windows.Forms.Panel RecentPanel_2;
        private System.Windows.Forms.Label StatRecent_2;
        private System.Windows.Forms.Label TitleRecent_2;
        private System.Windows.Forms.Panel RecentPanel_3;
        private System.Windows.Forms.Label StatRecent_3;
        private System.Windows.Forms.Label TitleRecent_3;
        private System.Windows.Forms.Label Hi_lbl;
        private System.Windows.Forms.Timer Auto;
        private System.Windows.Forms.Panel E_panel;
        private System.Windows.Forms.Label Encode_title;
        private System.Windows.Forms.RichTextBox Encode_txt;
        private System.Windows.Forms.Button Preview_btn;
        private System.Windows.Forms.Button SaveQr_btn;
        private Guna.UI.WinForms.GunaShadowPanel Preview;
        private System.Windows.Forms.PictureBox PrePic;
        private System.Windows.Forms.Button Back;
        private Bunifu.Framework.UI.BunifuDragControl DragControl1;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
        private Bunifu.Framework.UI.BunifuDragControl DragControl3;
        private Guna.UI.WinForms.GunaShadowPanel Mpnl;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button About;
    }
}

