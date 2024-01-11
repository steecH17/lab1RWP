using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1RWP
{
    public partial class PasswordForm : Form
    {
        
        public string LoginAndPassword
        {
            get { return comboBoxLogin.Text + textBoxPassword.Text; }
        }
        public PasswordForm()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            comboBoxLogin.Text = comboBoxLogin.Items[0].ToString();
            textBoxPassword.Enabled = false;
            
        }
        

        private void comboBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxLogin.SelectedIndex==1) { textBoxPassword.Enabled = true; }
            else { textBoxPassword.Enabled = false; }
        }
        
    }
}
