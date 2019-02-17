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

namespace Рассчёт_микроэлементов
{
    public partial class HarmfulFactor : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=nutrients.mdb;";       
        private OleDbConnection myConnection;
        private static List<string> list = new List<string>();
        private static string[] sl;
        public HarmfulFactor()
        {
            InitializeComponent();
            
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            list_init();
        }

        private void listBox_factors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT [ration] FROM [Общсписок] WHERE [names]='"+ listBox_factors.SelectedItem.ToString()+ "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            textBox_ration.Text = reader[0].ToString();
            textBox_ration.BackColor = Color.Cyan;
            reader.Close();
        }

        private void HarmfulFactor_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
            this.Owner.Enabled = true;
        }

        private void CLose_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(textBox_ration.Text);
            ratio.rationHF = textBox_ration.Text;
            this.Owner.Enabled = true;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string search = textBox1.Text + e.KeyChar;
            if (textBox1.Text=="")
            {
                foreach (string ss in sl)
                {
                    listBox_factors.Items.Add(ss);
                }
                return;
            }
            listBox_factors.Items.Clear();
            foreach (string ss in sl)
            {
                if (ss.ToLower().Contains(search.ToLower())) listBox_factors.Items.Add(ss);
            }
        }

        private void list_init()
        {
            sl = new string[listBox_factors.Items.Count];
            for (int i = 0; i < listBox_factors.Items.Count; i++)
            {
                sl[i] = listBox_factors.Items[i].ToString();
            }
            //for (int i=0;i<listBox_factors.Items.Count; i++)
            //    list.Add(listBox_factors.Items[i].ToString());
        }
    }
}
