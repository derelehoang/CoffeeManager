using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Managerment.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; //ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider();  return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        private string connectionSTR = @"Data Source=HUYHOANG-PC\HUYHOANG;Initial Catalog=COFFEE_MANAGERMENT;Persist Security Info=True;User ID=sa;Password=12112000";

        //private string connectionSTR = @"D:\C#\Coffee_Managerment\Model1.Context.cs";
       public object ExecuteScalar(string query, object[] Parameter = null)
       {
           object data = 0;
           using (SqlConnection connection = new SqlConnection(connectionSTR))
           {
               connection.Open();

               SqlCommand command = new SqlCommand(query, connection);

               if (Parameter != null)
               {
                   string[] listPara = query.Split(' ');
                   int i=0;
                   foreach (string item in listPara)
	                {
		                if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, Parameter[i]);
                            i++;
                        }
	                }
                }

               data = command.ExecuteScalar();

               connection.Close();
           }

           return data;
       }

       public DataTable ExecuteQuery(string query, object[] Parameter = null)
       {
           DataTable data = new DataTable();
           using (SqlConnection connection = new SqlConnection(connectionSTR))
           {
               connection.Open();

               SqlCommand command = new SqlCommand(query, connection);

               if (Parameter != null)
               {
                   string[] listPara = query.Split(' ');
                   int i = 0;
                   foreach (string item in listPara)
                   {
                       if (item.Contains('@'))
                       {
                           command.Parameters.AddWithValue(item, Parameter[i]);
                           i++;
                       }
                   }
               }

               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(data);

               connection.Close();
           }

           return data;
       }
       public int ExecuteNonQuery(string query, object[] Parameter = null)
       {
           int data = 0;
           using (SqlConnection connection = new SqlConnection(connectionSTR))
           {
               connection.Open();

               SqlCommand command = new SqlCommand(query, connection);

               if (Parameter != null)
               {
                   string[] listPara = query.Split(' ');
                   int i = 0;
                   foreach (string item in listPara)
                   {
                       if (item.Contains('@'))
                       {
                           command.Parameters.AddWithValue(item, Parameter[i]);
                           i++;
                       }
                   }
               }

               data = command.ExecuteNonQuery();

               connection.Close();
           }

           return data; 
       }
    }
}
