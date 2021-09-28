using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //заполнение списка цифр
            for(int i = 0; i < 10; i++)
            {
                listBox_listNumbers.Items.Add(i);                
            }
        }

        private void listBox_listNumbers_Click(object sender, EventArgs e)
        {
            if(textBox_number.Text.Length < 12)
            {
                textBox_number.Text += listBox_listNumbers.SelectedItem; // добавление цифры номера              
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text.Length == 12 && textBox_name.Text.Length > 0)
            {
                listView_contacts.Items.Add(textBox_name.Text + " " + "-" + " " + textBox_number.Text); // добавление нового контакта
                textBox_number.Text = "+7";
                textBox_name.Text = "";
            }
        }
    }
}
