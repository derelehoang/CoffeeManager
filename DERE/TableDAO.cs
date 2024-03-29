﻿using Coffee_Managerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWith = 100;
        public static int TableHight = 100;

        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> TableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GETTableList");

            

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                TableList.Add(table);
            }
            return TableList;
        }
    }
}
