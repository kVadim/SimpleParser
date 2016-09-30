using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Globalization;

namespace SimpleParser01
{
    public partial class Vform : Form
    {
        public static IWebDriver driver;
        int counter = 1000;
        Dictionary<string, string> comboSource = new Dictionary<string, string>();
      
        
        public Vform()
        {
            InitializeComponent();
            URL.Text = "https://bitcoinwisdom.com/";
            N.Value = 5;
            butRun.Select();
           
            comboSource.Add(Bitstamp.Text, BitstampValue.Text);
            comboSource.Add(BTC.Text, BTCvalue.Text);
            comboSource.Add(Bitfinex.Text, BitfinexValue.Text);
            comboSource.Add(Huobi.Text, HuobiValue.Text);

            comboBoxBurse1.DataSource = new BindingSource(comboSource, null); ;
            comboBoxBurse1.DisplayMember = "Key";
            comboBoxBurse1.ValueMember = "Value";

            comboBoxBurse.DataSource = new BindingSource(comboSource, null); ;
            comboBoxBurse.DisplayMember = "Key";
            comboBoxBurse.ValueMember = "Value";
            
        }

        void butRun_Click(object sender, EventArgs e)
        {            
            # region Contorl_behavior_before

            N.Enabled = false; N.Refresh();
            URL.ReadOnly = true; URL.Refresh();
            butRun.Enabled = false; butRun.Refresh();
            butBrowse.Enabled = false; butBrowse.Refresh();
            butRefresh.Enabled = false; butRefresh.Refresh();
            isHidden.Enabled = false;
            comboBoxBurse.Enabled = false; comboBoxBurse.Refresh();
            comboBoxBurse1.Enabled = false; comboBoxBurse1.Refresh();
            persent.Enabled = false; persent.Refresh();
            # endregion
           
            if (!backgroundWorker1.IsBusy) { backgroundWorker1.RunWorkerAsync(); }         
        }

        public void ReadData()
        {

            #region default setting
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                IWebElement bitstamp = driver.FindElement(By.CssSelector("#market_bitstampbtcusd"));
                IWebElement bts = driver.FindElement(By.CssSelector("#market_btcebtcusd"));
                IWebElement bitfinex = driver.FindElement(By.CssSelector("#market_bitfinexbtcusd"));
                IWebElement huobi = driver.FindElement(By.CssSelector("#market_huobibtccny"));
                IWebElement usa = driver.FindElement(By.CssSelector("#o_btcusd>td.r"));
                IWebElement cny = driver.FindElement(By.CssSelector("#o_btccny>td.r"));
            
                BitstampValue.BackColor = Color.Gray;
                BTCvalue.BackColor = Color.Gray;
                BitfinexValue.BackColor = Color.Gray;
                HuobiValue.BackColor = Color.Gray;

                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitstamp, " border: 3px solid black;");
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bts, " border: 3px solid black;");
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitfinex, " border: 3px solid black;");
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", huobi, " border: 3px solid black;");
            # endregion

                if (BitstampValue.Text == "0") { BitstampValue.Text = bitstamp.Text; }
                else if (BitstampValue.Text != bitstamp.Text) { BitstampValue.BackColor = Color.Red; BitstampValue.Text = bitstamp.Text; }
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitstamp, " border: 3px solid red;");
                BitstampValue.Refresh();
              
                if (BTCvalue.Text == "0") { BTCvalue.Text = bts.Text; }
                else if (BTCvalue.Text != bts.Text) { BTCvalue.BackColor = Color.Red; BTCvalue.Text = bts.Text; }
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bts, " border: 3px solid red;");
                BTCvalue.Refresh();

                if (BitfinexValue.Text == "0") { BitfinexValue.Text = bitfinex.Text; }
                else if (BitfinexValue.Text != bitfinex.Text) { BitfinexValue.BackColor = Color.Red; BitfinexValue.Text = bitfinex.Text; }
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitfinex, " border: 3px solid red;");
                BitfinexValue.Refresh();

                string _huobValueInDollars = huobi.Text.ParseHuobi('/');
              
                if (HuobiValue.Text == "0") { HuobiValue.Text = _huobValueInDollars; }
                else if (HuobiValue.Text != _huobValueInDollars) { HuobiValue.BackColor = Color.Red; HuobiValue.Text = _huobValueInDollars; }
                js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", huobi, " border: 3px solid red;");
                HuobiValue.Refresh();



           }

        public void CheckDifference()
           {
               Dictionary<int, string> dictionary =   new Dictionary<int, string>();
               dictionary.Add(0, BitstampValue.Text);
               dictionary.Add(1, BTCvalue.Text);
               dictionary.Add(2, BitfinexValue.Text);
               dictionary.Add(3, HuobiValue.Text);

               double OperandOne = double.Parse(dictionary[comboBoxBurse.SelectedIndex], CultureInfo.InvariantCulture);
               double OperandTwo = double.Parse(dictionary[comboBoxBurse1.SelectedIndex], CultureInfo.InvariantCulture); 
               double per = (double)persent.Value;
               double CurrentPercent = ((OperandOne - OperandTwo) * 100) / OperandOne;
            
               URL.BackColor = Color.LightGray;
               URL.ForeColor = Color.Black;

               if ( CurrentPercent > per )
               {
                   URL.BackColor = Color.Green;
                   URL.ForeColor = Color.White;
                   URL.Refresh();
               }

               URL.Text = "https://bitcoinwisdom.com                                                       " + CurrentPercent.ToString().Substring(0, 5);
               URL.Refresh();
              
           }
        void butBrowse_Click(object sender, EventArgs e)
        {
            MailMessage objMail = new MailMessage("ParserForKlim@gmail.com", "ParserForKlim@gmail.com", "Check", "This is a test fo.");
            NetworkCredential objNC = new NetworkCredential("ParserForKlim@gmail.com", "evenuglygirlsarepretty");
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = objNC;
            smtpClient.Send(objMail);
        }

        private void Vform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void butStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) { backgroundWorker1.CancelAsync(); }
        }

        private void countNum_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (isHidden.Checked == true)
            {
                var driverService = PhantomJSDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                driver = new PhantomJSDriver(driverService);
            }
            else
            {
                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(chromeDriverService, new ChromeOptions());
            }

            driver.Navigate().GoToUrl("https://bitcoinwisdom.com/");
            driver.Manage().Window.Maximize();

            int delay = (int)N.Value;
                    
            for (int i = 0; i < counter; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(delay * 1000);

                if (backgroundWorker1.CancellationPending) 
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            driver.Quit();
       
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;          
            ReadData();
            CheckDifference();
            butRun.Text = (counter - 1 - i).ToString();
            butRun.Refresh();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            driver.Quit();
           
            # region Contorl_behavior_after
            URL.BackColor = Color.LightGray;
            URL.ForeColor = Color.Black;
            N.ReadOnly = false; 
            URL.ReadOnly = false;                  
            butRun.Enabled = true;               
            butBrowse.Enabled = true;            
            butRun.Text = "Run";             
            butRefresh.Enabled = true;  
            isHidden.Enabled = true;  
            comboBoxBurse.Enabled = true;  
            comboBoxBurse1.Enabled = true; 
            persent.Enabled = true; 
            # endregion
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {

        }
    }


    public static class Utils
    {
        public static string ParseHuobi(this string houbisting, char ch)
        {
            if (houbisting.Contains(ch))
            {
                houbisting = houbisting.Substring(0, 6);
            }
            else
            {
                double result = double.Parse(houbisting, CultureInfo.InvariantCulture)/6.67;           
                houbisting = "** " + result.ToString().Substring(0, 6) + " **";
            }
            return houbisting;
        }
    }
}
