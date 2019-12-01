using Coffee_Managerment.DAO;
using Coffee_Managerment.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Managerment
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.TableWith,
                    Height = TableDAO.TableHight
                };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                //this.ShowAlert(ex.Message);
                //MessageBox.Show(item.Status);

                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "BÀN TRỐNG":
                        btn.BackColor = Color.Bisque;
                        break;
                    default:
                        btn.BackColor = Color.Violet;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Coffee_Managerment.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            foreach (Coffee_Managerment.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.DrinkName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                lsvBill.Items.Add(lsvItem);

            }
        }
        
        #endregion

        #region event

        void btn_Click(object sender, EventArgs e)
        {
            int TableID =((sender as Button).Tag as Table).ID;
            ShowBill(TableID);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
