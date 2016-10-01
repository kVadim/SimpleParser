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
            this.butRefresh = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.NumericUpDown();
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
            this.comboBoxBurse = new System.Windows.Forms.ComboBox();
            this.persentMin = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBurse1 = new System.Windows.Forms.ComboBox();
            this.persentMax = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.CheckBox();
            this.min = new System.Windows.Forms.CheckBox();
            this.label_frequency = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
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
            this.butRun.Location = new System.Drawing.Point(11, 10);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(90, 24);
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
            this.butStop.Location = new System.Drawing.Point(107, 10);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(90, 24);
            this.butStop.TabIndex = 0;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butBrowse
            // 
            this.butBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butBrowse.Enabled = false;
            this.butBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butBrowse.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butBrowse.Location = new System.Drawing.Point(203, 10);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(90, 24);
            this.butBrowse.TabIndex = 0;
            this.butBrowse.Text = "Report";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRefresh.Enabled = false;
            this.butRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butRefresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butRefresh.Location = new System.Drawing.Point(12, 224);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(460, 6);
            this.butRefresh.TabIndex = 0;
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.URL.Location = new System.Drawing.Point(11, 117);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(461, 20);
            this.URL.TabIndex = 1;
            // 
            // N
            // 
            this.N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.N.InterceptArrowKeys = false;
            this.N.Location = new System.Drawing.Point(338, 87);
            this.N.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.N.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(48, 20);
            this.N.TabIndex = 2;
            this.N.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.N.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // Bitstamp
            // 
            this.Bitstamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bitstamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bitstamp.Location = new System.Drawing.Point(12, 140);
            this.Bitstamp.Name = "Bitstamp";
            this.Bitstamp.Size = new System.Drawing.Size(106, 36);
            this.Bitstamp.TabIndex = 3;
            this.Bitstamp.Text = "Bitstamp";
            this.Bitstamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTC
            // 
            this.BTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTC.Location = new System.Drawing.Point(130, 140);
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
            this.Bitfinex.Location = new System.Drawing.Point(248, 140);
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
            this.Huobi.Location = new System.Drawing.Point(366, 140);
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
            this.BitstampValue.Location = new System.Drawing.Point(12, 176);
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
            this.BTCvalue.Location = new System.Drawing.Point(130, 176);
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
            this.BitfinexValue.Location = new System.Drawing.Point(248, 176);
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
            this.HuobiValue.Location = new System.Drawing.Point(366, 176);
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
            this.isHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isHidden.Location = new System.Drawing.Point(317, 10);
            this.isHidden.Name = "isHidden";
            this.isHidden.Size = new System.Drawing.Size(93, 17);
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
            // comboBoxBurse
            // 
            this.comboBoxBurse.FormattingEnabled = true;
            this.comboBoxBurse.Location = new System.Drawing.Point(12, 50);
            this.comboBoxBurse.Name = "comboBoxBurse";
            this.comboBoxBurse.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBurse.TabIndex = 5;
            this.comboBoxBurse.Text = "No data ..";
            this.comboBoxBurse.SelectedIndexChanged += new System.EventHandler(this.comboBoxBurse_SelectedIndexChanged);
            // 
            // persentMin
            // 
            this.persentMin.DecimalPlaces = 1;
            this.persentMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.persentMin.Location = new System.Drawing.Point(338, 60);
            this.persentMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.persentMin.Name = "persentMin";
            this.persentMin.Size = new System.Drawing.Size(48, 20);
            this.persentMin.TabIndex = 6;
            this.persentMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.persentMin.ValueChanged += new System.EventHandler(this.persent_ValueChanged);
            // 
            // comboBoxBurse1
            // 
            this.comboBoxBurse1.FormattingEnabled = true;
            this.comboBoxBurse1.Location = new System.Drawing.Point(158, 50);
            this.comboBoxBurse1.Name = "comboBoxBurse1";
            this.comboBoxBurse1.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBurse1.TabIndex = 5;
            this.comboBoxBurse1.Text = "No data ..";
            // 
            // persentMax
            // 
            this.persentMax.DecimalPlaces = 1;
            this.persentMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.persentMax.Location = new System.Drawing.Point(338, 33);
            this.persentMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.persentMax.Name = "persentMax";
            this.persentMax.Size = new System.Drawing.Size(48, 20);
            this.persentMax.TabIndex = 6;
            this.persentMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.persentMax.ValueChanged += new System.EventHandler(this.persent_ValueChanged);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Checked = true;
            this.max.CheckState = System.Windows.Forms.CheckState.Checked;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max.Location = new System.Drawing.Point(317, 36);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(15, 14);
            this.max.TabIndex = 7;
            this.max.UseVisualStyleBackColor = true;
            this.max.CheckedChanged += new System.EventHandler(this.P2_CheckedChanged);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Checked = true;
            this.min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.Location = new System.Drawing.Point(317, 62);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(15, 14);
            this.min.TabIndex = 7;
            this.min.UseVisualStyleBackColor = true;
            this.min.CheckedChanged += new System.EventHandler(this.P2_CheckedChanged);
            // 
            // label_frequency
            // 
            this.label_frequency.AutoSize = true;
            this.label_frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_frequency.Location = new System.Drawing.Point(392, 88);
            this.label_frequency.Name = "label_frequency";
            this.label_frequency.Size = new System.Drawing.Size(73, 15);
            this.label_frequency.TabIndex = 9;
            this.label_frequency.Text = "Frequency";
            this.label_frequency.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_max.Location = new System.Drawing.Point(392, 36);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(70, 15);
            this.label_max.TabIndex = 9;
            this.label_max.Text = "Maximum";
            this.label_max.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_min.Location = new System.Drawing.Point(392, 62);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(71, 15);
            this.label_min.TabIndex = 9;
            this.label_min.Text = "Minumum";
            this.label_min.Click += new System.EventHandler(this.label1_Click);
            // 
            // Vform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.butStop;
            this.ClientSize = new System.Drawing.Size(484, 242);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_frequency);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.persentMax);
            this.Controls.Add(this.persentMin);
            this.Controls.Add(this.comboBoxBurse1);
            this.Controls.Add(this.comboBoxBurse);
            this.Controls.Add(this.isHidden);
            this.Controls.Add(this.HuobiValue);
            this.Controls.Add(this.Huobi);
            this.Controls.Add(this.BitfinexValue);
            this.Controls.Add(this.Bitfinex);
            this.Controls.Add(this.BTCvalue);
            this.Controls.Add(this.BTC);
            this.Controls.Add(this.BitstampValue);
            this.Controls.Add(this.Bitstamp);
            this.Controls.Add(this.N);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butBrowse);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butRun);
            this.MaximumSize = new System.Drawing.Size(500, 280);
            this.MinimumSize = new System.Drawing.Size(500, 280);
            this.Name = "Vform";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SimpleParser  0.2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Vform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.NumericUpDown N;
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
        private System.Windows.Forms.ComboBox comboBoxBurse;
        private System.Windows.Forms.NumericUpDown persentMin;
        private System.Windows.Forms.ComboBox comboBoxBurse1;
        private System.Windows.Forms.NumericUpDown persentMax;
        private System.Windows.Forms.CheckBox max;
        private System.Windows.Forms.CheckBox min;
        private System.Windows.Forms.Label label_frequency;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
    }
}

