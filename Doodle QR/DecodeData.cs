﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doodle_QR
{
    public partial class DecodeData : Form
    {

        public DecodeData()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        string path;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Sizer_Tick(object sender, EventArgs e)
        {
            Cdock.Height = this.Height -90;
            Cdock.Width = this.Width - 24;

        }

        private void DecodeData_Load(object sender, EventArgs e)
        {
            Sizer.Start();
            Data.Text = Properties.Settings.Default.D;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Data.Text);
        }

        private async void  SaveTxt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {

                sfd.Title = "Save Decodes text.";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;


                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        await sw.WriteAsync(Data.Text);
                    }
                }

            }
        }

        private void Gsearch_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/search?q=" + Data.Text);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
