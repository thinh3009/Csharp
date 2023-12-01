using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbrowser1_Click(object sender, EventArgs e)
        {
            ChromeDriverService chr=ChromeDriverService.CreateDefaultService();
            chr.HideCommandPromptWindow = true;
            //dieu huong mo trinhf duyet
            IWebDriver driver= new ChromeDriver(chr);
            driver.Navigate().GoToUrl("https://www.google.com/");
            //close
            //driver.Close();
            //input vao o tim kiem
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys(txturl.Text);
        }

        private void btnbroew2_Click(object sender, EventArgs e)
        {
            IWebDriver dr= new ChromeDriver();
            dr.Url = txturl.Text;
            dr.Navigate();
        }
    }
}
