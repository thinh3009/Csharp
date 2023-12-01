using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace seleniumbuoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //set
            IWebDriver dr= new ChromeDriver();
            dr.Url = "https://www.google.com/";
            dr.Navigate();
            //get
            string linkHienTai = dr.Url;
            Console.WriteLine(linkHienTai);
            //get tieu de: lay tu output
            string tieude = dr.Title;
            Console.WriteLine(tieude);
            //cach2: lay tu o textbox
            txtOut.Text = dr.Title;
            //page source
            string pgsource = dr.PageSource;
            Console.WriteLine(pgsource);

            //close
            //dr.Close();
            dr.Navigate().GoToUrl("https://anhtester.com/blog/-selenium-c-bai-1-huong-dan-cai-dat-va-vi-du-ve-nunit-b277.html");

            //back
            dr.Navigate().Back();
            Thread.Sleep(2000);
            //forward
            dr.Navigate().Forward();
            //tai lai trang
            Thread.Sleep(2000);
            dr.Navigate().Refresh();
        }

        private void btnbai3_Click(object sender, EventArgs e)
        {
            //tao doi tuong moi
            IWebDriver dr = new ChromeDriver();
            //khai bao url
            dr.Url = "https://www.youtube.com/watch?v=ReyI9VE6Fio&list=PL33lvabfss1ys_UxBqlKvdm6mVs1sL9T2";
            dr.Navigate();
            IWebElement ele = dr.FindElement(By.Name("search_query"));
            ele.SendKeys("doremon");
        }
    }
}
