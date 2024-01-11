using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace lab1RWP
{
    public partial class CreateUserForm : Form
    {
        byte[] hashPasswordAdmin = { 10, 41, 11, 123, 100, 159, 69, 43, 48, 144, 26, 162, 115, 225, 106, 135 };
        bool admin = false;
        int originalCardNumber;
        public string UserName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }


        public string UserCard
        {
            get { return textBoxCard.Text; }
            set { textBoxCard.Text = value; }
        }

        public DateTime UserBirthday
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public CreateUserForm()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
           
            
        }


        public void DisableTextBoxs()
        {
            textBoxCard.Enabled = false;
            dateTimePicker1.Enabled = false;
        }
        public void EnableTextBoxs()
        {
            textBoxCard.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void AdminMode()
        {
            EnableTextBoxs();
            BackColor = Color.Coral;
            ForeColor = Color.LightSkyBlue;
            admin= true;
            int.TryParse(UserCard, out int parseCard);
            originalCardNumber = parseCard;
        }
        
        private void textBoxCard_TextChanged(object sender, EventArgs e)
        {

            textBoxCard.MaxLength = 5;
            if (textBoxCard.Text.Length == 5 )
            {
                int.TryParse(UserCard, out int parseCard);
                if(parseCard<10000)
                {
                    MessageBox.Show("Unccorect CardNimber");
                    textBoxCard.Clear();
                }

            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!textBoxCard.Enabled)
            {
                if (e.Control && e.Shift && e.KeyCode == Keys.L)
                {
                    var form3 = new PasswordForm();
                    if (form3.ShowDialog(this) == DialogResult.OK)
                    {
                        if (Convert.ToBase64String(hashPasswordAdmin) == GetHash(form3.LoginAndPassword))
                        {
                            AdminMode();
                        }
                        else MessageBox.Show("Неверный пароль!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            return Convert.ToBase64String(hash);
        }



        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int.TryParse(textBoxCard.Text, out int currentParseCard);
            if (admin && originalCardNumber!=currentParseCard) 
            {
                Random r = new Random();
                button1.Left = r.Next(0, this.ClientSize.Width - button1.Width);
                button1.Top = r.Next(0, this.ClientSize.Height - button1.Height);
            }
        }

        private void textBoxCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number) && number!=8)
            {
                e.Handled = true;
            }
        }

    }
}
