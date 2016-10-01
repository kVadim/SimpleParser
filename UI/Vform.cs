using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
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
        Dictionary<string, string> comboSource = new Dictionary<string, string>();
        int flag = 0;
        int delay = 0;
        int timespan = 60;
        
        public Vform()
        {
            InitializeComponent();
            URL.Text = "https://bitcoinwisdom.com/";
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
            URL.Text = "https://bitcoinwisdom.com/";
            butStop.Enabled = true;
            N.Enabled = false; 
            URL.ReadOnly = true; 
            butRun.Enabled = false; 
            butBrowse.Enabled = false; 
            butRefresh.Enabled = false;
            isHidden.Enabled = false;
            comboBoxBurse.Enabled = false; 
            comboBoxBurse1.Enabled = false; 
            persentMin.Enabled = false;
            persentMax.Enabled = false;
            label_min.Enabled = false;
            label_max.Enabled = false;
            label_frequency.Enabled = false;
            min.Enabled = false;
            max.Enabled = false;
            flag = 0;
            delay = (int)N.Value;
            # endregion
            if (!backgroundWorker1.IsBusy)
            {
                try
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (NoSuchElementException ex) { URL.Text = ex.Message; URL.Refresh(); backgroundWorker1.ReportProgress(0); }
                catch (Exception ex) { URL.Text = ex.Message; URL.Refresh(); backgroundWorker1.ReportProgress(0); }
                //finally {  }
            }         
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) { butStop.Enabled = false; backgroundWorker1.CancelAsync(); }

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

        public void ShowErrorInURL(string message) { URL.Text = message; URL.BackColor = Color.Red; URL.ForeColor = Color.White; }

        public void CheckDifference()
           {
               if (comboBoxBurse.SelectedIndex == comboBoxBurse1.SelectedIndex) { ShowErrorInURL("Warning:   Monitoring has stopped. Reason - pairs are not defined"); }
               else
               {
                   URL.BackColor = Color.LightGray;
                   URL.ForeColor = Color.Black;

                   Dictionary<int, string> dictionary = new Dictionary<int, string>();
                   dictionary.Add(0, BitstampValue.Text);
                   dictionary.Add(1, BTCvalue.Text);
                   dictionary.Add(2, BitfinexValue.Text);
                   dictionary.Add(3, HuobiValue.Text);

                   double OperandOne = double.Parse(dictionary[comboBoxBurse.SelectedIndex], CultureInfo.InvariantCulture);
                   double OperandTwo = double.Parse(dictionary[comboBoxBurse1.SelectedIndex], CultureInfo.InvariantCulture);

                   string B1 = comboBoxBurse.SelectedItem.ToString();
                   string B2 = comboBoxBurse1.SelectedItem.ToString();
                   string firstB = B1.Substring(1, B1.Length - 5);
                   string secondB = B2.Substring(1, B2.Length - 5);
                   
                   double permin = (double)persentMin.Value;
                   double permax = (double)persentMax.Value;

                   double CurrentPercent = ((OperandOne - OperandTwo) * 200) / (OperandOne + OperandTwo);
                   string actualPercent = Math.Round( CurrentPercent, 3).ToString();
                  
                   if (Math.Abs(CurrentPercent) > permax)
                   {
                       URL.BackColor = Color.Green;
                       URL.ForeColor = Color.White;
                       URL.Refresh();
                       flag++;
                       if (flag * delay > timespan)
                       { 
                           timespan = timespan * 3;
                           SendMessage(actualPercent, permax.ToString(), firstB, secondB); 
                       }
                   }

                   URL.Text = "Current difference:  " + actualPercent + " %" + "   FLAG: " + flag.ToString();
                   URL.Refresh();
               }
           }
        void butBrowse_Click(object sender, EventArgs e)
        {
            //MailMessage objMail = new MailMessage("ParserForKlim@gmail.com", "ParserForKlim@gmail.com", "Check", "This is a test fo.");
            //NetworkCredential objNC = new NetworkCredential("ParserForKlim@gmail.com", "evenuglygirlsarepretty");
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //smtpClient.Port = 587;
            //smtpClient.EnableSsl = true;
            //smtpClient.Credentials = objNC;
            //smtpClient.Send(objMail);
        }

        public void SendMessage(string CurrentPercent, string permax, string B1, string B2)
        {
            string body ="  " + B1 + " - " + B2;
            string subject = CurrentPercent+" / "+permax;


            MailMessage objMail = new MailMessage("ParserForKlim@gmail.com", "ParserForKlim@gmail.com", subject, body);
            NetworkCredential objNC = new NetworkCredential("ParserForKlim@gmail.com", "evenuglygirlsarepretty");
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = objNC;
            smtpClient.Send(objMail);
        }

      

      

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            #region Driver_Initialization
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
            #endregion
           
            int i = 1;
       
            while(true)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(delay * 1000);

                if (backgroundWorker1.CancellationPending) 
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);                   
                    return;
                }
                i++;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;

            try
            {
                ReadData();
            }
            catch (NoSuchElementException ex)
            { URL.Text = "Error: Failed to find elements - please check internet connection"; URL.Refresh(); StopAfterError(); }
            catch (Exception ex) { URL.Text = ex.Message; URL.Refresh(); backgroundWorker1.ReportProgress(0); }

            
            if(max.Checked || min.Checked){ CheckDifference();}
            butRun.Text = i.ToString();
            butRun.Refresh();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            driver.Quit();

            //try
            //{
            //    Runtime.getRuntime().exec("taskkill /F /IM IEDriverServer.exe");
            //}
            //catch (IOException e)
            //{
            //    e.printStackTrace();
            //}
           
            # region Contorl_behavior_after

            URL.BackColor = Color.LightGray;
            URL.ForeColor = Color.Black;
            butRun.Text = "Run"; 
            N.Enabled = true;
            URL.ReadOnly = false;
            butRun.Enabled = true;
            butBrowse.Enabled = true;
            butRefresh.Enabled = true;
            isHidden.Enabled = true;
            comboBoxBurse.Enabled = true;
            comboBoxBurse1.Enabled = true;
            persentMin.Enabled = true;
            persentMax.Enabled = true;
            label_min.Enabled = true;
            label_max.Enabled = true;
            label_frequency.Enabled = true;
            min.Enabled = true;
            max.Enabled = true;
            # endregion
           
        }

        private void StopAfterError()
        {
            driver.Quit();

            # region Contorl_behavior_after

            //URL.BackColor = Color.LightGray;
           // URL.ForeColor = Color.Black;
            butRun.Text = "Run";
            N.Enabled = true;
            URL.ReadOnly = false;
            butRun.Enabled = true;
            butBrowse.Enabled = true;
            butRefresh.Enabled = true;
            isHidden.Enabled = true;
            comboBoxBurse.Enabled = true;
            comboBoxBurse1.Enabled = true;
            persentMin.Enabled = true;
            persentMax.Enabled = true;
            label_min.Enabled = true;
            label_max.Enabled = true;
            label_frequency.Enabled = true;
            min.Enabled = true;
            max.Enabled = true;
            # endregion

        }



        #region Useless_methods
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {

        }

        private void persent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void P2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBurse1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBurse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void countNum_Click(object sender, EventArgs e)
        {

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


        #endregion

    }


}
