﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Globalization;
using System.Diagnostics;

namespace SimpleParser01
{
    public partial class Vform : Form
    {
        public static IWebDriver driver;
        IJavaScriptExecutor js;
        Dictionary<string, string> comboSource = new Dictionary<string, string>();
        int flag, underflag;
        int delay;
        int tryToConnect;
        Process[] processes;
        DateTime dt;
        DateTime dt_last_sent_max, dt_last_sent_min;
        bool exception;
        bool sent, sent_min;
        bool Hidden;
        bool iconnection, iconnection_Flag;
        double permin, permax; 
        double interval;
        double CNYvalue;       
        string firstB,secondB;
        string CNYvalueIfcheckd;
        string error_subject, error_body;


                   
        public Vform()
        {
            InitializeComponent();
            MaximizeBox = false;
            URL.Text = "https://bitcoinwisdom.com/";
            butRun.Select();
            comboSource.Add(Bitstamp.Text, BitstampValue.Text);
            comboSource.Add(BTC.Text, BTCvalue.Text);
            comboSource.Add(Bitfinex.Text, BitfinexValue.Text);
            comboSource.Add(Huobi.Text, HuobiValue.Text);

            comboBoxBurse1.DataSource = new BindingSource(comboSource, null); ;
            comboBoxBurse1.DisplayMember = "Key";
            comboBoxBurse1.ValueMember = "Value";
            comboBoxBurse1.SelectedIndex = 1;

            comboBoxBurse.DataSource = new BindingSource(comboSource, null); ;
            comboBoxBurse.DisplayMember = "Key";
            comboBoxBurse.ValueMember = "Value";
            comboBoxBurse.SelectedIndex = 3;
        }


        void butRun_Click(object sender, EventArgs e)
        {            
            # region Contorl_behavior_before
            URL.Text = "https://bitcoinwisdom.com/";
            URL.BackColor = Color.LightGray;
            URL.ForeColor = Color.Black;
            butStop.Enabled = true;
            N.Enabled = false;
            M.Enabled = false;
            cny_checkBox.Enabled = false;
            CNY.Enabled = false; 
            URL.ReadOnly = true; 
            butRun.Enabled = false; 
            butRefresh.Enabled = false;
            isHidden.Enabled = false;
            comboBoxBurse.Enabled = false; 
            comboBoxBurse1.Enabled = false; 
            persentMin.Enabled = false;
            persentMax.Enabled = false;
            label_min.Enabled = false;
            label_max.Enabled = false;
            label_frequency.Enabled = false;
            label_mins.Enabled = false;
            label_cny.Enabled = false;
            min.Enabled = false;
            max.Enabled = false;           
            # endregion
            
            error_body = "";
            exception = false;
            sent = false;
            sent_min = false;
            Hidden = isHidden.Checked;
            permin = (double)persentMin.Value;
            permax = (double)persentMax.Value;
            CNYvalue = (double)CNY.Value;
            interval = (double)M.Value * 60 - (double)N.Value;
            delay = (int)N.Value;
            flag = 0;
            underflag = 0;
            string B1 = comboBoxBurse.SelectedItem.ToString();
            string B2 = comboBoxBurse1.SelectedItem.ToString();
            firstB = B1.Substring(1, B1.Length - 5);
            secondB = B2.Substring(1, B2.Length - 5);


            if (cny_checkBox.Checked)   {CNYvalueIfcheckd = CNYvalue.ToString();}  else { CNYvalueIfcheckd = "NaN "; }
            if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
            iconnection = iconnection_Flag = CheckConnection();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) { backgroundWorker1.CancelAsync(); }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            #region Driver_Initialization
            if (Hidden == true)
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

                js = (IJavaScriptExecutor)driver;
            }
            driver.Navigate().GoToUrl("https://bitcoinwisdom.com/");
            driver.Manage().Window.Maximize();
            #endregion

            int i = 1;
            int y = 1;          

            while (!exception)
            {
                if (y == 6) { iconnection = CheckConnection(); y = 0; }
                if (!iconnection && iconnection_Flag)
                {                   
                    iconnection_Flag = false;
                    driver.Quit();
                    error_subject = "Connection lost from: " + DateTime.Now.ToString("HH:mm:ss");                             
                }
                if (iconnection  && !iconnection_Flag)
                {
                    driver.Navigate().GoToUrl("https://bitcoinwisdom.com/");
                    iconnection_Flag = true; 
                    error_body = "...till... " + DateTime.Now.ToString("HH:mm:ss");                  
                    Thread.Sleep(2000);
                    SendMessage(error_subject, error_body); 
                }

                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(delay * 1000);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
                i++;
                y++;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;

            try
            {
                if (iconnection_Flag) { ReadData(); }
                exception = false;
                tryToConnect = 0;
            }
            catch (Exception ex)
            {
                exception = true;
                ShowErrorInURL("Error: Failed to find elements - please check internet connection");
            }

           
            if (!iconnection_Flag) 
            { 
                ShowErrorInURL(error_subject);
            }
            else if (max.Checked || min.Checked)
            {
                CheckDifference(); 
            }
            else 
            {
                ShowOKInURL("https://bitcoinwisdom.com/"); 
            }


            butRun.Text = i.ToString();
            butRun.Refresh();
        }


        public void ReadData()
        {

            #region default setting
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

                if (Hidden == false)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitstamp, " border: 3px solid black;");
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bts, " border: 3px solid black;");
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitfinex, " border: 3px solid black;");
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", huobi, " border: 3px solid black;");
                }
            # endregion

                if (BitstampValue.Text == "0") { BitstampValue.Text = bitstamp.Text; }
                else if (BitstampValue.Text != bitstamp.Text) { BitstampValue.BackColor = Color.Red; BitstampValue.Text = bitstamp.Text; }
                if (Hidden == false)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitstamp, " border: 3px solid red;");
                }
                BitstampValue.Refresh();
              
                if (BTCvalue.Text == "0") { BTCvalue.Text = bts.Text; }
                else if (BTCvalue.Text != bts.Text) { BTCvalue.BackColor = Color.Red; BTCvalue.Text = bts.Text; }
                if (Hidden == false)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bts, " border: 3px solid red;");
                }
                BTCvalue.Refresh();

                if (BitfinexValue.Text == "0") { BitfinexValue.Text = bitfinex.Text; }
                else if (BitfinexValue.Text != bitfinex.Text) { BitfinexValue.BackColor = Color.Red; BitfinexValue.Text = bitfinex.Text; }
                if (Hidden == false)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitfinex, " border: 3px solid red;");
                }
                BitfinexValue.Refresh();


                string _huobValueInDollars = huobi.Text.ParseHuobi('/', CNYvalue, cny_checkBox.Checked);
              
                if (HuobiValue.Text == "0") { HuobiValue.Text = _huobValueInDollars; }
                else if (HuobiValue.Text != _huobValueInDollars) { HuobiValue.BackColor = Color.Red; HuobiValue.Text = _huobValueInDollars; }
                if (Hidden == false)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", huobi, " border: 3px solid red;");
                }
                HuobiValue.Refresh();



           }


        public void CheckDifference()
           {
               if (comboBoxBurse.SelectedIndex == comboBoxBurse1.SelectedIndex) { ShowErrorInURL("Warning:   Monitoring has stopped. Reason - pairs are not defined"); }
               else
               {
                   dt = DateTime.Now;

                   if (!exception )
                   {
                       URL.BackColor = Color.LightGray;
                       URL.ForeColor = Color.Black;
                   }
                  
                   Dictionary<int, string> dictionary = new Dictionary<int, string>();
                   dictionary.Add(0, BitstampValue.Text);
                   dictionary.Add(1, BTCvalue.Text);
                   dictionary.Add(2, BitfinexValue.Text);
                   dictionary.Add(3, HuobiValue.Text);

                   double OperandOne = double.Parse(dictionary[comboBoxBurse.SelectedIndex], CultureInfo.InvariantCulture);
                   double OperandTwo = double.Parse(dictionary[comboBoxBurse1.SelectedIndex], CultureInfo.InvariantCulture);
                           
                   double CurrentPercent = ((OperandOne - OperandTwo) * 200) / (OperandOne + OperandTwo);
                   string actualPercent = Math.Round(CurrentPercent, 2).ToString("0.00");
               
                   string body = "........." + firstB + " - " + secondB + ".......CNY: " + CNYvalueIfcheckd+ "..........." + String.Format("{0:T}", dt);

                   string subject_max = "MAX Diff:  " + actualPercent + " > " + permax + "%";
                   string subject_min = "min Diff:  " + actualPercent + " < " + permin + "%";
                  
                   if (max.Checked && Math.Abs(CurrentPercent) > permax)
                   {
                       URL.BackColor = Color.Green;
                       URL.ForeColor = Color.White;
                       URL.Refresh();
                       flag++;
                      

                       if (sent == false)
                       {
                           SendMessage(subject_max, body);
                           sent = true;
                           dt_last_sent_max=dt;
                       }
                       if (dt > dt_last_sent_max.AddSeconds(interval))
                       {
                           sent = false;
                       }

                   }
                   if ( max.Checked && Math.Abs(CurrentPercent) < permax )
                   {
                       if (dt > dt_last_sent_max.AddSeconds(interval) && sent == true)
                       {
                           SendMessage(subject_max, body + ".....NEGATIVE");
                           sent = false;
                       }                    

                   }

                   if (min.Checked && CurrentPercent < permin)
                   {
                       URL.BackColor = Color.Blue;
                       URL.ForeColor = Color.White;
                       URL.Refresh();
                       underflag++;


                       if (sent_min == false)
                       {
                           SendMessage(subject_min, body);
                           sent_min = true;
                           dt_last_sent_min = dt;
                       }
                       if (dt > dt_last_sent_min.AddSeconds(interval))
                       {
                           sent_min = false;
                       }

                   }
                   if (min.Checked && CurrentPercent > permin)
                   {
                       if (dt > dt_last_sent_min.AddSeconds(interval) && sent_min == true)
                       {
                           SendMessage(subject_min, body + ".....NEGATIVE");
                           sent_min = false;
                       }

                   }
                   if (!exception)
                   {
                       URL.Text = "Current difference:  " + actualPercent + " %" + "   __FMax: " + flag.ToString() + "   __FMin: " + underflag.ToString() + "  ___time: " + String.Format("{0:T}", dt) + "___" + iconnection;
                       URL.Refresh();
                   }
               }
           }
       

        public void SendMessage(string subject, string body)
        {
            try
            {
                MailMessage objMail = new MailMessage("ParserForKlim@gmail.com", "ParserForKlim@gmail.com", subject, body);
                NetworkCredential objNC = new NetworkCredential("ParserForKlim@gmail.com", "evenuglygirlsarepretty");
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = objNC;
                smtpClient.Send(objMail);
            }
            catch
            {

            }
          
        }

        public void ShowErrorInURL(string message)
        { URL.Text = message; URL.BackColor = Color.Red; URL.ForeColor = Color.White; URL.Refresh(); }

        public void ShowOKInURL(string message)
        { URL.Text = message; URL.BackColor = Color.LightGray; URL.ForeColor = Color.Black; URL.Refresh(); }
      
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            driver.Quit();
            RemovePhantomjsProcesses();          

            # region Contorl_behavior_after
            butStop.Enabled = false;
            if (!exception)
            {
                URL.BackColor = Color.LightGray;
                URL.ForeColor = Color.Black;
            }
            butRun.Text = "Run"; 
            N.Enabled = true;
            M.Enabled = true;
            cny_checkBox.Enabled = true;
            CNY.Enabled = true;
            URL.ReadOnly = false;
            butRun.Enabled = true;
            butRefresh.Enabled = true;
            isHidden.Enabled = true;
            comboBoxBurse.Enabled = true;
            comboBoxBurse1.Enabled = true;
            persentMin.Enabled = true;
            persentMax.Enabled = true;
            label_min.Enabled = true;
            label_max.Enabled = true;
            label_frequency.Enabled = true;
            label_mins.Enabled = true;
            label_cny.Enabled = true;
            min.Enabled = true;
            max.Enabled = true;
            # endregion

                
            if (exception == true ) 
            {
                tryToConnect++;

                if (tryToConnect < 9)
                {
                    Thread.Sleep(7000);
                    this.butRun_Click(this, e);
                }
                //else if (tryToConnect == 9)
                //{
                //    Thread.Sleep(900000);
                //    tryToConnect = 0;
                //    this.butRun_Click(this, e);
                //}
            }
            
        }

   
        public void RemovePhantomjsProcesses()
        {
           Thread.Sleep(1000);
           processes = Process.GetProcessesByName("phantomjs");
           if (processes.Length > 0) { foreach (Process p in processes) { p.Kill(); } }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                ShowIcon = false;
                simpleParser.Visible = true;
                simpleParser.ShowBalloonTip(1000);
            
            }
        }

      

        public bool CheckConnection()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }













        #region Useless_methods
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
            
            simpleParser.BalloonTipTitle = "SimpleParser";
            simpleParser.BalloonTipText = "see you";

            
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
            simpleParser.Visible = false;
            WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void butReport_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBurse1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void isHidden_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Vform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread.Sleep(1700);
            RemovePhantomjsProcesses();
        }

       

    }


}
