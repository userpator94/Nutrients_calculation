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

            DataTable dataTableRes = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectString))
            {
                OleDbCommand cmd = new OleDbCommand(query, conn); //"SELECT * FROM Рационы"
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTableRes);
                dgv1.DataSource = dataTableRes;
                adapter.Dispose();
                dataTableRes.Dispose();

                cmd = new OleDbCommand(query1, conn); //"SELECT * FROM Рационы"
                //conn.Open();
                adapter = new OleDbDataAdapter(cmd);
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
    }
}
;