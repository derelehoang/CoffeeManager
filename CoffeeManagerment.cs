using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment
{
    class CoffeeManagerment
    {
        public DRINK[] GetDrinks()
        {
            var db = new COFFEE_MANAGERMENTEntities2();
            var DRINKS = db.DRINKs.ToArray();
            return DRINKS;
        }
        public BILL[] GetBills()
        {
            var db = new COFFEE_MANAGERMENTEntities2();
            var BILLS = db.BILLs.ToArray();
            return BILLS;
        }
        public BILL_INFO[] GetBill_Infos()
        {
            var db = new COFFEE_MANAGERMENTEntities2();
            var BILL_INFOS = db.BILL_INFO.ToArray();
            return BILL_INFOS;
        }
    }
}
