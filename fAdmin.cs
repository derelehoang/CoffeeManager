using Coffee_Managerment.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Managerment
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            
        }


        private void tpCategoryDrink_Click(object sender, EventArgs e)
        {

        }
        //void LoadAccountList()
        //{
        //    string connectionSTR = @"Data Source=DESKTOP-IKCEBER\PHUONGANH;Initial Catalog=COFFEE_MANAGERMENT;Persist Security Info=True;User ID=sa; Password=110220";
        //    SqlConnection connection = new SqlConnection(connectionSTR);

        //    string query = "SELECT * FROM ACCOUNT";

        //    connection.Open();

        //    SqlCommand command = new SqlCommand(query, connection);

        //    DataTable data = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);

        //    adapter.Fill(data);

        //    connection.Close();

        //    dtgvAccount.DataSource = data;
        //}
    }
}
