using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment.DTO
{
    public class Table
    {

        public Table(int ID, string NAME, string STATUS)
        {
            this.ID = ID;
            this.Name = NAME;
            this.Status = STATUS;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["NAME"].ToString();
            this.Status = row["STATUS"].ToString();
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        
    }
}
