using Coffee_Managerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment.DAO
{
    public class BilllInfoDAO
    {
        private static BilllInfoDAO instance;

        public static BilllInfoDAO Instance
        {
            get { if (instance == null) instance = new BilllInfoDAO(); return BilllInfoDAO.instance; }
            private set { BilllInfoDAO.instance = value; }
        }

        private BilllInfoDAO() { }

        public List<BillInfo> GetListBillIfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BILL_INFO where ID_BILL = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
    }
}
