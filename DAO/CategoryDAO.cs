using Coffee_Managerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Coffee_Managerment.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null)instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() {}

        public List<Category> GetListCategory()
        {

            List<Category> list = new List<Category>();
            string query = "select * from DRINK_CATEGORY";
            using (COFFEE_MANAGERMENTEntities db = new COFFEE_MANAGERMENTEntities())
            {
                var select = from s in db.DRINK_CATEGORY select s;
                //Debug.WriteLine(select);
                //var data = select;
                //foreach (var data in select)
                //{
                //    //Category category = new Category(data);
                //    //list.Add(data);
                //    Debug.WriteLine(data);
                //}
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
                //Debug.WriteLine(data);
                //Debug.WriteLine(item);
            }
            return list;
        }
    }
}
