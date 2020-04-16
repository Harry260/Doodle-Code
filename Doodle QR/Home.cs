using System;
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
using MessagingToolkit.QRCode.Codec.Data;
using QRCoder;


namespace Doodle_QR
{
    public partial class Home : Form
    {
  

        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }

      

        public Home()
        {

            InitializeComponent();

        }


        private void Home_Load(object sender, EventArgs e)
        {

            string Uname = System.Windows.Forms.SystemInformation.UserName.ToString();
            Hi_lbl.Text = "Hi " + Uname + " , What are you gonna do";

            Title_txt.Text = Properties.Settings.Default.AppName;

            TitleRecent_1.Text = Properties.Settings.Default.T1;
            TitleRecent_2.Text = Properties.Settings.Default.T2;
            TitleRecent_3.Text = Properties.Settings.Default.T3;

            StatRecent_1.Text = Properties.Settings.Default.P1;
            StatRecent_2.Text = Properties.Settings.Default.P2;
            StatRecent_3.Text = Properties.Settings.Default.P3;

            Auto.Start();

            this.E_panel.Location = new System.Drawing.Point(2, 1);



        }

        private void CloseClick_Click(object sender, EventArgs e)
        {

            this.Close();
            // To close this app


        }

        void Encode_Go()
        {

            Properties.Settings.Default.E = Encode_txt.Text;
            Properties.Settings.Default.Save();

            try
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(Encode_txt.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                Image i = code.GetGraphic(5);

               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void Auto_Tick(object sender, EventArgs e)
        {
            if (Preview.Visible == true)
            {
                Preview_btn.Text = "Close";
            }

            else if (Preview.Visible == false)
            {
                Preview_btn.Text = " &Preview";
            }

            if (TitleRecent_1.Text == "") { RecentPanel_1.Visible = false; }
            else { RecentPanel_1.Visible = true; }


            if (TitleRecent_2.Text == "") { RecentPanel_2.Visible = false; }
            else { RecentPanel_2.Visible = true; }

            if (TitleRecent_3.Text == "") { RecentPanel_3.Visible = false; }
            else { RecentPanel_3.Visible = true; }



        }

        private void Encode_Click(object sender, EventArgs e)
        {
            E_panel.Visible = true;
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP; *.DIB; *.RLE)| *.BMP; *.DIB; *.RLE | JPEG Files: (*.JPG; *.JPEG; *.JPE; *.JFIF)| *.JPG; *.JPEG; *.JPE; *.JFIF |GIF Files: (*.GIF) | *.GIF | TIFF Files: (*.TIF; *.TIFF)| *.TIF; *.TIFF |PNG Files: (*.PNG) | *.PNG | All Files | *.* ", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        Image image = Image.FromFile(ofd.FileName);

                        MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                        string I = decoder.Decode(new QRCodeBitmapImage(image as Bitmap));
                        Properties.Settings.Default.D = I;
                        Properties.Settings.Default.Save();

                        DecodeData decodeData = new DecodeData();
                        decodeData.Show();

                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "Error");
   
                    }
                }
            }
        }

        private void ColorP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrePic_MouseLeave(object sender, EventArgs e)
        {
            Preview.Visible = false;
        }

        private void Encode_txt_Enter(object sender, EventArgs e)
        {
            Preview.Visible = false;
        }

        private void Preview_btn_Click(object sender, EventArgs e)
        {
            if (Preview_btn.Text == " &Preview")
            {
                Preview.Visible = true;

                try
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    QRCodeData data = qr.CreateQrCode(Encode_txt.Text, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data);
                    Image i = code.GetGraphic(5);



                    PrePic.Image = i;
                }
                catch (Exception f)
                {
                    MessageBox.Show( "Cannot Preview : " + f.Message, "Error");
                }

            }
            else { Preview.Visible = false; }


        }

        private void SaveQr_btn_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(Encode_txt.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                Image i = code.GetGraphic(5);

                string App = Properties.Settings.Default.AppName;

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|TIF|*.tig|TIFF|*.tiff|BMP|*bmp";
                save.FileName = App + " Encoded";
                //save.FF = "Image Files|*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.bmp;";
                if (save.ShowDialog() == DialogResult.OK)
                {



                    FileInfo fi = new FileInfo(save.FileName);
                    i.Save(save.FileName);
                    string t = fi.Name;
                    string p1 = save.FileName;
                    string p = Path.GetFullPath(save.FileName);
      

                    string RT1 = Properties.Settings.Default.T1;
                    string RT2 = Properties.Settings.Default.T2;
                    string RT3 = Properties.Settings.Default.T3;

                    string RP1 = Properties.Settings.Default.P1;
                    string RP2 = Properties.Settings.Default.P2;
                    string RP3 = Properties.Settings.Default.P3;

                    if (RT1 == "")
                    {
                        Properties.Settings.Default.T1 = t + " | Encoded";
                        Properties.Settings.Default.P1 = p;
                        Properties.Settings.Default.Save();

                        TitleRecent_1.Text = Properties.Settings.Default.T1;
                        TitleRecent_2.Text = Properties.Settings.Default.T2;
                        TitleRecent_3.Text = Properties.Settings.Default.T3;

                        StatRecent_1.Text = Properties.Settings.Default.P1;
                        StatRecent_2.Text = Properties.Settings.Default.P2;
                        StatRecent_3.Text = Properties.Settings.Default.P3;

                    }
                    else 
                    {

                        Properties.Settings.Default.T3 = RT2;
                        Properties.Settings.Default.T2 = RT1;

                        Properties.Settings.Default.P3 = RP2;
                        Properties.Settings.Default.P2 = RP1;

                        Properties.Settings.Default.T1 = t + " | Encoded";
                        Properties.Settings.Default.P1 = p;

                        Properties.Settings.Default.Save();

                        TitleRecent_1.Text = Properties.Settings.Default.T1;
                        TitleRecent_2.Text = Properties.Settings.Default.T2;
                        TitleRecent_3.Text = Properties.Settings.Default.T3;

                        StatRecent_1.Text = Properties.Settings.Default.P1;
                        StatRecent_2.Text = Properties.Settings.Default.P2;
                        StatRecent_3.Text = Properties.Settings.Default.P3;

                    }

                    E_panel.Visible = false;


                }

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Error");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            E_panel.Visible = false;
        }

        private void RecentPanel_1_MouseHover(object sender, EventArgs e)
        {
            RecentPanel_1.BackColor = Color.FromArgb(100, 88, 255);
        }

        private void TitleRecent_2_MouseHover(object sender, EventArgs e)
        {
            RecentPanel_2.BackColor = Color.FromArgb(100, 88, 255);
        }

        private void TitleRecent_3_MouseHover(object sender, EventArgs e)
        {
            RecentPanel_3.BackColor = Color.FromArgb(100, 88, 255);
        }

        private void RecentPanel_1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(StatRecent_1.Text);
            }
            catch { }
        }

        private void RecentPanel_2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(StatRecent_2.Text);
            }
            catch { }
        }

        private void TitleRecent_3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(StatRecent_3.Text);
            }
            catch { }
        }

        private void TitleRecent_1_MouseLeave(object sender, EventArgs e)
        {
            RecentPanel_1.BackColor = Color.Black;
        }

        private void TitleRecent_2_MouseLeave(object sender, EventArgs e)
        {
            RecentPanel_2.BackColor = Color.Black;
        }


        private void TitleRecent_3_MouseLeave(object sender, EventArgs e)
        {
            RecentPanel_3.BackColor = Color.Black;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if(Mpnl.Visible == true)
            {
                Mpnl.Visible = false;
            }
            else { Mpnl.Visible = true; }
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutF ab = new AboutF();
            ab.Show();

            
        }


        private void TC_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.TURL);
        }

        private void Home_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
