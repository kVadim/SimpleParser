namespace SimpleParser01
{
    partial class Vform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vform));
            this.butRun = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.counter_Seconds = new System.Windows.Forms.NumericUpDown();
            this.Bitstamp = new System.Windows.Forms.Label();
            this.BTC = new System.Windows.Forms.Label();
            this.Bitfinex = new System.Windows.Forms.Label();
            this.Huobi = new System.Windows.Forms.Label();
            this.BitstampValue = new System.Windows.Forms.Label();
            this.BTCvalue = new System.Windows.Forms.Label();
            this.BitfinexValue = new System.Windows.Forms.Label();
            this.HuobiValue = new System.Windows.Forms.Label();
            this.checkBox_isHidden = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbBoxBurse = new System.Windows.Forms.ComboBox();
            this.counter_Min = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxBurse2 = new System.Windows.Forms.ComboBox();
            this.counter_Max = new System.Windows.Forms.NumericUpDown();
            this.checkBox_max = new System.Windows.Forms.CheckBox();
            this.checkBox_min = new System.Windows.Forms.CheckBox();
            this.label_frequency = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.simpleParser = new System.Windows.Forms.NotifyIcon(this.components);
            this.counter_Minutes = new System.Windows.Forms.NumericUpDown();
            this.label_mins = new System.Windows.Forms.Label();
            this.counter_CNY = new System.Windows.Forms.NumericUpDown();
            this.label_cny = new System.Windows.Forms.Label();
            this.checkBox_cny = new System.Windows.Forms.CheckBox();
            this.butReport = new System.Windows.Forms.Button();
            this.label_OkcoinBtccny = new System.Windows.Forms.Label();
            this.label_OkcoinValue = new System.Windows.Forms.Label();
            this.label_BtcchinaBtccny = new System.Windows.Forms.Label();
            this.label_BtcchinaValue = new System.Windows.Forms.Label();
            this.label_HuobiBtccny = new System.Windows.Forms.Label();
            this.label_HuobiValue = new System.Windows.Forms.Label();
            this.cmbBoxBurse3 = new System.Windows.Forms.ComboBox();
            this.cmbBoxBurse4 = new System.Windows.Forms.ComboBox();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.counter_Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_CNY)).BeginInit();
            this.SuspendLayout();
            // 
            // butRun
            // 
            this.butRun.BackColor = System.Drawing.SystemColors.Control;
            this.butRun.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.butRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRun.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butRun.Location = new System.Drawing.Point(11, 6);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(85, 24);
            this.butRun.TabIndex = 0;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // butStop
            // 
            this.butStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butStop.Enabled = false;
            this.butStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStop.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butStop.Location = new System.Drawing.Point(102, 6);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(85, 24);
            this.butStop.TabIndex = 0;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // URL
            // 
            this.URL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.URL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.URL.Location = new System.Drawing.Point(11, 92);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(461, 20);
            this.URL.TabIndex = 1;
            this.URL.Text = "https://bitcoinwisdom.com/";
            // 
            // counter_Seconds
            // 
            this.counter_Seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_Seconds.InterceptArrowKeys = false;
            this.counter_Seconds.Location = new System.Drawing.Point(238, 39);
            this.counter_Seconds.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.counter_Seconds.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.counter_Seconds.Name = "counter_Seconds";
            this.counter_Seconds.Size = new System.Drawing.Size(40, 20);
            this.counter_Seconds.TabIndex = 2;
            this.counter_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.counter_Seconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Bitstamp
            // 
            this.Bitstamp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Bitstamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bitstamp.Location = new System.Drawing.Point(366, 175);
            this.Bitstamp.Name = "Bitstamp";
            this.Bitstamp.Size = new System.Drawing.Size(106, 36);
            this.Bitstamp.TabIndex = 3;
            this.Bitstamp.Text = "Bitstamp";
            this.Bitstamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bitstamp.Visible = false;
            // 
            // BTC
            // 
            this.BTC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTC.Location = new System.Drawing.Point(130, 175);
            this.BTC.Name = "BTC";
            this.BTC.Size = new System.Drawing.Size(106, 36);
            this.BTC.TabIndex = 3;
            this.BTC.Text = "BTC-e";
            this.BTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTC.Visible = false;
            // 
            // Bitfinex
            // 
            this.Bitfinex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Bitfinex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bitfinex.Location = new System.Drawing.Point(248, 175);
            this.Bitfinex.Name = "Bitfinex";
            this.Bitfinex.Size = new System.Drawing.Size(106, 36);
            this.Bitfinex.TabIndex = 3;
            this.Bitfinex.Text = "Bitfinex";
            this.Bitfinex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bitfinex.Visible = false;
            // 
            // Huobi
            // 
            this.Huobi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Huobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Huobi.Location = new System.Drawing.Point(12, 175);
            this.Huobi.Name = "Huobi";
            this.Huobi.Size = new System.Drawing.Size(106, 36);
            this.Huobi.TabIndex = 3;
            this.Huobi.Text = "Huobi";
            this.Huobi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Huobi.Visible = false;
            // 
            // BitstampValue
            // 
            this.BitstampValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BitstampValue.BackColor = System.Drawing.Color.Gainsboro;
            this.BitstampValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitstampValue.Location = new System.Drawing.Point(366, 208);
            this.BitstampValue.Name = "BitstampValue";
            this.BitstampValue.Size = new System.Drawing.Size(106, 36);
            this.BitstampValue.TabIndex = 3;
            this.BitstampValue.Text = "0";
            this.BitstampValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BitstampValue.Visible = false;
            // 
            // BTCvalue
            // 
            this.BTCvalue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTCvalue.BackColor = System.Drawing.Color.Gainsboro;
            this.BTCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTCvalue.Location = new System.Drawing.Point(130, 208);
            this.BTCvalue.Name = "BTCvalue";
            this.BTCvalue.Size = new System.Drawing.Size(106, 36);
            this.BTCvalue.TabIndex = 3;
            this.BTCvalue.Text = "0";
            this.BTCvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTCvalue.Visible = false;
            // 
            // BitfinexValue
            // 
            this.BitfinexValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BitfinexValue.BackColor = System.Drawing.Color.Gainsboro;
            this.BitfinexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitfinexValue.Location = new System.Drawing.Point(248, 208);
            this.BitfinexValue.Name = "BitfinexValue";
            this.BitfinexValue.Size = new System.Drawing.Size(106, 36);
            this.BitfinexValue.TabIndex = 3;
            this.BitfinexValue.Text = "0";
            this.BitfinexValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BitfinexValue.Visible = false;
            // 
            // HuobiValue
            // 
            this.HuobiValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HuobiValue.BackColor = System.Drawing.Color.Gainsboro;
            this.HuobiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HuobiValue.Location = new System.Drawing.Point(12, 208);
            this.HuobiValue.Name = "HuobiValue";
            this.HuobiValue.Size = new System.Drawing.Size(106, 36);
            this.HuobiValue.TabIndex = 3;
            this.HuobiValue.Text = "0";
            this.HuobiValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HuobiValue.Visible = false;
            // 
            // checkBox_isHidden
            // 
            this.checkBox_isHidden.AutoSize = true;
            this.checkBox_isHidden.Checked = true;
            this.checkBox_isHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_isHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_isHidden.Location = new System.Drawing.Point(14, 45);
            this.checkBox_isHidden.Name = "checkBox_isHidden";
            this.checkBox_isHidden.Size = new System.Drawing.Size(83, 17);
            this.checkBox_isHidden.TabIndex = 4;
            this.checkBox_isHidden.Text = "Hidden Run";
            this.checkBox_isHidden.UseVisualStyleBackColor = true;
            this.checkBox_isHidden.CheckedChanged += new System.EventHandler(this.checkBox_isHidden_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cmbBoxBurse
            // 
            this.cmbBoxBurse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBoxBurse.Enabled = false;
            this.cmbBoxBurse.FormattingEnabled = true;
            this.cmbBoxBurse.Location = new System.Drawing.Point(37, 150);
            this.cmbBoxBurse.Name = "cmbBoxBurse";
            this.cmbBoxBurse.Size = new System.Drawing.Size(199, 21);
            this.cmbBoxBurse.TabIndex = 5;
            this.cmbBoxBurse.Text = "No data ..";
            // 
            // counter_Min
            // 
            this.counter_Min.DecimalPlaces = 2;
            this.counter_Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.counter_Min.Location = new System.Drawing.Point(320, 37);
            this.counter_Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.counter_Min.Name = "counter_Min";
            this.counter_Min.Size = new System.Drawing.Size(51, 20);
            this.counter_Min.TabIndex = 6;
            this.counter_Min.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // cmbBoxBurse2
            // 
            this.cmbBoxBurse2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBoxBurse2.Enabled = false;
            this.cmbBoxBurse2.FormattingEnabled = true;
            this.cmbBoxBurse2.Location = new System.Drawing.Point(247, 150);
            this.cmbBoxBurse2.Name = "cmbBoxBurse2";
            this.cmbBoxBurse2.Size = new System.Drawing.Size(225, 21);
            this.cmbBoxBurse2.TabIndex = 5;
            this.cmbBoxBurse2.Text = "No data ..";
            // 
            // counter_Max
            // 
            this.counter_Max.DecimalPlaces = 2;
            this.counter_Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.counter_Max.Location = new System.Drawing.Point(320, 10);
            this.counter_Max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.counter_Max.Name = "counter_Max";
            this.counter_Max.Size = new System.Drawing.Size(51, 20);
            this.counter_Max.TabIndex = 6;
            this.counter_Max.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // checkBox_max
            // 
            this.checkBox_max.AutoSize = true;
            this.checkBox_max.Checked = true;
            this.checkBox_max.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_max.Location = new System.Drawing.Point(299, 13);
            this.checkBox_max.Name = "checkBox_max";
            this.checkBox_max.Size = new System.Drawing.Size(15, 14);
            this.checkBox_max.TabIndex = 7;
            this.checkBox_max.UseVisualStyleBackColor = true;
            // 
            // checkBox_min
            // 
            this.checkBox_min.AutoSize = true;
            this.checkBox_min.Checked = true;
            this.checkBox_min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_min.Location = new System.Drawing.Point(299, 39);
            this.checkBox_min.Name = "checkBox_min";
            this.checkBox_min.Size = new System.Drawing.Size(15, 14);
            this.checkBox_min.TabIndex = 7;
            this.checkBox_min.UseVisualStyleBackColor = true;
            // 
            // label_frequency
            // 
            this.label_frequency.AutoSize = true;
            this.label_frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_frequency.Location = new System.Drawing.Point(177, 41);
            this.label_frequency.Name = "label_frequency";
            this.label_frequency.Size = new System.Drawing.Size(55, 15);
            this.label_frequency.TabIndex = 9;
            this.label_frequency.Text = "Seconds";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_max.Location = new System.Drawing.Point(377, 12);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(86, 15);
            this.label_max.TabIndex = 9;
            this.label_max.Text = "Maximum %";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_min.Location = new System.Drawing.Point(377, 39);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(83, 15);
            this.label_min.TabIndex = 9;
            this.label_min.Text = "Minimum %";
            // 
            // simpleParser
            // 
            this.simpleParser.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.simpleParser.Icon = ((System.Drawing.Icon)(resources.GetObject("simpleParser.Icon")));
            this.simpleParser.Text = "simpleParser";
            this.simpleParser.Visible = true;
            this.simpleParser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // counter_Minutes
            // 
            this.counter_Minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_Minutes.InterceptArrowKeys = false;
            this.counter_Minutes.Location = new System.Drawing.Point(238, 63);
            this.counter_Minutes.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.counter_Minutes.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.counter_Minutes.Name = "counter_Minutes";
            this.counter_Minutes.Size = new System.Drawing.Size(40, 20);
            this.counter_Minutes.TabIndex = 2;
            this.counter_Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.counter_Minutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label_mins
            // 
            this.label_mins.AutoSize = true;
            this.label_mins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mins.Location = new System.Drawing.Point(181, 65);
            this.label_mins.Name = "label_mins";
            this.label_mins.Size = new System.Drawing.Size(51, 15);
            this.label_mins.TabIndex = 9;
            this.label_mins.Text = "Minutes";
            // 
            // counter_CNY
            // 
            this.counter_CNY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter_CNY.DecimalPlaces = 2;
            this.counter_CNY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.counter_CNY.InterceptArrowKeys = false;
            this.counter_CNY.Location = new System.Drawing.Point(320, 63);
            this.counter_CNY.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.counter_CNY.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.counter_CNY.Name = "counter_CNY";
            this.counter_CNY.Size = new System.Drawing.Size(51, 20);
            this.counter_CNY.TabIndex = 2;
            this.counter_CNY.Value = new decimal(new int[] {
            667,
            0,
            0,
            131072});
            // 
            // label_cny
            // 
            this.label_cny.AutoSize = true;
            this.label_cny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cny.Location = new System.Drawing.Point(377, 66);
            this.label_cny.Name = "label_cny";
            this.label_cny.Size = new System.Drawing.Size(75, 15);
            this.label_cny.TabIndex = 9;
            this.label_cny.Text = "CNY / USD";
            // 
            // checkBox_cny
            // 
            this.checkBox_cny.AutoSize = true;
            this.checkBox_cny.Checked = true;
            this.checkBox_cny.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_cny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_cny.Location = new System.Drawing.Point(299, 66);
            this.checkBox_cny.Name = "checkBox_cny";
            this.checkBox_cny.Size = new System.Drawing.Size(15, 14);
            this.checkBox_cny.TabIndex = 7;
            this.checkBox_cny.UseVisualStyleBackColor = true;
            // 
            // butReport
            // 
            this.butReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butReport.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butReport.Location = new System.Drawing.Point(193, 6);
            this.butReport.Name = "butReport";
            this.butReport.Size = new System.Drawing.Size(85, 24);
            this.butReport.TabIndex = 0;
            this.butReport.Text = "Report";
            this.butReport.UseVisualStyleBackColor = true;
            this.butReport.Click += new System.EventHandler(this.butReport_Click);
            // 
            // label_OkcoinBtccny
            // 
            this.label_OkcoinBtccny.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_OkcoinBtccny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OkcoinBtccny.Location = new System.Drawing.Point(330, 175);
            this.label_OkcoinBtccny.Name = "label_OkcoinBtccny";
            this.label_OkcoinBtccny.Size = new System.Drawing.Size(142, 36);
            this.label_OkcoinBtccny.TabIndex = 3;
            this.label_OkcoinBtccny.Text = "Okcoin_btc";
            this.label_OkcoinBtccny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_OkcoinValue
            // 
            this.label_OkcoinValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_OkcoinValue.BackColor = System.Drawing.Color.Gainsboro;
            this.label_OkcoinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OkcoinValue.Location = new System.Drawing.Point(348, 208);
            this.label_OkcoinValue.Name = "label_OkcoinValue";
            this.label_OkcoinValue.Size = new System.Drawing.Size(106, 36);
            this.label_OkcoinValue.TabIndex = 3;
            this.label_OkcoinValue.Text = "0";
            this.label_OkcoinValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_BtcchinaBtccny
            // 
            this.label_BtcchinaBtccny.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_BtcchinaBtccny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BtcchinaBtccny.Location = new System.Drawing.Point(170, 175);
            this.label_BtcchinaBtccny.Name = "label_BtcchinaBtccny";
            this.label_BtcchinaBtccny.Size = new System.Drawing.Size(142, 36);
            this.label_BtcchinaBtccny.TabIndex = 3;
            this.label_BtcchinaBtccny.Text = "Btcchina_btc";
            this.label_BtcchinaBtccny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_BtcchinaValue
            // 
            this.label_BtcchinaValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_BtcchinaValue.BackColor = System.Drawing.Color.Gainsboro;
            this.label_BtcchinaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BtcchinaValue.Location = new System.Drawing.Point(188, 208);
            this.label_BtcchinaValue.Name = "label_BtcchinaValue";
            this.label_BtcchinaValue.Size = new System.Drawing.Size(106, 36);
            this.label_BtcchinaValue.TabIndex = 3;
            this.label_BtcchinaValue.Text = "0";
            this.label_BtcchinaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_HuobiBtccny
            // 
            this.label_HuobiBtccny.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_HuobiBtccny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_HuobiBtccny.Location = new System.Drawing.Point(12, 175);
            this.label_HuobiBtccny.Name = "label_HuobiBtccny";
            this.label_HuobiBtccny.Size = new System.Drawing.Size(142, 36);
            this.label_HuobiBtccny.TabIndex = 3;
            this.label_HuobiBtccny.Text = "Huobi_btc";
            this.label_HuobiBtccny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_HuobiValue
            // 
            this.label_HuobiValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_HuobiValue.BackColor = System.Drawing.Color.Gainsboro;
            this.label_HuobiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_HuobiValue.Location = new System.Drawing.Point(30, 208);
            this.label_HuobiValue.Name = "label_HuobiValue";
            this.label_HuobiValue.Size = new System.Drawing.Size(106, 36);
            this.label_HuobiValue.TabIndex = 3;
            this.label_HuobiValue.Text = "0";
            this.label_HuobiValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxBurse3
            // 
            this.cmbBoxBurse3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBoxBurse3.FormattingEnabled = true;
            this.cmbBoxBurse3.Location = new System.Drawing.Point(37, 121);
            this.cmbBoxBurse3.Name = "cmbBoxBurse3";
            this.cmbBoxBurse3.Size = new System.Drawing.Size(199, 21);
            this.cmbBoxBurse3.TabIndex = 5;
            this.cmbBoxBurse3.Text = "No data ..";
            // 
            // cmbBoxBurse4
            // 
            this.cmbBoxBurse4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBoxBurse4.FormattingEnabled = true;
            this.cmbBoxBurse4.Location = new System.Drawing.Point(247, 121);
            this.cmbBoxBurse4.Name = "cmbBoxBurse4";
            this.cmbBoxBurse4.Size = new System.Drawing.Size(225, 21);
            this.cmbBoxBurse4.TabIndex = 5;
            this.cmbBoxBurse4.Text = "No data ..";
            this.cmbBoxBurse4.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBurse4_SelectedIndexChanged);
            // 
            // radioBtn1
            // 
            this.radioBtn1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioBtn1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtn1.BackColor = System.Drawing.Color.Maroon;
            this.radioBtn1.Checked = true;
            this.radioBtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBtn1.Location = new System.Drawing.Point(11, 121);
            this.radioBtn1.MaximumSize = new System.Drawing.Size(20, 20);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(18, 18);
            this.radioBtn1.TabIndex = 11;
            this.radioBtn1.UseVisualStyleBackColor = false;
            this.radioBtn1.CheckedChanged += new System.EventHandler(this.radioBtn1_CheckedChanged);
            // 
            // radioBtn2
            // 
            this.radioBtn2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioBtn2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBtn2.BackColor = System.Drawing.Color.Maroon;
            this.radioBtn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioBtn2.FlatAppearance.BorderSize = 2;
            this.radioBtn2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuText;
            this.radioBtn2.ForeColor = System.Drawing.Color.Black;
            this.radioBtn2.Location = new System.Drawing.Point(11, 150);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(18, 18);
            this.radioBtn2.TabIndex = 11;
            this.radioBtn2.UseVisualStyleBackColor = false;
            this.radioBtn2.CheckedChanged += new System.EventHandler(this.radioBtn2_CheckedChanged);
            // 
            // Vform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.butStop;
            this.ClientSize = new System.Drawing.Size(484, 258);
            this.Controls.Add(this.radioBtn2);
            this.Controls.Add(this.radioBtn1);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_cny);
            this.Controls.Add(this.label_mins);
            this.Controls.Add(this.label_frequency);
            this.Controls.Add(this.checkBox_cny);
            this.Controls.Add(this.checkBox_min);
            this.Controls.Add(this.checkBox_max);
            this.Controls.Add(this.counter_Max);
            this.Controls.Add(this.counter_Min);
            this.Controls.Add(this.cmbBoxBurse4);
            this.Controls.Add(this.cmbBoxBurse3);
            this.Controls.Add(this.cmbBoxBurse2);
            this.Controls.Add(this.cmbBoxBurse);
            this.Controls.Add(this.checkBox_isHidden);
            this.Controls.Add(this.HuobiValue);
            this.Controls.Add(this.Huobi);
            this.Controls.Add(this.label_HuobiValue);
            this.Controls.Add(this.BitfinexValue);
            this.Controls.Add(this.label_HuobiBtccny);
            this.Controls.Add(this.Bitfinex);
            this.Controls.Add(this.label_BtcchinaValue);
            this.Controls.Add(this.label_BtcchinaBtccny);
            this.Controls.Add(this.BTCvalue);
            this.Controls.Add(this.label_OkcoinValue);
            this.Controls.Add(this.BTC);
            this.Controls.Add(this.BitstampValue);
            this.Controls.Add(this.counter_CNY);
            this.Controls.Add(this.label_OkcoinBtccny);
            this.Controls.Add(this.counter_Minutes);
            this.Controls.Add(this.Bitstamp);
            this.Controls.Add(this.counter_Seconds);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.butReport);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butRun);
            this.MaximumSize = new System.Drawing.Size(600, 480);
            this.MinimumSize = new System.Drawing.Size(500, 280);
            this.Name = "Vform";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SimpleParser  0.8";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vform_FormClosed);
            this.Load += new System.EventHandler(this.Vform_Load);
            this.Resize += new System.EventHandler(this.Tray);
            ((System.ComponentModel.ISupportInitialize)(this.counter_Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_CNY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.NumericUpDown counter_Seconds;
        private System.Windows.Forms.Label Bitstamp;
        private System.Windows.Forms.Label BTC;
        private System.Windows.Forms.Label Bitfinex;
        private System.Windows.Forms.Label Huobi;
        private System.Windows.Forms.Label BitstampValue;
        private System.Windows.Forms.Label BTCvalue;
        private System.Windows.Forms.Label BitfinexValue;
        private System.Windows.Forms.Label HuobiValue;
        private System.Windows.Forms.CheckBox checkBox_isHidden;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbBoxBurse;
        private System.Windows.Forms.NumericUpDown counter_Min;
        private System.Windows.Forms.ComboBox cmbBoxBurse2;
        private System.Windows.Forms.NumericUpDown counter_Max;
        private System.Windows.Forms.CheckBox checkBox_max;
        private System.Windows.Forms.CheckBox checkBox_min;
        private System.Windows.Forms.Label label_frequency;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.NotifyIcon simpleParser;
        private System.Windows.Forms.NumericUpDown counter_Minutes;
        private System.Windows.Forms.Label label_mins;
        private System.Windows.Forms.NumericUpDown counter_CNY;
        private System.Windows.Forms.Label label_cny;
        private System.Windows.Forms.CheckBox checkBox_cny;
        private System.Windows.Forms.Button butReport;
        private System.Windows.Forms.Label label_OkcoinBtccny;
        private System.Windows.Forms.Label label_OkcoinValue;
        private System.Windows.Forms.Label label_BtcchinaBtccny;
        private System.Windows.Forms.Label label_BtcchinaValue;
        private System.Windows.Forms.Label label_HuobiBtccny;
        private System.Windows.Forms.Label label_HuobiValue;
        private System.Windows.Forms.ComboBox cmbBoxBurse3;
        private System.Windows.Forms.ComboBox cmbBoxBurse4;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.RadioButton radioBtn2;
    }
}

