using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.Run(new fTableManager());

            

           
            //using (var db = new COFFEE_MANAGERMENTEntities3())
            //{
            //    var select = from s in db.BILLs select s;
            //    foreach (var data in select)
            //    {

            //    }
            //}
            //using (var db = new COFFEE_MANAGERMENTEntities3())
            //{
            //    var select = from a in db.BILL_INFO select a;
            //    foreach (var data in select)
            //    {

            //    }
            //}
            //using (var db = new COFFEE_MANAGERMENTEntities3())
            //{
            //    var select = from x in db.TABLE_DRINK select x;
            //    foreach (var data in select)
            //    {

            //    }
            //}
        }
    }
}

