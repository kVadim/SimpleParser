using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleParser01
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //textBox_Email.Text = System.IO.File.ReadAllText(@"D:\A.txt");
            //textBox_password.Text = System.IO.File.ReadAllText("@D:\A.txt");
            System.IO.File.WriteAllText(@"D:\A.txt", textBox_Email.Text);
        }
    }
}
