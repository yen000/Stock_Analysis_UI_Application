using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Stock_Analysis_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string objective_name;
        public int objective_id;
        public string stock_web_page1;
        public string stock_web_page2;
        public string current_price;
        public List<Label> price_label_set = new List<Label>();
        public List<int> enterprise_id_set = new List<int>();
        static public Form3 running_waiting_page = new Form3();

        // UI-Control

        bool mov;
        int movX, movY;

        private void Form2_Load(object sender, EventArgs e)
        {
            stock_web_page1 = "https://www.nvesto.com/tpe/" + objective_id.ToString();
            stock_web_page2 = "http://ww2.money-link.com.tw/TWStock/StockChart.aspx?SymId=" + objective_id.ToString();
            enterprise_id_set.Add(objective_id);
            price_label_set.Add(price);


            timer1.Interval = 3000;
            timer1.Enabled = true;

            tabPage1.BorderStyle = BorderStyle.None;

            // open waiting page (Form3)

            add_list.Image = new Bitmap("button.png");
            add_list.BackColor = Color.Transparent;
            add_list.FlatAppearance.BorderColor = Color.Gray;

            company_info.Image = new Bitmap("button.png");
            company_info.BackColor = Color.Transparent;
            company_info.FlatAppearance.BorderColor = Color.Gray;

            R.Image = new Bitmap("button.png");
            R.BackColor = Color.Transparent;
            R.FlatAppearance.BorderColor = Color.Gray;

            Thread show_waiting_thread = new Thread(Show_waiting_page);
            show_waiting_thread.Start();

            name.Text = objective_name;
            id.Text = "( " + objective_id.ToString() + " )";
            pictureBox_clock.Image = new Bitmap("clock.png");
            pictureBox_clock.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_clock.BorderStyle = BorderStyle.None;

            time.Text = System.DateTime.Now.ToString("G");

            convert_current_price(price);
            convert_one(one);
            convert_two(two);
            convert_three(three);

            convert_four(four);
            convert_five(five);

            convert_six(six);
            convert_seven(seven);

            pictureBox_company.Image = new Bitmap("company.jpg");
            pictureBox_company.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_company.BorderStyle = BorderStyle.None;

            pictureBox_outside_line.Image = new Bitmap("outside_line.jpg");
            pictureBox_outside_line.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_outside_line.BorderStyle = BorderStyle.None;

            pictureBox_blue.Image = new Bitmap("blue.jpg");
            pictureBox_blue.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_blue.BorderStyle = BorderStyle.None;
            convert_eight(eight);

            pictureBox_green.Image = new Bitmap("green.jpg");
            pictureBox_green.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_green.BorderStyle = BorderStyle.None;
            convert_nine(nine);

            pictureBox_red.Image = new Bitmap("red.jpg");
            pictureBox_red.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_red.BorderStyle = BorderStyle.None;
            convert_ten(ten);


            pictureBox_green2.Image = new Bitmap("green.jpg");
            pictureBox_green2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_green2.BorderStyle = BorderStyle.None;
            convert_eleven(eleven);

            pictureBox_red2.Image = new Bitmap("red.jpg");
            pictureBox_red2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_red2.BorderStyle = BorderStyle.None;
            convert_twelve(twelve);


            tabControl1.TabPages[0].Text = objective_name;
            company_info.Click += delegate (object sender1, EventArgs e1) { Company_info_Click(sender, e, objective_id, objective_name); };

            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(company_info, objective_name+ "股票資訊連結");

            toolTip2.IsBalloon = true;
            toolTip2.SetToolTip(add_list,"查看其他股票資訊");

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


            while (true)
            {
                if (show_waiting_thread.ThreadState.Equals(ThreadState.Stopped))
                {
                    break;
                }
                else { Thread.Sleep(100); }
            }
        }

        private void Show_waiting_page()
        {
            Form3 waiting_page = new Form3();
            waiting_page.Visible = true;
            running_waiting_page = waiting_page;
            waiting_page.Refresh();
        }

        static async Task<string> GetHtmlAsync_current_price(string stock_web)
        {

            var url2 = stock_web;
            string price_now = "";

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StockListsHTML_down = htmlDocument2.DocumentNode.Descendants("h1")
               .Where(node => node.GetAttributeValue("class", "")
               .Contains("DN")).ToList();

            var StockListsHTML_down2 = htmlDocument2.DocumentNode.Descendants("div")
               .Where(node => node.GetAttributeValue("class", "")
               .Contains("DN")).ToList();

            var StockListsHTML_up = htmlDocument2.DocumentNode.Descendants("h1")
               .Where(node => node.GetAttributeValue("class", "")
               .Contains("UP")).ToList();

            var StockListsHTML_up2 = htmlDocument2.DocumentNode.Descendants("div")
            .Where(node => node.GetAttributeValue("class", "")
            .Contains("UP")).ToList();


            var StockListsHTML_no = htmlDocument2.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("TwstockID")).ToList();

            var stockListitems_no1 = StockListsHTML_no[0].Descendants("h1")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("")).ToList();

            var stockListitems_no2 = StockListsHTML_no[0].Descendants("div")
                         .Where(node => node.GetAttributeValue("class", "")
                         .Contains("")).ToList();



            int count = StockListsHTML_up.Count;

            if (StockListsHTML_up.Count == 1)
            {
                var stock_price_UP = StockListsHTML_up[0].InnerText.Trim('\t', '\r', '\n').ToList();
                var stock_price_UP2 = StockListsHTML_up2[0].InnerText.Trim('\t', '\r', '\n').ToList();
            

                for (int i = 0; i < stock_price_UP.Count; i++)
                {
                    price_now += stock_price_UP[i];
                }
                price_now += "  ";
                for (int i = 0; i < stock_price_UP2.Count; i++)
                {
                    price_now += stock_price_UP2[i];
                }
            }
            else if (StockListsHTML_down.Count == 1)
            {
                
                var stock_price_DN = StockListsHTML_down[0].InnerText.Trim('\t', '\r', '\n').ToList();
                var stock_price_DN2 = StockListsHTML_down2[0].InnerText.Trim('\t', '\r', '\n').ToList();

                for (int i = 0; i < stock_price_DN.Count; i++)
                {
                    price_now += stock_price_DN[i];

                }
                price_now += "  ";
                for (int i = 0; i < stock_price_DN2.Count; i++)
                {
                    price_now += stock_price_DN2[i];


                }
            }
            else
            {

                var stock_price_no = stockListitems_no1[0].InnerText.Trim('\t', '\r', '\n').ToList();
                var stock_price_no2 = stockListitems_no2[0].InnerText.Trim('\t', '\r', '\n').ToList();

                for (int i = 0; i < stock_price_no.Count; i++)
                {
                    price_now += stock_price_no[i];

                }
                price_now += "  ";
                for (int i = 0; i < stock_price_no2.Count; i++)
                {
                    price_now += stock_price_no2[i];


                }
            }

            return price_now;
        }

        public async void convert_current_price(Label Objective)
        {

            while (true)
            {
                try
                {
                    var temp = GetHtmlAsync_current_price(stock_web_page2);
                    System.Threading.Thread.Sleep(1500);
                    string result = await temp;
                    if (result.Contains("△"))
                    {
                        Objective.ForeColor = Color.Red;
                        Objective.Text = result;
                    }
                    else if (result.Contains("▽"))
                    {
                        Objective.ForeColor = Color.Green;
                        Objective.Text = result;
                    }
                    else
                    {
                        Objective.ForeColor = Color.Gray;
                        Objective.Text = result;

                    }
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
            
        }
        public async void convert_one(Label objective)
        {
           
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_one(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
           
        }
        static async Task<string> GetHtmlAsync_one(string stock_web)
        {
            string one = "";
            var url = stock_web;

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var name = htmlDocument.DocumentNode.Descendants("h1")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("tex_black")).ToList();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var StockListsHTML = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("tableModule")).ToList();

            var stockListitems = StockListsHTML[0].Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("sectionFrame")).ToList();


            one = stockListitems[0].Descendants("span")
                  .Where(node => node.GetAttributeValue("class", "")
                  .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n');

            return one;

        }
        public async void convert_two(Label objective)
        {

            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_two(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
           
        }

        static async Task<string> GetHtmlAsync_two(string stock_web)
        {
            string two = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var name = htmlDocument2.DocumentNode.Descendants("h1")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("tex_black")).ToList();

            var StockListsHTML2 = htmlDocument2.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("tableModule")).ToList();

            var stockListitems2 = StockListsHTML2[0].Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("sectionFrame")).ToList();

            two = stockListitems2[1].Descendants("span")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n');


            return two;

        }
        public async void convert_three(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500); ;
                    var temp = GetHtmlAsync_three(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }

           
        }

        static async Task<string> GetHtmlAsync_three(string stock_web)
        {
            string three = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StockListsHTML2 = htmlDocument2.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("tableModule")).ToList();

            var stockListitems2 = StockListsHTML2[0].Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("sectionFrame")).ToList();

            three = stockListitems2[2].Descendants("span")
                       .Where(node => node.GetAttributeValue("class", "")
                       .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n');


            return three;

        }
        public async void convert_four(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_four(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }

            
        }

        static async Task<string> GetHtmlAsync_four(string stock_web)
        {
            string four_temp = "";
            string four = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StocktListsHTML2 = htmlDocument2.DocumentNode.Descendants("div")
               .Where(node => node.GetAttributeValue("class", "")
               .Equals("sectionFrame sectionFrameS")).ToList();

            var stockListitems2_1 = StocktListsHTML2[0].Descendants("div").ToList();

            four_temp = stockListitems2_1[0].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

           four= four_temp.Split('&')[0];


            return four;

        }
        public async void convert_five(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_five(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }

          
        }

        static async Task<string> GetHtmlAsync_five(string stock_web)
        {
            string five = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StocktListsHTML2 = htmlDocument2.DocumentNode.Descendants("div")
               .Where(node => node.GetAttributeValue("class", "")
               .Equals("sectionFrame sectionFrameS")).ToList();

            var stockListitems2_1 = StocktListsHTML2[0].Descendants("div").ToList();

            five = stockListitems2_1[1].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return five;

        }

        public async void convert_six(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500); ;
                    var temp = GetHtmlAsync_six(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
           
        }

        static async Task<string> GetHtmlAsync_six(string stock_web)
        {
            string six = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StocktListsHTML2 = htmlDocument2.DocumentNode.Descendants("div")
               .Where(node => node.GetAttributeValue("class", "")
               .Equals("sectionFrame sectionFrameS")).ToList();

            var stockListitems2_2 = StocktListsHTML2[1].Descendants("div").ToList();

            six = stockListitems2_2[0].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return six;

        }
        public async void convert_seven(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_seven(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
           
        }

        static async Task<string> GetHtmlAsync_seven(string stock_web)
        {
            string seven = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StocktListsHTML2 = htmlDocument2.DocumentNode.Descendants("div")
               .Where(node => node.GetAttributeValue("class", "")
               .Equals("sectionFrame sectionFrameS")).ToList();

            var stockListitems2_2 = StocktListsHTML2[1].Descendants("div").ToList();

            seven = stockListitems2_2[1].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return seven;

        }
        public async void convert_eight(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_eight(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
           
        }

        static async Task<string> GetHtmlAsync_eight(string stock_web)
        {
            string eight = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StocktListsHTML3 = htmlDocument2.DocumentNode.Descendants("tr")
                  .Where(node => node.GetAttributeValue("class", "")
                  .Contains("unitheight")).ToList();

            var stockListitems3_1 = StocktListsHTML3[11].Descendants("td").ToList();

            eight = stockListitems3_1[0].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return eight;

        }

        public async void convert_nine(Label objective)
        {

            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_nine(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
            
        }

        static async Task<string> GetHtmlAsync_nine(string stock_web)
        {
            string nine = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StocktListsHTML3 = htmlDocument2.DocumentNode.Descendants("tr")
                  .Where(node => node.GetAttributeValue("class", "")
                  .Contains("unitheight")).ToList();

            var stockListitems3_1 = StocktListsHTML3[11].Descendants("td").ToList();

            nine = stockListitems3_1[1].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return nine;

        }
        public async void convert_ten(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_ten(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
           
        }

        static async Task<string> GetHtmlAsync_ten(string stock_web)
        {
            string ten = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);

            var StocktListsHTML3 = htmlDocument2.DocumentNode.Descendants("tr")
                  .Where(node => node.GetAttributeValue("class", "")
                  .Contains("unitheight")).ToList();

            var stockListitems3_1 = StocktListsHTML3[11].Descendants("td").ToList();

            ten = stockListitems3_1[2].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return ten;

        }
        public async void convert_eleven(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_eleven(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }
           
        }

        static async Task<string> GetHtmlAsync_eleven(string stock_web)
        {
            string eleven = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);
            var StocktListsHTML3 = htmlDocument2.DocumentNode.Descendants("tr")
                           .Where(node => node.GetAttributeValue("class", "")
                           .Contains("unitheight")).ToList();

            var stockListitems3_2 = StocktListsHTML3[12].Descendants("td").ToList();

            eleven = stockListitems3_2[0].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return eleven;

        }
        public async void convert_twelve(Label objective)
        {
            while (true)
            {
                try
                {
                    Random time = new Random();
                    //Thread.Sleep(time.Next(10, 30));
                    System.Threading.Thread.Sleep(1500);
                    var temp = GetHtmlAsync_twelve(stock_web_page1);
                    string result = await temp;
                    objective.Text = result;
                }
                catch (Exception)
                {
                    continue;
                }

                break;
            }

        }

        static async Task<string> GetHtmlAsync_twelve(string stock_web)
        {
            string twelve = "";
            var url2 = stock_web;

            var httpClient2 = new HttpClient();
            var html2 = await httpClient2.GetStringAsync(url2);

            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(html2);
            var StocktListsHTML3 = htmlDocument2.DocumentNode.Descendants("tr")
                           .Where(node => node.GetAttributeValue("class", "")
                           .Contains("unitheight")).ToList();

            var stockListitems3_2 = StocktListsHTML3[12].Descendants("td").ToList();

            twelve = stockListitems3_2[1].Descendants("span")
                      .Where(node => node.GetAttributeValue("class", "")
                      .Contains("tex")).FirstOrDefault().InnerText.Trim('\t', '\r', '\n', '&', 'n', 's', 'b', 'p');

            return twelve;

        }

        private void R_p1_Click(object sender, EventArgs e)
        {
            Form6 R_analysis = new Form6();
            R_analysis.Visible = true;
        }

        private void Add_list_Click(object sender, EventArgs e)
        {
            Form4 add_page = new Form4(this);
            add_page.Visible = true;

        }

        public void Retrived_from_form4(object sender, EventArgs e, string added_objective_name, int added_objective_id)
        {
            TabPage new_page = new TabPage();
            tabControl1.TabPages.Add(new_page);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Text = added_objective_name;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].BackColor = Color.White;
            tabControl1.Refresh();

            stock_web_page1 = "https://www.nvesto.com/tpe/" + added_objective_id.ToString();
            stock_web_page2 = "http://ww2.money-link.com.tw/TWStock/StockChart.aspx?SymId=" + added_objective_id.ToString();
            enterprise_id_set.Add(added_objective_id);

            // open waiting page (Form3)

            Thread show_waiting_thread = new Thread(Show_waiting_page);
            show_waiting_thread.Start();

            company_info.Refresh();
            Button added_button = new Button();
            added_button.Image = new Bitmap("button.png");
            added_button.Text = company_info.Text;
            added_button.Font = company_info.Font;
            added_button.Location = company_info.Location;
            added_button.Size = company_info.Size;
            added_button.BackColor = company_info.BackColor;
            added_button.FlatStyle = company_info.FlatStyle;
            added_button.ForeColor = company_info.ForeColor;
            added_button.FlatAppearance.BorderColor = Color.Gray;
            added_button.BringToFront();
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_button);
            added_button.Enabled = true;
       

            ToolTip added_tooltip = new ToolTip();
            added_tooltip.IsBalloon = true;
            added_tooltip.SetToolTip(added_button, added_objective_name+"股票資訊連結");

            added_button.Click += delegate (object sender1, EventArgs e1) { Company_info_Click(sender, e, added_objective_id, added_objective_name); };


            company_info.Refresh();
            added_button.Refresh();

            Label added_name = new Label();
            added_name.Text = added_objective_name;
            added_name.Font = name.Font;
            added_name.Location = name.Location;
            added_name.Size = name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_name);

            Label added_id = new Label();
            added_id.Text = "( " + added_objective_id.ToString() + " )";
            added_id.Font = id.Font;
            added_id.Location = id.Location;
            added_id.Size = id.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_id);

            Label added_price = new Label();
            convert_current_price(added_price);
            price_label_set.Add(added_price);
            added_price.Font = price.Font;
            added_price.Location = price.Location;
            added_price.Size = price.Size;
            added_price.TextAlign = price.TextAlign;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_price);

            Label added_one_name = new Label();
            added_one_name.Text = one_name.Text;
            added_one_name.Font = one_name.Font;
            added_one_name.Location = one_name.Location;
            added_one_name.Size = one_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_one_name);

            Label added_one = new Label();
            convert_one(added_one);
            added_one.Font = one.Font;
            added_one.Location = one.Location;
            added_one.Size = one.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_one);


            Label added_two_name = new Label();
            added_two_name.Text = two_name.Text;
            added_two_name.Font = two_name.Font;
            added_two_name.Location = two_name.Location;
            added_two_name.Size = two_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_two_name);

            Label added_two = new Label();
            convert_two(added_two);
            added_two.Font = two.Font;
            added_two.Location = two.Location;
            added_two.Size = two.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_two);
            

            Label added_three_name = new Label();
            added_three_name.Text = three_name.Text;
            added_three_name.Font = three_name.Font;
            added_three_name.Location = three_name.Location;
            added_three_name.Size=three_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_three_name);

            Label added_three = new Label();
            convert_three(added_three);
            added_three.Font = three.Font;
            added_three.Location = three.Location;
            added_three.Size = three.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_three);


            Label added_four_name = new Label();
            added_four_name.Text = four_name.Text;
            added_four_name.Font = four_name.Font;
            added_four_name.Location = four_name.Location;
            added_four_name.Size = four.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_four_name);

            Label added_four = new Label();
            convert_four(added_four);
            added_four.Font = four.Font;
            added_four.Location = four.Location;
            added_four.Size = four.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_four);


            Label added_five_name = new Label();
            added_five_name.Text = five_name.Text;
            added_five_name.Font = five_name.Font;
            added_five_name.Location = five_name.Location;
            added_five_name.Size = five_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_five_name);

            Label added_five = new Label();
            convert_five(added_five);
            added_five.Font = five.Font;
            added_five.Location = five.Location;
            added_five.Size = five.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_five);


            Label added_six_name = new Label();
            added_six_name.Text = six_name.Text;
            added_six_name.Font = six_name.Font;
            added_six_name.Location = six_name.Location;
            added_six_name.Size = six_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_six_name);

            Label added_six = new Label();
            convert_six(added_six);
            added_six.Font = six.Font;
            added_six.Location = six.Location;
            added_six.Size = six.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_six);


            Label added_seven_name = new Label();
            added_seven_name.Text = seven_name.Text;
            added_seven_name.Font = seven_name.Font;
            added_seven_name.Location = seven_name.Location;
            added_seven_name.Size = seven_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_seven_name);

            Label added_seven = new Label();
            convert_seven(added_seven);
            added_seven.Font = seven.Font;
            added_seven.Location = seven.Location;
            added_seven.Size = seven.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_seven);


            Control someParent_addedblue = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            PictureBox added_picturebox_blue = new PictureBox();
            added_picturebox_blue.Image = new Bitmap("blue.jpg");
            added_picturebox_blue.Parent = someParent_addedblue; 
            added_picturebox_blue.Location = pictureBox_blue.Location;
            added_picturebox_blue.Size = pictureBox_blue.Size;

            Label added_eight_name = new Label();
            added_eight_name.Text = eight_name.Text;
            added_eight_name.Font = eight_name.Font;
            added_eight_name.Location = eight_name.Location;
            added_eight_name.Size = eight_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_eight_name);

            Label added_eight = new Label();
            convert_eight(added_eight);
            added_eight.Font = eight.Font;
            added_eight.Location = eight.Location;
            added_eight.Size = eight.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_eight);


            Control someParent_addedgreen = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            PictureBox added_picturebox_green = new PictureBox();
            added_picturebox_green.Image = new Bitmap("green.jpg");
            added_picturebox_green.Parent = someParent_addedgreen;
            added_picturebox_green.Location = pictureBox_green.Location;
            added_picturebox_green.Size = pictureBox_green.Size;

            Label added_nine_name = new Label();
            added_nine_name.Text = nine_name.Text;
            added_nine_name.Font = nine_name.Font;
            added_nine_name.Location = nine_name.Location;
            added_nine_name.Size = nine_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_nine_name);

            Label added_nine = new Label();
            convert_nine(added_nine);
            added_nine.Font = nine.Font;
            added_nine.Location = nine.Location;
            added_nine.Size = nine.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_nine);


            Control someParent_addedred= tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            PictureBox added_picturebox_red = new PictureBox();
            added_picturebox_red.Image = new Bitmap("red.jpg");
            added_picturebox_red.Parent = someParent_addedred;
            added_picturebox_red.Location = pictureBox_red.Location;
            added_picturebox_red.Size = pictureBox_red.Size;

            Label added_ten_name = new Label();
            added_ten_name.Text = ten_name.Text;
            added_ten_name.Font = ten_name.Font;
            added_ten_name.Location = ten_name.Location;
            added_ten_name.Size = ten_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_ten_name);

            Label added_ten = new Label();
            convert_ten(added_ten);
            added_ten.Font = ten.Font;
            added_ten.Location = ten.Location;
            added_ten.Size = ten.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_ten);

            Control someParent_addedred2 = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            PictureBox added_picturebox_red2 = new PictureBox();
            added_picturebox_red2.Image = new Bitmap("red.jpg");
            added_picturebox_red2.Parent = someParent_addedred2;
            added_picturebox_red2.Location = pictureBox_red2.Location;
            added_picturebox_red2.Size = pictureBox_red2.Size;

            Label added_eleven_name = new Label();
            added_eleven_name.Text = eleven_name.Text;
            added_eleven_name.Font = eleven_name.Font;
            added_eleven_name.Location = eleven_name.Location;
            added_eleven_name.Size = eleven_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_eleven_name);

            Label added_eleven = new Label();
            convert_eleven(added_eleven);
            added_eleven.Font = eleven.Font;
            added_eleven.Location = eleven.Location;
            added_eleven.Size = eleven.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_eleven);


            Control someParent_addedgreen2 = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            PictureBox added_picturebox_green2 = new PictureBox();
            added_picturebox_green2.Image = new Bitmap("green.jpg");
            added_picturebox_green2.Parent = someParent_addedgreen2;
            added_picturebox_green2.Location = pictureBox_green2.Location;
            added_picturebox_green2.Size = pictureBox_green2.Size;

            Label added_twelve_name = new Label();
            added_twelve_name.Text = twelve_name.Text;
            added_twelve_name.Font = twelve_name.Font;
            added_twelve_name.Location = twelve_name.Location;
            added_twelve_name.Size = twelve_name.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_twelve_name);

            Label added_twelve = new Label();
            convert_twelve(added_twelve);
            added_twelve.Font = twelve.Font;
            added_twelve.Location = twelve.Location;
            added_twelve.Size = twelve.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_twelve);

            Label added_line1 = new Label();
            added_line1.Text = line1.Text;
            added_line1.Font = line1.Font;
            added_line1.Location =line1.Location;
            added_line1.Size = line1.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_line1);
            


            Label added_line2 = new Label();
            added_line2.Text = line2.Text;
            added_line2.Font = line2.Font;
            added_line2.Location = line2.Location;
            added_line2.Size = line2.Size;
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(added_line2);


            Control someParent_added_company = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            PictureBox added_picturebox_company = new PictureBox();
            added_picturebox_company.Image = new Bitmap("company.jpg");
            added_picturebox_company.Parent = someParent_added_company;
            added_picturebox_company.Location = pictureBox_company.Location;
            added_picturebox_company.Size = pictureBox_company.Size;
            added_picturebox_company.SizeMode = PictureBoxSizeMode.StretchImage;
            added_picturebox_company.BackColor = Color.Transparent;
            added_picturebox_company.Refresh();
            
            
            Control someParent_addedoutside_line = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            PictureBox added_picturebox_outside_line = new PictureBox();
            added_picturebox_outside_line.Size = pictureBox_outside_line.Size;
            added_picturebox_outside_line.Image = new Bitmap("outside_line.jpg");
            added_picturebox_outside_line.Parent = someParent_addedoutside_line;
            added_picturebox_outside_line.Location = pictureBox_outside_line.Location;
            added_picturebox_outside_line.SizeMode = PictureBoxSizeMode.StretchImage;
            added_picturebox_outside_line.BackColor = Color.Transparent;



            while (true)
            {
                if (show_waiting_thread.ThreadState.Equals(ThreadState.Stopped))
                {
                    break;
                }
                else { Thread.Sleep(100); }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.ToString("G");

            TimeSpan starttime = new TimeSpan(9, 0, 0);
            TimeSpan endtime = new TimeSpan(13, 30, 0);

            if (DateTime.Now.TimeOfDay >= starttime && DateTime.Now.TimeOfDay <= endtime)
            {
                for(int i = 0; i < enterprise_id_set.Count; i++)
                {
                    stock_web_page2 = "http://ww2.money-link.com.tw/TWStock/StockChart.aspx?SymId=" + enterprise_id_set[i].ToString();
                    convert_current_price(price_label_set[i]);
                }
            }
        }

        void Company_info_Click(object sender, EventArgs e, int objective_id, string objective_name)
        {
            Form5 company_link = new Form5();
            company_link.Refresh();
            company_link.objective_id = objective_id;
            company_link.objective_name = objective_name;
            company_link.Visible = true;
        }

        // UI-Constrol
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
            Application.Exit();
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
