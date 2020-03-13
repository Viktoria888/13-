using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace _13_пятница
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest req = WebRequest.Create(@"http://api.openweathermap.org/data/2.5/weather?q=Moscow&APPID=cc2d757656721c7838f819f150c7f7e6");
            req.ContentType = "application/x-www-urlencoded";
            req.Method = "POST";
            string str = "";
            Open openweather;

            WebResponse response = req.GetResponse();
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader r = new StreamReader(s))
                {
                    // textBox1.Text = r.ReadToEnd();
                    str = r.ReadToEnd();
                }
            }
            response.Close();
            textBox1.Text = str;
            openweather = JsonConvert.DeserializeObject<Open>(str);

            label7.Text = openweather.clouds.all.ToString();
            label8.Text = openweather.main.pressure.ToString();
            label9.Text = openweather.wind.speed.ToString();
            label10.Text = openweather.main.temp.ToString();
            label11.Text = openweather.main.temp_min.ToString();
            label12.Text = openweather.main.temp_max.ToString();
        }
    }
}
