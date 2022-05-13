using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace Stock_Analysis_Application
{
    public partial class Landing_page : Form
    {
        public Landing_page()
        {
            InitializeComponent();
        }

        List<string> enterprise_name = new List<string>();
        List<int> enterprise_id = new List<int>();

        // UI-Control

        bool mov;
        int movX, movY;

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader enterprise_file = new StreamReader("enterprise.csv",Encoding.Default);

            string read_line = "";

            while ((read_line = enterprise_file.ReadLine()) != null) 
            {
                enterprise_id_cbo.Items.Add(read_line.Split(',')[0]);
                enterprise_id.Add(int.Parse(read_line.Split(',')[0]));
                enterprise_name_cbo.Items.Add(read_line.Split(',')[1]);
                enterprise_name.Add(read_line.Split(',')[1]);
            }

            enterprise_name_cbo.Enabled = false;
            enterprise_id_cbo.Enabled = false;

            // UI-Conntrol

            this.FormBorderStyle = FormBorderStyle.None;
            Banner.Image = new Bitmap("Banner.png");
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetWindowRegion(sender, e);

            window_exit.Parent = Banner;
            window_exit.SizeMode = PictureBoxSizeMode.StretchImage;
            window_exit.BackColor = Color.Transparent;
            window_exit.Image = new Bitmap("window_exit.png");

            window_minimize.Parent = Banner;
            window_minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            window_minimize.BackColor = Color.Transparent;
            window_minimize.Image = new Bitmap("window_minimize.png");

            window_maximize.Parent = Banner;
            window_maximize.SizeMode = PictureBoxSizeMode.StretchImage;
            window_maximize.BackColor = Color.Transparent;
            window_maximize.Image = new Bitmap("window_maximize.png");

            check_button.Image = new Bitmap("button.png");
            check_button.BackColor = Color.Transparent;
            check_button.FlatAppearance.BorderColor = Color.Gray;
            

        }

        private void enterprise_name_radio_box_CheckedChanged(object sender, EventArgs e)
        {
            enterprise_name_radio_box.Enabled = true;
            enterprise_name_cbo.Enabled = true;
            enterprise_id_cbo.Enabled = false;
            enterprise_id_cbo.Text = "";
            enterprise_name_cbo.Text = "";
        }

        private void enterprise_id_radio_box_CheckedChanged(object sender, EventArgs e)
        {
            enterprise_id_radio_box.Enabled = true;
            enterprise_name_cbo.Enabled = false;
            enterprise_id_cbo.Enabled = true;
            enterprise_id_cbo.Text = "";
            enterprise_name_cbo.Text = "";
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            if (enterprise_id_cbo.Text == "" && enterprise_name_cbo.Text == "")
            {
                MessageBox.Show("請輸入股票名稱或代碼");
            }
            else if(enterprise_name.Contains(enterprise_name_cbo.Text))
            {
                Form2 main_page = new Form2();
                this.Visible = false;
                main_page.objective_id = int.Parse(enterprise_id_cbo.Text);
                main_page.objective_name = enterprise_name_cbo.Text;
                main_page.Visible = true;
            }
            else
            {
                MessageBox.Show("查無此股,請重新輸入");
            }
        }


        private void enterprise_name_cbo_TextChanged(object sender, EventArgs e)
        {
            if (enterprise_name.Contains(enterprise_name_cbo.Text))
            {
                int index = enterprise_name.IndexOf(enterprise_name_cbo.Text);
                enterprise_id_cbo.Text = enterprise_id[index].ToString();
            }
        }

        private void enterprise_id_cbo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (enterprise_id.Contains(int.Parse(enterprise_id_cbo.Text)))
                {
                    int index = enterprise_id.IndexOf(int.Parse(enterprise_id_cbo.Text));
                    enterprise_name_cbo.Text = enterprise_name[index];
                }
            }
            catch { }
        }

        // UI-Control
        public void SetWindowRegion(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 10);
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            // 左上角
            path.AddArc(arcRect, 180, 90);
            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            //閉合曲線
            path.CloseFigure();
            return path;
        }

        private void Banner_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true; movX = e.X; movY = e.Y;
        }

        private void Banner_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void window_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Banner_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void window_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
