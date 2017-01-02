namespace SimpleParser01
{
    partial class PopupForm
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
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(74, 36);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(185, 20);
            this.textBox_password.TabIndex = 7;
            this.textBox_password.Text = "evenuglygirlsarepretty";
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(74, 12);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(185, 20);
            this.textBox_Email.TabIndex = 8;
            this.textBox_Email.Text = "Parserforklim@gmail.com";
            this.textBox_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(15, 39);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(36, 15);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 13);
            this.label_Email.TabIndex = 6;
            this.label_Email.Text = "Email:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(152, 74);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(71, 74);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Name = "PopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
    }
}