using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Managerment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TableManager());

            //Console.OutputEncoding = Encoding.UTF8;
            //using (var db = new COFFEE_MANAGERMENTEntities2())
            //{
            //    var select = from s in db. select s;
            //    foreach (var data in select)
            //    {
            //        Console.WriteLine("ID: {0}", data.DR)
            //    }
            //}
        }
    }
}
