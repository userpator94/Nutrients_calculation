using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рассчёт_микроэлементов
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DateTime finalDate;
            DateTime.TryParse("11.11.2018", out finalDate);
            DateTime today = DateTime.Today;
            TimeSpan ts = today - finalDate;
            if (ts.Days >= 0)
            {
                MessageBox.Show("Неизвестная ошибка", "Внимание",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
            else
            {
                //using (Stream resource = GetType().Assembly
                //                      .GetManifestResourceStream(resourceName))
                //{
                //    if (resource == null)
                //    {
                //        throw new ArgumentException("No such resource", "resourceName");
                //    }
                //    using (Stream output = File.OpenWrite(file))
                //    {
                //        resource.CopyTo(output);
                //    }
                //}
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            
        }
    }
}
