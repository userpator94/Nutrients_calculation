using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

using System.Windows.Forms;
using System.IO;

namespace Рассчёт_микроэлементов
{
    public partial class Form2 : Form
    {
        public static string connectString = Form1.connectString;
        private OleDbConnection myConnection;

        //string[] listbox;
        public Form2()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            preshowElements();
        }

        private void preshowElements()
        {
            //Form1 f1 = new Form1();
            string[] listbox = Form1.previewData;
            
            for (int i=0; i<listbox.Length; i++)
            {
                string[] item = listbox[i].Replace("\r", "").Split('\n');
                dataGridViewFit(item);
            }
        }

        public void dataGridViewFit(string[] item)
        {
            string[] itemData = item[0].Split(' ');
            string date = itemData[0];
            string time = itemData[1];
            string meal = itemData[2];
            if (itemData.Length > 4) meal += itemData[3];

            int ki = item.Length;
            if (item.Length > 2) ki--;
            for (int k = 1; k < ki; k++)
            {
                string[] subData = item[k].Split(' ');
                //int mass = Convert.ToInt16(subData[1].Substring(0, subData[1].Length - 1));
                int mass = Convert.ToInt16(subData[subData.Length-1].Trim('г'));
                int substr = subData[subData.Length - 1].ToString().Length;
                string product = item[k].Substring(0, item[k].Length - substr-1);
                string query = "SELECT Ккал, Белки, Жиры, Насыщенные_жирные_кислоты, Холестерин, Углеводы, Крахмал, [Моно и дисахара], [Добавленный сахар], Клетчатка, Спирт, [Витамин А], Каротин, [Ретиноловый эквивалент], В1, В2, [Никотиновая кислота], [Аскорбиновая кислота], [Добавленная соль], Натрий, Калий, Кальций, Фосфор, Железо, Магний FROM Продукты WHERE Наименование='" + product+"'";
                try
                {
                    OleDbCommand command = new OleDbCommand(query, myConnection);
                    OleDbDataReader reader = command.ExecuteReader();
                    List<double> nutrients = new List<double>();
                    while (reader.Read())
                    {
                        for(int i=0; i<25;i++)
                        {
                            nutrients.Add(Math.Round(Convert.ToDouble(reader[i]),2));                           
                        }                       
                        //nutrients.Add(reader.GetDouble(0));
                    }
                    reader.Close();

                    dgv.Rows.Add(date, time, meal, product, mass);
                    //dgv.Rows.Add();
                    for (int i = 5; i < 25 + 5; i++)
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[i].Value = Math.Round((nutrients[i - 5] * (mass / 100.0)), 2);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                    myConnection.Close();
                    return;
                }

                
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void excelExport_button_Click(object sender, EventArgs e)
        {
            string dir = "";
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //if (fbd.ShowDialog() == DialogResult.OK) dir = fbd.SelectedPath;            
            //else return;

            string fileName = "потребление микроэлементов " + dgv.Rows[0].Cells[0].Value.ToString().Replace('.', '_') + ".xls";
            string fileDir = Path.Combine(dir, fileName);
            if (File.Exists(fileDir)) fileDir = Path.GetDirectoryName(fileDir) + Path.GetFileNameWithoutExtension(fileDir) + "(1)" + ".xls";
            //File.Create(fileDir);
            Microsoft.Office.Interop.Excel.Application excApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {                
                excApp.Visible = true;
                //excApp.DisplayAlerts = false;
                Workbook wb = excApp.Workbooks.Add(Type.Missing);
                Worksheet wsh = wb.ActiveSheet;
                //wsh.Range[wsh.Cells[1, 1], wsh.Cells[1, 8]].Merge();
                for (int i=0; i<30; i++)
                {
                    wsh.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                for(int row=0;row<dgv.Rows.Count; row++)
                {
                    for (int cell=0; cell<dgv.Columns.Count; cell++)
                    {
                        string cellData = dgv.Rows[row].Cells[cell].Value.ToString();
                        wsh.Cells[row + 2, cell + 1] = dgv.Rows[row].Cells[cell].Value;
                    }
                }

                //excApp.Quit();
            }
            catch(Exception e1)
            {
                excApp.Quit();
                GC.Collect();
                MessageBox.Show(e1.ToString());
            }
        }


    }
}
