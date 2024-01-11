using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1RWP
{
    public partial class MainForm : Form
    {
        List<List<IPerson>> peoples = new List<List<IPerson>>(); 
        List<int> selectedIndexes = new List<int>();
        int countPages = 2;
        

        public MainForm()
        {
            InitializeComponent();
            tabPage1.Controls.Add(CreateNewListBox());
            tabPage2.Controls.Add(CreateNewListBox());
            peoples.Add(new List<IPerson>());
            peoples.Add(new List<IPerson>());

        }

        

        private void button_CreatePeople_Click(object sender, EventArgs e)
        {
            
            var dialogForm = new CreateUserForm();
            if (dialogForm.ShowDialog(this) == DialogResult.OK)
            {
                int.TryParse(dialogForm.UserCard, out int parseCard);
                peoples[tabControl1.SelectedIndex].Add(new Person(dialogForm.UserName, parseCard, dialogForm.UserBirthday));
                LoadPersonstoListBox();
            }
            dialogForm.Close();
          
        }

        private void button_EditPeople_Click(object sender, EventArgs e)
        {
            var dialogForm = new CreateUserForm();
            ListBox currentListBox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();

            if (currentListBox.SelectedIndex == -1) MessageBox.Show("Пользователь не выбран!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
            {
                dialogForm.UserName = peoples[tabControl1.SelectedIndex][currentListBox.SelectedIndex].Name;
                dialogForm.UserCard = peoples[tabControl1.SelectedIndex][currentListBox.SelectedIndex].CardNumber.ToString();
                dialogForm.UserBirthday = peoples[tabControl1.SelectedIndex][currentListBox.SelectedIndex].Bithday;

                dialogForm.DisableTextBoxs();

                if (dialogForm.ShowDialog(this) == DialogResult.OK)
                {
                    int curind = currentListBox.SelectedIndex;
                    int.TryParse(dialogForm.UserCard, out int parseCard);
                    peoples[tabControl1.SelectedIndex][curind].SetName(dialogForm.UserName);
                    peoples[tabControl1.SelectedIndex][curind].SetCardNumber(parseCard);
                    peoples[tabControl1.SelectedIndex][curind].SetBithday(dialogForm.UserBirthday);

                    currentListBox.Items.RemoveAt(curind);
                    string Age = peoples[tabControl1.SelectedIndex][curind].CalcAge(peoples[tabControl1.SelectedIndex][curind].Bithday).ToString();
                    currentListBox.Items.Insert(curind, peoples[tabControl1.SelectedIndex][curind].Name + "-" + Age);
                }
                dialogForm.Close();
            }
            
            
        }

        private void button_DeletePeople_Click(object sender, EventArgs e)
        {
            ListBox currentListBox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            if (currentListBox.SelectedIndex > -1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    RemovePersons();
                }
            }
            else if (currentListBox.SelectedIndex == -1) MessageBox.Show("Пользователь не выбран!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Список пуст!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ListBox currentListBox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
        //    if (currentListBox.SelectedIndex == -1)
        //    {
        //        selectedIndexes.Clear();
        //        BackColor = Color.White;
        //    }
        //    else
        //    {
        //        selectedIndexes.Add(currentListBox.SelectedIndex);
        //        CheckCombinations();
        //    }
        //} 

        private void button_LoadtoFile_Click(object sender, EventArgs e)
        {
            LoadPersonToFile();
        }

        private void button_CreatePage_Click(object sender, EventArgs e)
        {
            TabPage newTabPage= new TabPage();
            countPages++;
            newTabPage.Text="Page"+countPages.ToString();
            newTabPage.BackColor= Color.White; 
            newTabPage.Controls.Add(CreateNewListBox());
            tabControl1.TabPages.Add(newTabPage);
            peoples.Add(new List<IPerson>());
        }

        private void LoadPersonstoListBox()
        {
            ListBox currentListBox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            string Age = peoples[tabControl1.SelectedIndex][peoples[tabControl1.SelectedIndex].Count - 1].CalcAge(peoples[tabControl1.SelectedIndex][peoples[tabControl1.SelectedIndex].Count - 1].Bithday).ToString();
            currentListBox.Items.Add(peoples[tabControl1.SelectedIndex][peoples[tabControl1.SelectedIndex].Count-1].Name + "-" + Age);

        }

        private void RemovePersons()
        {
            ListBox currentListBox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            peoples[tabControl1.SelectedIndex].RemoveAt(currentListBox.SelectedIndex);
            currentListBox.Items.RemoveAt(currentListBox.SelectedIndex);
        }
        private ListBox CreateNewListBox()
        {
            ListBox listBox = new ListBox();
            listBox.Width = 254;
            listBox.Height = 250;
            listBox.Location = new Point(6, 5);
            return listBox;
        }

        private void CheckCombinations()
        {
            bool wrong = true;
            if (selectedIndexes.Count >= peoples[tabControl1.SelectedIndex].Count)
            {
                int delta = selectedIndexes.Count - peoples[tabControl1.SelectedIndex].Count;//4-3=1   
                for (int i = delta; i < selectedIndexes.Count; i++)
                {
                    if (selectedIndexes[i] != peoples[tabControl1.SelectedIndex].Count - 1 - i + delta)
                    {
                        wrong = false;
                        break;
                    }
                }
                if (wrong) { BackColor = Color.Red; }
            }
        }

        private void LoadPersonToFile()
        {
            ListBox currentListBox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            if (currentListBox.Items.Count > 0)
            {
                string path = @"C:\Users\vniki\source\repos\lab1RWP\";
                string fileName = "Users_list" + tabControl1.SelectedIndex.ToString() + ".txt";
                string full_path = path + fileName;
                using (StreamWriter file = new StreamWriter(full_path, false))
                {
                    for (int i = 0; i < peoples[tabControl1.SelectedIndex].Count; i++)
                    {
                        file.WriteLine(i.ToString() + "  Name:" + peoples[tabControl1.SelectedIndex][i].Name + "  Age:" + peoples[tabControl1.SelectedIndex][i].CalcAge(peoples[tabControl1.SelectedIndex][i].Bithday).ToString() + "  Card Number:" + peoples[tabControl1.SelectedIndex][i].CardNumber.ToString());
                    }
                    file.Close();
                }
                MessageBox.Show("Данные успешно добавлены!");
            }
            else MessageBox.Show("Список пользователей пуст!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
