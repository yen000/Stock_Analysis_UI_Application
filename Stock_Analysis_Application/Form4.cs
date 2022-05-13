using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Analysis_Application
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form2 mainform = null;

        // UI-Control

        bool mov;
        int movX, movY;

        public Form4(Form callingform)
        {
            mainform = callingform as Form2;
            InitializeComponent();
        }

        List<string> enterprise_name = new List<string>();
        List<int> enterprise_id = new List<int>();

        public string objective_name="";
        public int objective_id;

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader enterprise_file = new StreamReader("enterprise.csv", Encoding.Default);

            string read_line = "";

            check_button4.Image = new Bitmap("button.png");
            check_button4.BackColor = Color.Transparent;
            check_button4.FlatAppearance.BorderColor = Color.Gray;

            while ((read_line = enterprise_file.ReadLine()) != null)
            {
                enterprise_id_cbo4.Items.Add(read_line.Split(',')[0]);
                enterprise_id.Add(int.Parse(read_line.Split(',')[0]));
                enterprise_name_cbo4.Items.Add(read_line.Split(',')[1]);
                enterprise_name.Add(read_line.Split(',')[1]);
            }

            enterprise_name_cbo4.Enabled = false;
            enterprise_id_cbo4.Enabled = false;

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

        }

        private void Enterprise_name_radio_box4_CheckedChanged(object sender, EventArgs e)
        {

            enterprise_name_radio_box4.Enabled = true;
            enterprise_name_cbo4.Enabled = true;
            enterprise_id_cbo4.Enabled = false;
            enterprise_id_cbo4.Text = "";
            enterprise_name_cbo4.Text = "";
        }

        private void Enterprise_id_radio_box4_CheckedChanged(object sender, EventArgs e)
        {
            enterprise_id_radio_box4.Enabled = true;
            enterprise_name_cbo4.Enabled = false;
            enterprise_id_cbo4.Enabled = true;
            enterprise_id_cbo4.Text = "";
            enterprise_name_cbo4.Text = "";
        }

        private void Check_button4_Click(object sender, EventArgs e)
        {
            if (enterprise_id_cbo4.Text == "" && enterprise_name_cbo4.Text == "")
            {
                MessageBox.Show("請輸入股票名稱或代碼");
            }
            else if (enterprise_name.Contains(enterprise_name_cbo4.Text))
            {
                objective_name = enterprise_name_cbo4.Text;
                objective_id = int.Parse(enterprise_id_cbo4.Text);
                this.Visible = false;
                mainform.Retrived_from_form4(sender, e, objective_name, objective_id);
            }
            else
            {
                MessageBox.Show("查無此股,請重新輸入");
            }
        }

        private void Enterprise_name_cbo4_TextChanged(object sender, EventArgs e)
        {
            if (enterprise_name.Contains(enterprise_name_cbo4.Text))
            {
                int index = enterprise_name.IndexOf(enterprise_name_cbo4.Text);
                enterprise_id_cbo4.Text = enterprise_id[index].ToString();
            }
        }

        private void Enterprise_id_cbo4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (enterprise_id.Contains(int.Parse(enterprise_id_cbo4.Text)))
                {
                    int index = enterprise_id.IndexOf(int.Parse(enterprise_id_cbo4.Text));
                    enterprise_name_cbo4.Text = enterprise_name[index];
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

        private void window_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void window_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Banner_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
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



    }
}
