using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Analysis_Application
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string objective_name;
        public int objective_id;

        public string webpage_company_background;
        public string webpage_stock_price;
        public string webpage_business_turnover;
        public string webpage_income_statement;
        public string webpage_current_asset;
        public string webpage_dividend_policy;


        // UI-Control
        bool mov;
        int movX, movY;

        private void Form5_Load(object sender, EventArgs e)
        {
            //1
            company_background.Image = new Bitmap("button.png");
            company_background.BackColor = Color.Transparent;
            company_background.FlatAppearance.BorderColor = Color.Gray;
            //2
            stock_price.Image = new Bitmap("button.png");
            stock_price.BackColor = Color.Transparent;
            stock_price.FlatAppearance.BorderColor = Color.Gray;
            //3
            dividend_policy.Image = new Bitmap("button.png");
            dividend_policy.BackColor = Color.Transparent;
            dividend_policy.FlatAppearance.BorderColor = Color.Gray;
            //4
            business_turnover.Image = new Bitmap("button.png");
            business_turnover.BackColor = Color.Transparent;
            business_turnover.FlatAppearance.BorderColor = Color.Gray;
            //5
            income_statement.Image = new Bitmap("button.png");
            income_statement.BackColor = Color.Transparent;
            income_statement.FlatAppearance.BorderColor = Color.Gray;
            //6
            current_asset.Image = new Bitmap("button.png");
            current_asset.BackColor = Color.Transparent;
            current_asset.FlatAppearance.BorderColor = Color.Gray;
            //7
            stock_pic.Image = new Bitmap("button.png");
            stock_pic.BackColor = Color.Transparent;
            stock_pic.FlatAppearance.BorderColor = Color.Gray;

            company_name.Text = objective_name;
            company_id.Text = "( " + objective_id.ToString() + " )";

            pictureBox_company_info.Image = new Bitmap("company_noback.png");
            pictureBox_company_info.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_company_info.BorderStyle = BorderStyle.None;


            pictureBox_stock.Image = new Bitmap("stock-market.png");
            pictureBox_stock.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_stock.BorderStyle = BorderStyle.None;


            pictureBox_revenue.Image = new Bitmap("income.png");
            pictureBox_revenue.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_revenue.BorderStyle = BorderStyle.None;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap("background_color.png");

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = new Bitmap("background_color.png");

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

        private void Company_background_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/BasicInfo.asp?STOCK_ID=" + objective_id.ToString());

        }

        private void Stock_price_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/StockDetail.asp?STOCK_ID=" + objective_id.ToString());

        }

        private void Business_turnover_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/ShowSaleMonChart.asp?STOCK_ID=" + objective_id.ToString());

        }

        private void Income_statement_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/StockFinDetail.asp?RPT_CAT=IS_M_QUAR_ACC&STOCK_ID=" + objective_id.ToString());

        }

        private void Current_asset_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/StockFinDetail.asp?RPT_CAT=BS_M_QUAR&STOCK_ID=" + objective_id.ToString());
        }

        private void Dividend_policy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/StockDividendPolicy.asp?STOCK_ID=" + objective_id.ToString());
        }
        private void Stock_pic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goodinfo.tw/StockInfo/ShowK_Chart.asp?STOCK_ID=" + objective_id.ToString() + "&CHT_CAT2=DATE");


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
