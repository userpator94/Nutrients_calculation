using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections;

namespace Рассчёт_микроэлементов
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=nutrients.mdb;";
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=nutrients.mdb;";
        private OleDbConnection myConnection;
        ////
        public int groupNum = 0;
        string products = "";
        //string productVolume = "";
        public static string[] previewData;

        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            getAllProducts();
        }

        private void add_button_Click(object sender, EventArgs e) //add the whole note about meal
        {
            if (productVol_textBox.Text == "" || time_comboBox.SelectedIndex == -1 ||
                mealName_listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проверерьте заполнены ли данные в первой колонке");
                return;
            }
            //dateTimePicker1.Enabled = false;
            if (products == "" && listBox_products.SelectedIndex != -1) products = listBox_products.SelectedItem.ToString();
            if (products == "" || productVol_textBox.Text == "")
            {
                MessageBox.Show("Проверьте выбран ли продукт и его количество");
                return;
            }

            string date = dateTimePicker1.Value.ToShortDateString();
            string time = time_comboBox.SelectedItem.ToString();
            string meal = mealName_listBox.SelectedItem.ToString();
            string productVolume = productVol_textBox.Text;
            //products = listBox_products.SelectedItem.ToString();

            //preview_listBox.Items.Add(date + " " + time + " " + meal + " " + productVolume + " " +
            //    Environment.NewLine + products);
            preview_listBox.Items.Add(date + " " + time + " " + meal + " " + Environment.NewLine + products);
            products = "";
            productVol_textBox.Text = "";
            if (this.Width < 1000) button_Size_Click(sender, e);
        }

        private void preshow_Click(object sender, EventArgs e)
        {
            if (preview_listBox.Items.Count == 0)
            {
                MessageBox.Show("Возможно вы добавили продукты, но забыли добавить запись");
                return;
            }
            previewData = new string[preview_listBox.Items.Count];
            for (int i = 0; i < preview_listBox.Items.Count; i++)
            {
                previewData[i] = preview_listBox.Items[i].ToString().Replace("\\", " ");
            }

            Form2 preshow_form = new Form2();
            preshow_form.StartPosition = FormStartPosition.CenterParent;
            preshow_form.Location = this.Location;
            preshow_form.Show();
            var x = Location.X + 51;
            var y = Location.Y + 30;
            preshow_form.Location = new System.Drawing.Point(x, y);          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        List<String> list = new List<string>();
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string search = textBox2.Text+e.KeyChar;         

            listBox_products.Items.Clear();
            foreach (string ss in list)
            {
                if (ss.ToLower().Contains(search)) listBox_products.Items.Add(ss);
            }
        }

        public void getAllProducts()
        {            
            string query = "SELECT Наименование FROM Продукты";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
            reader.Close();
            list.Sort();
            foreach(string item in list)
            {
                listBox_products.Items.Add(item);
            }
            //return list;
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_products.Items.Clear();
            groupNum = listBox2.SelectedIndex+1;
            string query = "SELECT Наименование FROM Продукты WHERE gruppa="+ groupNum;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBox_products.Items.Add(reader[0]);
            }
            reader.Close();            
        }

        private void button_Size_Click(object sender, EventArgs e)
        {
            if (this.Width > 875)
            {
                button_Size.Text = "}";
                this.Width -= 200;
                return;
            }
            if (this.Width == 875)
            {
                button_Size.Text = "{";
                this.Width += 200;
                return;
            }
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            if (listBox_products.SelectedIndex == -1 || productVol_textBox.Text == "")
            {
                MessageBox.Show("Проверьте выбран ли продукт и его количество");
                return;
            }
            products += listBox_products.SelectedItem.ToString()+" "+ productVol_textBox.Text+"г" + Environment.NewLine;
        }

        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(preview_listBox.Items[e.Index].ToString(), preview_listBox.Font, preview_listBox.Width).Height;
        }
        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (preview_listBox.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(preview_listBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            preview_listBox.Items.Remove(preview_listBox.SelectedItem);
        }

        private void productVol_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numb = e.KeyChar;
            if (!Char.IsDigit(numb) && numb!=8) e.Handled = true;
        }


    }
}
