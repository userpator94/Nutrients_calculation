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
                mealName_listBox.SelectedIndex == -1) {
                MessageBox.Show("Проверерьте заполнены ли данные в первой колонке");
                return;
            }
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте выбран ли Возраст, Пол и Вариант рациона");
                return;
            }
            //dateTimePicker1.Enabled = false;
            if (products == "" && listBox_products.SelectedIndex != -1) products = listBox_products.SelectedItem.ToString();
            if (products == "" || productVol_textBox.Text == "") {
                MessageBox.Show("Проверьте выбран ли продукт и его количество");
                return;
            }          
            if (comboBox3.SelectedIndex == 0)
            {
                int cmbslct = comboBox4.SelectedIndex + 1;
                if (preview_listBox.Items.Count >= cmbslct)
                {
                    MessageBox.Show("Достигнуто максимальное количество приёмов пищи");
                    return;
                }
            }
            if (comboBox3.SelectedIndex == 1)
            {
                if (preview_listBox.Items.Count >= 1)
                {
                    MessageBox.Show("Достигнуто максимальное количество приёмов пищи");
                    return;
                }
            }

            string date = dateTimePicker1.Value.ToShortDateString();
            string time = time_comboBox.SelectedItem.ToString();
            string meal = mealName_listBox.SelectedItem.ToString();
            string productVolume = productVol_textBox.Text;

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
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте выбран ли Возраст, Пол и Вариант рациона");
                return;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                if (comboBox5.SelectedIndex == -1)
                {
                    MessageBox.Show("Проверьте выбран ли Рацион");
                    return;
                }
            }
            previewData = new string[preview_listBox.Items.Count];
            for (int i = 0; i < preview_listBox.Items.Count; i++)
            {
                previewData[i] = preview_listBox.Items[i].ToString().Replace("\\", " ");
            }

            ratio.age = Convert.ToInt16(comboBox1.SelectedItem);
            ratio.sex = comboBox2.SelectedItem.ToString();

            try
            {
                Form2 preshow_form = new Form2();
                preshow_form.StartPosition = FormStartPosition.CenterParent;
                preshow_form.Location = this.Location;
                preshow_form.Show();
                var x = Location.X + 51;
                var y = Location.Y + 30;
                preshow_form.Location = new System.Drawing.Point(x, y);
            }
            catch { }
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

        private void rationVariant_Changed(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                ratio.rationSelect = "сут";
                comboBox4.Enabled = true;
                comboBox5.Enabled = false;
                button_FH.Enabled = false;
                mealName_listBox.Enabled = true;
            }
            else   //ЛПП
            {
                ratio.rationSelect = "лпп";
                comboBox4.Enabled = false;
                comboBox5.Enabled = true;
                button_FH.Enabled = true;

                mealName_listBox.Focus();
                mealName_listBox.SelectedIndex = 0;
                //((ListBox)mealName_listBox.SelectedItem).Focus();
                mealName_listBox.Enabled = false;
            }
        }

        private void button_FH_Click(object sender, EventArgs e)
        {
            Form fh = new HarmfulFactor();
            fh.Owner = this;
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.Location = this.Location;        
            fh.Show(this);
            if (fh.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - fh.Width) / 2;
                var y = Location.Y;
                fh.Location = new System.Drawing.Point(Math.Max(x, 0), y);
            }
            this.Enabled = false;
            //    normativs.Location = new System.Drawing.Point(Math.Max(x, 0), Math.Max(y, 0));
            //}
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ratio.rationNum = comboBox5.SelectedIndex + 1;
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                for (int i=0; i<comboBox5.Items.Count; i++)
                {
                    if (ratio.rationHF==comboBox5.Items[i].ToString()) comboBox5.SelectedIndex = i;
                }
                //int cb5I = comboBox5.FindStringExact(ratio.rationHF);
                ////int cb5I = comboBox5.Items.IndexOf(ratio.rationHF);
                //comboBox5.SelectedIndex = cb5I;                
            }
        }

        private void recommendMenu_Click(object sender, EventArgs e)
        {
            RationVariants rv = new RationVariants(comboBox5.Items[comboBox5.SelectedIndex].ToString());
            rv.StartPosition = FormStartPosition.CenterParent;
            rv.Location = this.Location;
            rv.Show();
            if (rv.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - rv.Width) / 2;
                var y = Location.Y;
                rv.Location = new System.Drawing.Point(Math.Max(x, 0), y);
            }

        }
    }

    static class ratio
    {
        public static string rationHF { get; set; }
        public static string rationSelect { get; set; }
        public static int rationNum { get; set; }
        public static string sex { get; set; }
        public static int age { get; set; }
    }
}
