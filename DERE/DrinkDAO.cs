using Coffee_Managerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;

        public static DrinkDAO Instance
        {
            get { if (instance == null)instance = new DrinkDAO(); return DrinkDAO.instance; }
            private set { DrinkDAO.instance = value; }
        }
        private DrinkDAO() { }

        public List<Drink> GetDrinkByCategoryID(int id)
        {
            List<Drink> list = new List<Drink>();
            string query = "select * from DRINK where ID_CATEGORY= " +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }
            System.Diagnostics.Debug.WriteLine(list.ToString()+"List");
            return list;
        }
    }
}
