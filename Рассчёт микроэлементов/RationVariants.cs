using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рассчёт_микроэлементов
{
    public partial class RationVariants : Form
    {
        //private static string rationVar = "";
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=nutrients.mdb;";        
        //private OleDbConnection myConnection;

        public RationVariants()
        {
            InitializeComponent();
        }

        public RationVariants(string ratVar)
        {
            this.Text += "  - Рацион " + ratVar;
            InitializeComponent();

            //myConnection = new OleDbConnection(connectString);
            //myConnection.Open();
            dgvFiller(ratVar);
        }

        private void dgvFiller(string rationVar)
        {
            string query = "SELECT блюдо, продукты, Граммы, Ккал, Белки, [Аскорбиновая кислота], Жиры, Углеводы, Ретинол, Ниацин FROM Рационы WHERE (рацион='" + rationVar + "' AND вариант=1)";
            string query1 = "SELECT блюдо, продукты, Граммы, Ккал, Белки, [Аскорбиновая кислота], Жиры, Углеводы, Ретинол, Ниацин FROM Рационы WHERE (рацион='" + rationVar + "' AND вариант=2)";
            //OleDbCommand command = new OleDbCommand(query, myConnection);
            //OleDbDataReader reader = command.ExecuteReader();

            

            using (OleDbConnection conn = new OleDbConnection(connectString))
            {
                DataTable dataTableRes = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query, conn); //"SELECT * FROM Рационы"
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTableRes);
                dgv1.DataSource = dataTableRes;
                adapter.Dispose();
                dataTableRes.Dispose();

                //cmd = new OleDbCommand(query1, conn); //"SELECT * FROM Рационы"
                //conn.Open();
                //adapter = new OleDbDataAdapter(cmd);
                //adapter.Fill(dataTableRes);
                //dgv2.DataSource = dataTableRes;
                //adapter.Dispose();
                //conn.Close();
            }
            using (OleDbConnection conn = new OleDbConnection(connectString))
            {
                DataTable dataTableRes = new DataTable();
                OleDbCommand cmd = new OleDbCommand(query1, conn); //"SELECT * FROM Рационы"
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTableRes);
                dgv2.DataSource = dataTableRes;
                adapter.Dispose();
                conn.Close();
            }



        }

        private void RationVariants_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void excelExport_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //add data 
            int StartCol = 1;//`enter code here`
                int StartRow = 1;
            int j = 0, i = 0;

            //Write Headers
            for (j = 0; j < dgv1.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgv1.Columns[j].HeaderText;
            }

            StartRow++;

            //Write datagridview content
            if (tabControl1.SelectedTab == tabControl1.TabPages[0])
            {
                for (i = 0; i < dgv1.Rows.Count; i++)
                {
                    for (j = 0; j < dgv1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgv1[j, i].Value == null ? "" : dgv1[j, i].Value;
                            myRange.EntireColumn.AutoFit();
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                for (i = 0; i < dgv2.Rows.Count; i++)
                {
                    for (j = 0; j < dgv2.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgv2[j, i].Value == null ? "" : dgv2[j, i].Value;
                            myRange.EntireColumn.AutoFit();
                            //myRange.Columns.AutoFit();
                            //myRange.Columns[2].AutoFit();
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }            

            xlApp.Visible = true;
            this.Enabled = true;
        }

    }
}
;