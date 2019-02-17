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
                int mass=0;
                try
                {
                    mass = Convert.ToInt16(subData[subData.Length - 1].Trim('г'));
                }
                catch {
                    MessageBox.Show("Проверьте есть ли значение массы продукта в списке добавленных продуктов в предыдущем окне");
                    this.Close();
                }
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

            //string fileName = "потребление микроэлементов " + dgv.Rows[0].Cells[0].Value.ToString().Replace('.', '_') + ".xls";
            //string fileDir = Path.Combine(dir, fileName);
            //if (File.Exists(fileDir)) fileDir = Path.GetDirectoryName(fileDir) + Path.GetFileNameWithoutExtension(fileDir) + "(1)" + ".xls";
            //File.Create(fileDir);
            Microsoft.Office.Interop.Excel.Application excApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {                
                excApp.Visible = false;
                //excApp.DisplayAlerts = false;
                Workbook wb = excApp.Workbooks.Add(Type.Missing);
                Worksheet wsh = wb.ActiveSheet;
                //wsh.Range[wsh.Cells[1, 1], wsh.Cells[1, 8]].Merge();
                for (int i=0; i<30; i++)
                {
                    wsh.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                double[] itog = new double[9];
                double[] sutoch = new double[15];
                double[] sum = new double[25];
                for(int row=0;row<dgv.Rows.Count; row++)
                {
                    for (int cell=0; cell<dgv.Columns.Count; cell++)
                    {                       
                        string cellData = dgv.Rows[row].Cells[cell].Value.ToString();
                        wsh.Cells[row + 2, cell + 1] = dgv.Rows[row].Cells[cell].Value;

                        if (cell + 1 >= 6 && cell + 1 < 9) {
                            itog[cell + 1 - 6] += Convert.ToDouble(cellData);
                            sutoch[cell + 1 - 6] += Convert.ToDouble(cellData);
                        }
                        if (cell + 1 == 11) {
                            itog[3] += Convert.ToDouble(cellData);
                            sutoch[3] += Convert.ToDouble(cellData);
                        }
                        if (cell + 1 == 18) sutoch[cell + 1 - 14] += Convert.ToDouble(cellData);
                        if (cell + 1 >= 19 && cell + 1 <= 23) {
                            itog[cell + 1 - 15] += Convert.ToDouble(cellData);
                            sutoch[cell + 1 - 14] += Convert.ToDouble(cellData);
                        }
                        if (cell + 1 >= 25 && cell + 1 <= 28) {
                            sutoch[cell + 1 - 15] += Convert.ToDouble(cellData);
                        }
                        if (cell + 1 == 30) {
                            sutoch[14] += Convert.ToDouble(cellData);
                        }
                        if (cell + 1 > 5)
                        {
                            sum[cell + 1 - 6] += Convert.ToDouble(cellData);
                            if (row == dgv.Rows.Count - 1) wsh.Cells[row + 3, cell+1] = sum[cell + 1 - 6];
                        }                        
                    }                    
                }
                wsh.Cells[dgv.Rows.Count + 2, 5] = "Сумма";                
                wsh.Cells[dgv.Rows.Count + 5, 1] = "Заключение";
                wsh.Cells[dgv.Rows.Count + 6, 1] = "Элементы";
                wsh.Cells[dgv.Rows.Count + 6, 2] = "Получено";
                wsh.Cells[dgv.Rows.Count + 6, 3] = "Норма";
                wsh.Cells[dgv.Rows.Count + 6, 4] = "Отклонение";

                //ЗАКЛЮЧЕНИЕ ЛПП
                if (ratio.rationSelect == "лпп")
                {
                    
                    string rationColumn="";
                    switch (ratio.rationNum)
                    {
                        case 1:
                            rationColumn = "рацион1";
                            break;
                        case 2:
                            rationColumn = "рацион2";
                            break;
                        case 3:
                            rationColumn = "рацион2а";
                            break;
                        case 4:
                            rationColumn = "рацион3";
                            break;
                        case 5:
                            rationColumn = "рацион4";
                            break;
                        case 6:
                            rationColumn = "рацион4а";
                            break;
                        case 7:
                            rationColumn = "рацион4б";
                            break;
                        case 8:
                            rationColumn = "рацион5";
                            break;
                        case 9:
                            rationColumn = "Витамины";
                            break;
                    }

                    string query = "SELECT [элементы], ["+ rationColumn +"] FROM ЛПП";
                    OleDbCommand command = new OleDbCommand(query, myConnection);
                    OleDbDataReader reader = command.ExecuteReader();
                    
                    for (int i = 0; i < itog.Length; i++)
                    {
                        reader.Read();
                        wsh.Cells[dgv.Rows.Count + 7 + i, 1] = reader[0];
                        wsh.Cells[dgv.Rows.Count + 7 + i, 2] = itog[i];
                        wsh.Cells[dgv.Rows.Count + 7 + i, 3] = reader[1];
                        if (Convert.ToDouble(reader[1]) != 0)
                        {
                            double d = Math.Round(((itog[i] / Convert.ToDouble(reader[1])) * 100.0),1)-100;
                            if (Math.Abs(d) > 10)
                            {
                                var redCell = wsh.Range[wsh.Cells[dgv.Rows.Count + 7 + i, 4], wsh.Cells[dgv.Rows.Count + 7 + i, 4]];
                                redCell.Interior.Color = XlRgbColor.rgbRed;
                            }
                            wsh.Cells[dgv.Rows.Count + 7 + i, 4] = d+" %";
                        }
                        else wsh.Cells[dgv.Rows.Count + 7 + i, 3] = "нормы не установлены";
                    }
                    reader.Close();
                }

                ////////СУТОЧНЫЙ
                if (ratio.rationSelect == "сут")
                {
                    string ageColumn = "";
                    if (ratio.age >= 18 && ratio.age < 30) ageColumn = "18_29";
                    if (ratio.age >= 30 && ratio.age < 40) ageColumn = "30_39";
                    if (ratio.age >= 40 && ratio.age < 60) ageColumn = "40_59";
                    if (ratio.age >= 60) ageColumn = "старше60";

                    string query = "SELECT [Показатель], [" + ageColumn + "] FROM [нормы] WHERE [пол]='" + ratio.sex + "'";
                    OleDbCommand comm = new OleDbCommand(query, myConnection);
                    OleDbDataReader reader = comm.ExecuteReader();

                    for (int i=0; i<sutoch.Length; i++)
                    {
                        reader.Read();
                        wsh.Cells[dgv.Rows.Count + 7 + i, 1] = reader[0];
                        wsh.Cells[dgv.Rows.Count + 7 + i, 2] = sutoch[i];
                        wsh.Cells[dgv.Rows.Count + 7 + i, 3] = reader[1];

                        if (Convert.ToDouble(reader[1]) != 0)
                        {
                            double d = Math.Round(((sutoch[i] / Convert.ToDouble(reader[1])) * 100.0), 1) - 100;
                            if (Math.Abs(d) > 10)
                            {
                                var redCell = wsh.Range[wsh.Cells[dgv.Rows.Count + 7 + i, 4], wsh.Cells[dgv.Rows.Count + 7 + i, 4]];
                                redCell.Interior.Color = XlRgbColor.rgbRed;
                            }
                            wsh.Cells[dgv.Rows.Count + 7 + i, 4] = d + " %";
                        }
                        else
                        {
                            wsh.Cells[dgv.Rows.Count + 7 + i, 3] = "нормы не установлены";
                        }
                    }
                    reader.Close();
                }


                //excApp.Quit();
                excApp.Visible = true;
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
