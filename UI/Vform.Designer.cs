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
            this.butRun = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butBrowse = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.Sec = new System.Windows.Forms.NumericUpDown();
            this.Bitstamp = new System.Windows.Forms.Label();
            this.BTC = new System.Windows.Forms.Label();
            this.Bitfinex = new System.Windows.Forms.Label();
            this.Huobi = new System.Windows.Forms.Label();
            this.BitstampValue = new System.Windows.Forms.Label();
            this.BTCvalue = new System.Windows.Forms.Label();
            this.BitfinexValue = new System.Windows.Forms.Label();
            this.HuobiValue = new System.Windows.Forms.Label();
            this.isHidden = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.persentMin = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.persentMax = new System.Windows.Forms.NumericUpDown();
            this.label_Sec = new System.Windows.Forms.Label();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p6 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentMax)).BeginInit();
            this.SuspendLayout();
            // 
            // butRun
            // 
            this.butRun.BackColor = System.Drawing.SystemColors.Control;
            this.butRun.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.butRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRun.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butRun.Location = new System.Drawing.Point(15, 14);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(73, 24);
            this.butRun.TabIndex = 0;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // butStop
            // 
            this.butStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStop.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butStop.Location = new System.Drawing.Point(94, 14);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(73, 24);
            this.butStop.TabIndex = 0;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butBrowse
            // 
            this.butBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butBrowse.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butBrowse.Location = new System.Drawing.Point(173, 14);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(73, 24);
            this.butBrowse.TabIndex = 0;
            this.butBrowse.Text = "Report";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.Location = new System.Drawing.Point(15, 167);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(457, 20);
            this.URL.TabIndex = 1;
            // 
            // Sec
            // 
            this.Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sec.InterceptArrowKeys = false;
            this.Sec.Location = new System.Drawing.Point(142, 53);
            this.Sec.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(53, 20);
            this.Sec.TabIndex = 2;
            this.Sec.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Sec.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // Bitstamp
            // 
            this.Bitstamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bitstamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bitstamp.Location = new System.Drawing.Point(12, 190);
            this.Bitstamp.Name = "Bitstamp";
            this.Bitstamp.Size = new System.Drawing.Size(106, 36);
            this.Bitstamp.TabIndex = 3;
            this.Bitstamp.Text = "Bitstamp";
            this.Bitstamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bitstamp.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // BTC
            // 
            this.BTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTC.Location = new System.Drawing.Point(130, 190);
            this.BTC.Name = "BTC";
            this.BTC.Size = new System.Drawing.Size(106, 36);
            this.BTC.TabIndex = 3;
            this.BTC.Text = "BTC-e";
            this.BTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bitfinex
            // 
            this.Bitfinex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bitfinex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bitfinex.Location = new System.Drawing.Point(248, 190);
            this.Bitfinex.Name = "Bitfinex";
            this.Bitfinex.Size = new System.Drawing.Size(106, 36);
            this.Bitfinex.TabIndex = 3;
            this.Bitfinex.Text = "Bitfinex";
            this.Bitfinex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Huobi
            // 
            this.Huobi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Huobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Huobi.Location = new System.Drawing.Point(366, 190);
            this.Huobi.Name = "Huobi";
            this.Huobi.Size = new System.Drawing.Size(106, 36);
            this.Huobi.TabIndex = 3;
            this.Huobi.Text = "Huobi";
            this.Huobi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BitstampValue
            // 
            this.BitstampValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BitstampValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitstampValue.Location = new System.Drawing.Point(12, 230);
            this.BitstampValue.Name = "BitstampValue";
            this.BitstampValue.Size = new System.Drawing.Size(106, 36);
            this.BitstampValue.TabIndex = 3;
            this.BitstampValue.Text = "0";
            this.BitstampValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTCvalue
            // 
            this.BTCvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTCvalue.Location = new System.Drawing.Point(130, 230);
            this.BTCvalue.Name = "BTCvalue";
            this.BTCvalue.Size = new System.Drawing.Size(106, 36);
            this.BTCvalue.TabIndex = 3;
            this.BTCvalue.Text = "0";
            this.BTCvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BitfinexValue
            // 
            this.BitfinexValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BitfinexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitfinexValue.Location = new System.Drawing.Point(248, 230);
            this.BitfinexValue.Name = "BitfinexValue";
            this.BitfinexValue.Size = new System.Drawing.Size(106, 36);
            this.BitfinexValue.TabIndex = 3;
            this.BitfinexValue.Text = "0";
            this.BitfinexValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HuobiValue
            // 
            this.HuobiValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HuobiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HuobiValue.Location = new System.Drawing.Point(366, 230);
            this.HuobiValue.Name = "HuobiValue";
            this.HuobiValue.Size = new System.Drawing.Size(106, 36);
            this.HuobiValue.TabIndex = 3;
            this.HuobiValue.Text = "0";
            this.HuobiValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isHidden
            // 
            this.isHidden.AutoSize = true;
            this.isHidden.Checked = true;
            this.isHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isHidden.Location = new System.Drawing.Point(103, 131);
            this.isHidden.Name = "isHidden";
            this.isHidden.Size = new System.Drawing.Size(83, 17);
            this.isHidden.TabIndex = 4;
            this.isHidden.Text = "Hidden Run";
            this.isHidden.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // persentMin
            // 
            this.persentMin.DecimalPlaces = 1;
            this.persentMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.persentMin.Location = new System.Drawing.Point(142, 79);
            this.persentMin.Name = "persentMin";
            this.persentMin.Size = new System.Drawing.Size(53, 20);
            this.persentMin.TabIndex = 6;
            this.persentMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.persentMin.ValueChanged += new System.EventHandler(this.persent_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(264, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = " Bitstamp - Huobi";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(264, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 19);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = " Bitstamp - BTC";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(264, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(147, 19);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = " Bitstamp - Bitfinex";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(264, 92);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(107, 19);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = " BTC - Huobi";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox5.Location = new System.Drawing.Point(264, 117);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(117, 19);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = " Bitfinex - BTC";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox6.Location = new System.Drawing.Point(264, 142);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(129, 19);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = " Bitfinex - Huobi";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // persentMax
            // 
            this.persentMax.DecimalPlaces = 1;
            this.persentMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.persentMax.Location = new System.Drawing.Point(142, 105);
            this.persentMax.Name = "persentMax";
            this.persentMax.Size = new System.Drawing.Size(53, 20);
            this.persentMax.TabIndex = 6;
            this.persentMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.persentMax.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_2);
            // 
            // label_Sec
            // 
            this.label_Sec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sec.Location = new System.Drawing.Point(78, 51);
            this.label_Sec.Name = "label_Sec";
            this.label_Sec.Size = new System.Drawing.Size(50, 20);
            this.label_Sec.TabIndex = 3;
            this.label_Sec.Text = "Sec";
            this.label_Sec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Sec.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Checked = true;
            this.checkBoxMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMin.Location = new System.Drawing.Point(41, 80);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(89, 19);
            this.checkBoxMin.TabIndex = 8;
            this.checkBoxMin.Text = "Maximum";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            this.checkBoxMin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Checked = true;
            this.checkBoxMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMax.Location = new System.Drawing.Point(41, 105);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(90, 19);
            this.checkBoxMax.TabIndex = 8;
            this.checkBoxMax.Text = "Mininmun";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            this.checkBoxMax.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(253, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 140);
            this.panel1.TabIndex = 10;
            // 
            // p6
            // 
            this.p6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p6.Location = new System.Drawing.Point(417, 142);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(55, 19);
            this.p6.TabIndex = 3;
            this.p6.Text = "-";
            this.p6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p6.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // p5
            // 
            this.p5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p5.Location = new System.Drawing.Point(417, 117);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(55, 19);
            this.p5.TabIndex = 3;
            this.p5.Text = "-";
            this.p5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p5.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // p4
            // 
            this.p4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p4.Location = new System.Drawing.Point(417, 92);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(55, 19);
            this.p4.TabIndex = 3;
            this.p4.Text = "-";
            this.p4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p4.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // p3
            // 
            this.p3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p3.Location = new System.Drawing.Point(417, 67);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(55, 19);
            this.p3.TabIndex = 3;
            this.p3.Text = "-";
            this.p3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p3.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2.Location = new System.Drawing.Point(417, 42);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(55, 19);
            this.p2.TabIndex = 3;
            this.p2.Text = "-";
            this.p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1.Location = new System.Drawing.Point(417, 17);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(55, 19);
            this.p1.TabIndex = 3;
            this.p1.Text = "-";
            this.p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1.Click += new System.EventHandler(this.Bitstamp_Click);
            // 
            // Vform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.butStop;
            this.ClientSize = new System.Drawing.Size(484, 282);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBoxMax);
            this.Controls.Add(this.checkBoxMin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.persentMax);
            this.Controls.Add(this.persentMin);
            this.Controls.Add(this.isHidden);
            this.Controls.Add(this.HuobiValue);
            this.Controls.Add(this.Huobi);
            this.Controls.Add(this.BitfinexValue);
            this.Controls.Add(this.Bitfinex);
            this.Controls.Add(this.BTCvalue);
            this.Controls.Add(this.BTC);
            this.Controls.Add(this.BitstampValue);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.label_Sec);
            this.Controls.Add(this.Bitstamp);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.butBrowse);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butRun);
            this.MaximumSize = new System.Drawing.Size(500, 320);
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "Vform";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SimpleParser  0.1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Vform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.NumericUpDown Sec;
        private System.Windows.Forms.Label Bitstamp;
        private System.Windows.Forms.Label BTC;
        private System.Windows.Forms.Label Bitfinex;
        private System.Windows.Forms.Label Huobi;
        private System.Windows.Forms.Label BitstampValue;
        private System.Windows.Forms.Label BTCvalue;
        private System.Windows.Forms.Label BitfinexValue;
        private System.Windows.Forms.Label HuobiValue;
        private System.Windows.Forms.CheckBox isHidden;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown persentMin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown persentMax;
        private System.Windows.Forms.Label label_Sec;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label p6;
        private System.Windows.Forms.Label p5;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p1;
    }
}

