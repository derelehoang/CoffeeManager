using Coffee_Managerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> ListMenu = new List<Menu>();
            

            string query = "SELECT D.NAME, BI.COUNT, D.PRICE, D.PRICE*BI.COUNT TotalPrice FROM DRINK D, BILL B, BILL_INFO BI WHERE  BI.ID_BILL = B.ID AND BI.ID_DRINK = D.ID AND ID_TABLE = "  + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                ListMenu.Add(menu);

            }
            return ListMenu;
        }
        
    }
}
