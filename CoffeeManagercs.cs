using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment
{
    class CoffeeManagercs
    {
        public DRINK[] GetDRINKs()
        {
            var db = new COFFEE_MANAGERMENTEntities5();
            var DRINKs = db.DRINKs.ToArray();
            return DRINKs;
        }
        public DRINK_CATEGORY[] GetDRINK_CATEGORYs()
        {
            var db = new COFFEE_MANAGERMENTEntities5();
            var DRINK_CATEGORYs = db.DRINK_CATEGORY.ToArray();
            return DRINK_CATEGORYs;
        }
        public BILL[] GetBILLs()
        {
            var db = new COFFEE_MANAGERMENTEntities5();
            var BILLs = db.BILLs.ToArray();
            return BILLs;
        }
        public BILL_INFO[] GetBILL_INFOs()
        {
            var db = new COFFEE_MANAGERMENTEntities5();
            var BILL_INFOs = db.BILL_INFO.ToArray();
            return BILL_INFOs;
        }
        public TABLE_DRINK[] GetTABLE_DRINKs()
        {
            var db = new COFFEE_MANAGERMENTEntities5();
            var TABLE_DRINKs = db.TABLE_DRINK.ToArray();
            return TABLE_DRINKs;
        }
    }
}
