using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.IE;
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
using Microsoft.Win32;
using OpenQA.Selenium.Interactions;

namespace SimpleParser01
{
    public partial class Vform : Form
    {
        #region Common_variables
        public static IWebDriver driver;
        IJavaScriptExecutor js;
        Process[] processes;
        Dictionary<string, string> comboSource = new Dictionary<string, string>();
        Dictionary<string, string> comboSource2 = new Dictionary<string, string>();
        string okcoin_Btccny_Handle, btcchina_Btccny_Handle, huobi_Btccny_Handle;
        string okcoinBtccnyCurrentValue, btcchinaBtccnyCurrentValue, huobiBtccnyCurrentValue;
        string firstBurseName, secondBurseName;   // selected burse names for letters
        string CNYvalueIfcheckd;   //cny valut if checkbox checked
        bool iconnection;         
        bool iconnection_Flag;      //check connection at start
        bool exception;             //false at start and becomes true if "try" fails while doing ReadData()
        int tryToConnect;           // set equal to 0 in "try" passes while doing ReadData()

        //unchecked
        int flag, underflag;
        int delay;            
        DateTime dt;
        DateTime dt_start_max, dt_start_min;
        DateTime dt_last_sent_max, dt_last_sent_min;       
        bool sent, sent_min;       
        double permin, permax; 
        double interval;
        double CNYvalue;             
        
        string error_subject, error_body;
        #endregion
  
        public Vform()                                     
        {
            InitializeComponent();
            MaximizeBox = false;                           //????? maximaze from tray
           // URL.Text = "https://bitcoinwisdom.com/";     //Moved to properties should be deleted in 0.9
            butRun.Select();                               //Focus on Run button
            #region Comboboxes initializing   +++              
            comboSource.Add(Bitstamp.Text, BitstampValue.Text);
            comboSource.Add(BTC.Text, BTCvalue.Text);
            comboSource.Add(Bitfinex.Text, BitfinexValue.Text);
            comboSource.Add(Huobi.Text, HuobiValue.Text);

            comboSource2.Add(label_OkcoinBtccny.Text, label_OkcoinValue.Text);
            comboSource2.Add(label_BtcchinaBtccny.Text, label_BtcchinaValue.Text);
            comboSource2.Add(label_HuobiBtccny.Text, label_HuobiValue.Text);         

            cmbBoxBurse2.DataSource = new BindingSource(comboSource, null); ;
            cmbBoxBurse2.DisplayMember = "Key";
            cmbBoxBurse2.ValueMember = "Value";
            cmbBoxBurse2.SelectedIndex = 1;

            cmbBoxBurse.DataSource = new BindingSource(comboSource, null); ;
            cmbBoxBurse.DisplayMember = "Key";
            cmbBoxBurse.ValueMember = "Value";
            cmbBoxBurse.SelectedIndex = 3;

            cmbBoxBurse3.DataSource = new BindingSource(comboSource2, null); ;
            cmbBoxBurse3.DisplayMember = "Key";
            cmbBoxBurse3.ValueMember = "Value";
            cmbBoxBurse3.SelectedIndex = 2;

            cmbBoxBurse4.DataSource = new BindingSource(comboSource2, null); ;
            cmbBoxBurse4.DisplayMember = "Key";
            cmbBoxBurse4.ValueMember = "Value";
            cmbBoxBurse4.SelectedIndex = 1;
            #endregion
        }

        void butRun_Click(object sender, EventArgs e)
        {            
            # region Contorl_behavior_before +++
            butReport.Enabled = false;
            checkBox_min.Enabled = false;
            checkBox_max.Enabled = false;
            checkBox_cny.Enabled = false;
            radioBtn1.Enabled = false;
            checkBox_isHidden.Enabled = false;
            cmbBoxBurse.Enabled = false;
            cmbBoxBurse2.Enabled = false;
            cmbBoxBurse3.Enabled = false;
            cmbBoxBurse4.Enabled = false;
            counter_Seconds.Enabled = false;
            counter_Minutes.Enabled = false;
            counter_Min.Enabled = false;
            counter_Max.Enabled = false;
            counter_CNY.Enabled = false; 
            URL.Text = "https://bitcoinwisdom.com/";
            URL.BackColor = Color.LightGray;
            URL.ForeColor = Color.Black;
            URL.ReadOnly = true; 
            butStop.Enabled = true;           
            butRun.Enabled = false;                    
            label_min.Enabled = false;
            label_max.Enabled = false;
            label_frequency.Enabled = false;
            label_mins.Enabled = false;
            label_cny.Enabled = false;
            if (radioBtn1.Checked)
            {
                Bitstamp.Enabled = false;
                BTC.Enabled = false;
                Huobi.Enabled = false;
                Bitfinex.Enabled = false;
                HuobiValue.Enabled = false;
                BitfinexValue.Enabled = false;
                BTCvalue.Enabled = false;
                BitstampValue.Enabled = false;
            }
            else
            {
                label_BtcchinaBtccny.Enabled = false;
                label_OkcoinBtccny.Enabled = false;
                label_HuobiBtccny.Enabled = false;
                label_HuobiValue.Enabled = false;
                label_BtcchinaValue.Enabled = false;
                label_OkcoinValue.Enabled = false;
            }
            radioBtn1.Enabled = false;
            radioBtn2.Enabled = false;
            # endregion

            # region Variable_behavior_before --- 
            error_body = ""; 
            exception = false;
            sent = false;
            sent_min = false;
            //Hidden = checkBox_isHidden.Checked;
            permin = (double)counter_Min.Value;
            permax = (double)counter_Max.Value;
            CNYvalue = (double)counter_CNY.Value;
            interval = (double)counter_Minutes.Value * 60 - (double)counter_Seconds.Value;
            delay = (int)counter_Seconds.Value;
            flag = 0;
            underflag = 0;
            #endregion

            # region Getting selected burse names

            if (radioBtn1.Checked)
            {
                firstBurseName = cmbBoxBurse3.SelectedItem.ToString().Substring(1, cmbBoxBurse3.SelectedItem.ToString().Length - 5);
                secondBurseName = cmbBoxBurse4.SelectedItem.ToString().Substring(1, cmbBoxBurse4.SelectedItem.ToString().Length - 5);           
            }
            else
            {
                firstBurseName = cmbBoxBurse.SelectedItem.ToString().Substring(1, cmbBoxBurse.SelectedItem.ToString().Length - 5);
                secondBurseName = cmbBoxBurse2.SelectedItem.ToString().Substring(1, cmbBoxBurse2.SelectedItem.ToString().Length - 5);
            }

            #endregion

            iconnection = iconnection_Flag = CheckConnection();  //unclear why we check connection here
            if (checkBox_cny.Checked)   
            {CNYvalueIfcheckd = CNYvalue.ToString();}  else { CNYvalueIfcheckd = "NaN "; }  //unclear
            if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
        }

        private void butStop_Click(object sender, EventArgs e)  //+++
        {
            if (backgroundWorker1.IsBusy) { backgroundWorker1.CancelAsync(); }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;

            #region Driver_Initialization +++
            if (checkBox_isHidden.Checked)
            {
                var driverService = PhantomJSDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                driver = new PhantomJSDriver(driverService);
                js = (IJavaScriptExecutor)driver;
            }
            else
            {
                var chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(chromeDriverService, new ChromeOptions());

                js = (IJavaScriptExecutor)driver;
            }
            
            if (radioBtn1.Checked){

                driver.Navigate().GoToUrl("https://bitcoinwisdom.com/markets/okcoin/btccny");
                driver.Manage().Window.Maximize();
                js.ExecuteScript("window.open();");
                js.ExecuteScript("window.open();");
                List<string> tabs = new List<string>(driver.WindowHandles);
                driver.SwitchTo().Window(tabs[1]);
                driver.Navigate().GoToUrl("https://bitcoinwisdom.com/markets/btcchina/btccny");
                driver.SwitchTo().Window(tabs[2]);
                driver.Navigate().GoToUrl("https://bitcoinwisdom.com/markets/huobi/btccny");
                okcoin_Btccny_Handle = tabs[0];   
                btcchina_Btccny_Handle = tabs[1];
                huobi_Btccny_Handle = tabs[2];       

            }
            else{
                driver.Navigate().GoToUrl("https://bitcoinwisdom.com/");
                driver.Manage().Window.Maximize();
            }

            #endregion
            iconnection = iconnection_Flag = CheckConnection();
            #region Exception handling ---
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
            #endregion
        }

        void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e) //---
        {
         //   if (e.Mode == PowerModes.Suspend) PauseTimer();
          //  else if (e.Mode == PowerModes.Resume) ResumeTimer();
        }



        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;

            try
            {
                if (iconnection_Flag) { ReadData(); }   //if good connection - read data
                exception = false;                      // set exception flag -  false   ?????? unclear place
                tryToConnect = 0;
            }
            catch (Exception ex)
            {
                exception = true;
                ShowErrorInURL("Error: Failed to find elements - please check internet connection");
            }

           
            if (!iconnection_Flag) 
            { 
                ShowErrorInURL(error_subject);    //unclear what should be here
            }
            else if (checkBox_max.Checked || checkBox_min.Checked )
            {              
                CheckDifference(i);               
            }
            else 
            {
                ShowOKInURL("https://bitcoinwisdom.com/");
            }

            #region suggestion

            #endregion
        }

        public void ReadData() //++
        {
            if (radioBtn1.Checked){
                // add red highlites for explicit mode
                #region get data from page +++
                char[] _splitchar = { ' ' };
                string _currentTitle;

                _currentTitle = driver.SwitchTo().Window(btcchina_Btccny_Handle).Title;
                string[] btcchina_Title = _currentTitle.Split(_splitchar); 
                btcchinaBtccnyCurrentValue = btcchina_Title[0];

                _currentTitle = driver.SwitchTo().Window(okcoin_Btccny_Handle).Title;
                string[] okcoin_Title = _currentTitle.Split(_splitchar); 
                okcoinBtccnyCurrentValue = okcoin_Title[0];

                _currentTitle = driver.SwitchTo().Window(huobi_Btccny_Handle).Title;
                string[] huobi_Title = _currentTitle.Split(_splitchar); 
                huobiBtccnyCurrentValue = huobi_Title[0];
                #endregion

                #region set all 3 tables to default color Gray +++
                label_OkcoinValue.BackColor = Color.Gray;
                label_BtcchinaValue.BackColor = Color.Gray;
                label_HuobiValue.BackColor = Color.Gray;
                # endregion

                #region show data in tables
                if (label_OkcoinValue.Text != "0" && label_OkcoinValue.Text != okcoinBtccnyCurrentValue) 
                { 
                    label_OkcoinValue.BackColor = Color.Red;
                }
                label_OkcoinValue.Text = okcoinBtccnyCurrentValue;
                label_OkcoinValue.Refresh();

                if (label_BtcchinaValue.Text != "0" && label_BtcchinaValue.Text != btcchinaBtccnyCurrentValue)
                {
                    label_BtcchinaValue.BackColor = Color.Red;
                }
                label_BtcchinaValue.Text = btcchinaBtccnyCurrentValue;
                label_BtcchinaValue.Refresh();

                if (label_HuobiValue.Text != "0" && label_HuobiValue.Text != huobiBtccnyCurrentValue)
                {
                    label_HuobiValue.BackColor = Color.Red;
                }
                label_HuobiValue.Text = huobiBtccnyCurrentValue;
                label_HuobiValue.Refresh();
                #endregion
            }
            else {

                #region read elements from page --- 

                IWebElement bitstamp = driver.FindElement(By.CssSelector("#market_bitstampbtcusd"));
                IWebElement bts = driver.FindElement(By.CssSelector("#market_btcebtcusd"));
                IWebElement bitfinex = driver.FindElement(By.CssSelector("#market_bitfinexbtcusd"));
                IWebElement huobi = driver.FindElement(By.CssSelector("#market_huobibtccny"));

                //IWebElement usa = driver.FindElement(By.CssSelector("#o_btcusd>td.r"));
                //IWebElement cny = driver.FindElement(By.CssSelector("#o_btccny>td.r"));
                #endregion

                #region set all 4 tables to default color Gray +++

                BitstampValue.BackColor = Color.Gray;
                BTCvalue.BackColor = Color.Gray;
                BitfinexValue.BackColor = Color.Gray;
                HuobiValue.BackColor = Color.Gray;

                # endregion

                #region set all highlites to default color black +++

                if (!checkBox_isHidden.Checked)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitstamp, " border: 3px solid black;");
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bts, " border: 3px solid black;");
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitfinex, " border: 3px solid black;");
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", huobi, " border: 3px solid black;");
                }
                # endregion

                #region show data in tables +++

                if (BitstampValue.Text != "0" && BitstampValue.Text != bitstamp.Text)
                { 
                    BitstampValue.BackColor = Color.Red;
                }
                if (!checkBox_isHidden.Checked)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitstamp, " border: 3px solid red;");
                }
                BitstampValue.Text = bitstamp.Text;
                BitstampValue.Refresh();

                
                if (BTCvalue.Text != "0" && BTCvalue.Text != bts.Text) 
                {
                    BTCvalue.BackColor = Color.Red; 
                }
                if (!checkBox_isHidden.Checked)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bts, " border: 3px solid red;");
                }
                BTCvalue.Text = bts.Text;
                BTCvalue.Refresh();

                if (BitfinexValue.Text != "0" && BitfinexValue.Text != bitfinex.Text) 
                { 
                    BitfinexValue.BackColor = Color.Red;
                }
                if (!checkBox_isHidden.Checked)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", bitfinex, " border: 3px solid red;");
                }
                BitfinexValue.Text = bitfinex.Text;
                BitfinexValue.Refresh();


                string _huobValueInDollars = huobi.Text.ParseHuobi('/', CNYvalue, checkBox_cny.Checked);
                
                if (HuobiValue.Text != "0" && HuobiValue.Text != _huobValueInDollars) 
                { 
                    HuobiValue.BackColor = Color.Red;  
                }
                if (checkBox_isHidden.Checked)
                {
                    js.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);", huobi, " border: 3px solid red;");
                }
                HuobiValue.Text = _huobValueInDollars;
                HuobiValue.Refresh();

                #endregion
            }
        }

        public void CheckDifference(int i)
        {
            if (radioBtn1.Checked && cmbBoxBurse3.SelectedIndex == cmbBoxBurse4.SelectedIndex || radioBtn1.Checked && cmbBoxBurse.SelectedIndex == cmbBoxBurse2.SelectedIndex)
            {
                ShowErrorInURL("Warning:   Monitoring has stopped. Reason - pairs are not defined");
            }
            else
            {

                double OperandOne = 0;
                double OperandTwo = 0;
                Dictionary<int, string> dictionary = new Dictionary<int, string>();

                #region separate code +++
                if (radioBtn1.Checked)
                {

                    dictionary.Add(0, label_OkcoinValue.Text);
                    dictionary.Add(1, label_BtcchinaValue.Text);
                    dictionary.Add(2, label_HuobiValue.Text);

                    OperandOne = double.Parse(dictionary[cmbBoxBurse3.SelectedIndex], CultureInfo.InvariantCulture);
                    OperandTwo = double.Parse(dictionary[cmbBoxBurse4.SelectedIndex], CultureInfo.InvariantCulture);
                }
                else
                {
                    dictionary.Add(0, BitstampValue.Text);
                    dictionary.Add(1, BTCvalue.Text);
                    dictionary.Add(2, BitfinexValue.Text);
                    dictionary.Add(3, HuobiValue.Text);

                    OperandOne = double.Parse(dictionary[cmbBoxBurse.SelectedIndex], CultureInfo.InvariantCulture);
                    OperandTwo = double.Parse(dictionary[cmbBoxBurse2.SelectedIndex], CultureInfo.InvariantCulture);
                }

                #endregion

                #region common code

                dt = DateTime.Now;
                if (!exception)
                {
                    URL.BackColor = Color.LightGray;
                    URL.ForeColor = Color.Black;
                }

                string OpOne = Math.Round(OperandOne, 2).ToString("0.00");
                string OpTwo = Math.Round(OperandTwo, 2).ToString("0.00");

                double CurrentPercent;

                if (OperandOne != 0 || OperandTwo != 0)
                {
                    CurrentPercent = ((OperandOne - OperandTwo) * 200) / (OperandOne + OperandTwo);
                }
                else { CurrentPercent = 0; }

                string actualPercent = Math.Round(CurrentPercent, 2).ToString("0.00");
                string body = OpOne +" "+ firstBurseName + " - " + secondBurseName +" "+ OpTwo +" "+ " CNY: " + CNYvalueIfcheckd +" "+ String.Format("{0:T}", dt);


                string subject_max = "MAX Diff:  " + actualPercent + " > " + permax + "%";
                string subject_min = "min Diff:  " + actualPercent + " < " + permin + "%";

                string subject_max_negative = "MAX Diff:  " + actualPercent + " is not > " + permax + "%";
                string subject_min_negative = "min Diff:  " + actualPercent + " is not < " + permin + "%";

                if (checkBox_max.Checked)
                {
                    if (i == 1) { dt_start_max = dt; SendMessage("Start", body + "\r\n" + " Started MAX Expected " + permax + " % (actual: " + actualPercent + " %)"); }
                    if (dt > dt_start_max.AddDays(1)) { dt_start_max = dt; SendMessage("Daily check MAX", String.Format("{0:f}", dt)); }
                    if (CurrentPercent > permax)
                    {
                        URL.BackColor = Color.Green; URL.ForeColor = Color.White; URL.Refresh(); flag++;
                        if (sent == false)
                        {
                            SendMessage(subject_max, body);
                            sent = true;
                            dt_last_sent_max = dt;
                        }
                        if (dt > dt_last_sent_max.AddSeconds(interval)) {sent = false;}
                    }
                    else
                    {
                        if (dt > dt_last_sent_max.AddSeconds(interval) && sent == true)
                        {
                            SendMessage(subject_max_negative, body + "\r\n" + "Parser starts from the beginning");
                            sent = false;
                        }
                    }
                }
                if (checkBox_min.Checked)
                {
                    if (i == 1) { dt_start_min = dt; SendMessage("Start min", body + "\r\n" + " Started min Expected " + permin + " % (actual: " + actualPercent + " %)"); }
                    if (dt > dt_start_min.AddDays(1)) { dt_start_min = dt; SendMessage("Daily check min", String.Format("{0:f}", dt)); }
                    if (CurrentPercent < permin)
                    {
                        URL.BackColor = Color.Blue; URL.ForeColor = Color.White; URL.Refresh(); underflag++;
                        if (sent_min == false)
                        {
                            SendMessage(subject_min, body);
                            sent_min = true;
                            dt_last_sent_min = dt;
                        }
                        if (dt > dt_last_sent_min.AddSeconds(interval)) { sent_min = false; }
                    }
                    else
                    {
                        if (dt > dt_last_sent_min.AddSeconds(interval) && sent_min == true)
                        {
                            SendMessage(subject_min_negative, body + "\r\n" + "Parser starts from the beginning");
                            sent_min = false;
                        }

                    }
                }
                
                if (!exception)
                {
                    URL.Text = "Difference: " + actualPercent + " %" + "FMax ".PadLeft(10) + flag.ToString() + "/" + i.ToString().PadRight(10) + "FMin: " + underflag.ToString() + "/" + i.ToString().PadRight(10) + "time: " + String.Format("{0:T}", dt).PadRight(15) + iconnection;
                    URL.Refresh();
                }
            }              
            #endregion
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
          //  butRun.Text = "Run"; 
            checkBox_min.Enabled = true;
            checkBox_max.Enabled = true;
            checkBox_cny.Enabled = true;
            radioBtn1.Enabled = true;
            checkBox_isHidden.Enabled = true;
            if (radioBtn1.Checked)
            {
                cmbBoxBurse3.Enabled = true;
                cmbBoxBurse4.Enabled = true;
            }
            else
            {
                cmbBoxBurse.Enabled = true;
                cmbBoxBurse2.Enabled = true;          
            }           
            counter_Min.Enabled = true;
            counter_Max.Enabled = true;
            counter_Seconds.Enabled = true;
            counter_Minutes.Enabled = true;
            counter_CNY.Enabled = true;
            URL.ReadOnly = false;
            butRun.Enabled = true;            
            label_min.Enabled = true;
            label_max.Enabled = true;
            label_frequency.Enabled = true;
            label_mins.Enabled = true;
            label_cny.Enabled = true;
            Bitstamp.Enabled = true;
            BTC.Enabled = true;
            Huobi.Enabled = true;
            Bitfinex.Enabled = true;
            label_BtcchinaBtccny.Enabled = true;
            label_OkcoinBtccny.Enabled = true;
            label_HuobiBtccny.Enabled = true;
            label_HuobiValue.Enabled = true;
            label_BtcchinaValue.Enabled = true;
            label_OkcoinValue.Enabled = true;
            HuobiValue.Enabled = true;
            BitfinexValue.Enabled = true;
            BTCvalue.Enabled = true;
            BitstampValue.Enabled = true;
            radioBtn1.Enabled = true;
            radioBtn2.Enabled = true;
            butReport.Enabled = true;
            # endregion

                
            if (exception == true ) 
            {
                tryToConnect++;

                if (tryToConnect < 3)
                {
                    Thread.Sleep(7000);
                    this.butRun_Click(this, e);
                }
            }
        }

        public void RemovePhantomjsProcesses()
        {
           Thread.Sleep(1000);
           processes = Process.GetProcessesByName("phantomjs");
           if (processes.Length > 0) { foreach (Process p in processes) { p.Kill(); } }
        }
    
        public bool CheckConnection()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }

        private void Vform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread.Sleep(1700);
            RemovePhantomjsProcesses();
        }





        #region Tray
        private void Tray(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                ShowIcon = false;
                simpleParser.Visible = true;
               // simpleParser.ShowBalloonTip(400);

            }
        }

        private void Vform_Load(object sender, EventArgs e)
        {
          //  simpleParser.BalloonTipTitle = "SimpleParser";
            simpleParser.BalloonTipText = "see you";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
           // ShowInTaskbar = true;
            simpleParser.Visible = false;
            WindowState = FormWindowState.Normal;
         //   this.Show();
        }
        #endregion

        #region Useless_methods
        private void butReport_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }
        #endregion

        private void cmbBoxBurse4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_isHidden_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxBurse.Enabled = false;
            cmbBoxBurse2.Enabled = false;
            cmbBoxBurse3.Enabled = true;
            cmbBoxBurse4.Enabled = true;

            HuobiValue.Visible = false;
            BTCvalue.Visible = false;
            BitfinexValue.Visible = false;
            BitstampValue.Visible = false;
            Huobi.Visible = false;
            BTC.Visible = false;
            Bitfinex.Visible = false;
            Bitstamp.Visible = false;

            label_HuobiValue.Visible = true;
            label_BtcchinaValue.Visible = true;
            label_OkcoinValue.Visible = true;
            label_OkcoinBtccny.Visible = true;
            label_HuobiBtccny.Visible = true;
            label_BtcchinaBtccny.Visible = true;
        }

        private void radioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxBurse.Enabled = true;
            cmbBoxBurse2.Enabled = true;
            cmbBoxBurse3.Enabled = false;
            cmbBoxBurse4.Enabled = false;

            HuobiValue.Visible = true;
            BTCvalue.Visible = true;
            BitfinexValue.Visible = true;
            BitstampValue.Visible = true;
            Huobi.Visible = true;
            BTC.Visible = true;
            Bitfinex.Visible = true;
            Bitstamp.Visible = true;

            label_HuobiValue.Visible = false;
            label_BtcchinaValue.Visible = false;
            label_OkcoinValue.Visible = false;
            label_OkcoinBtccny.Visible = false;
            label_HuobiBtccny.Visible = false;
            label_BtcchinaBtccny.Visible = false;

        }


    }
}
