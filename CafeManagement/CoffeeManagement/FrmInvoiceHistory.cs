using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Service;
using Library.Service.ServicesImplement;
using System.Windows.Forms;
using Library.Model;

namespace CoffeeManagement
{
    public partial class FrmInvoiceHistory : Form
    {
        public IOrderService OrderService = new OrderServiceIml();
        public FrmAdminDashboard FrmAdminDashboard { get; set; }

        public Order Order { get; set; }    
        public FrmInvoiceHistory()
        {
            InitializeComponent();
            var ListOrder = OrderService.ListALL();
            LoadData(ListOrder);
            CbFilterInvoiceHistoryList.SelectedItem = "Order's ID";
            CbFilterInvoiceHistoryList.Text = "Order's ID";
        }

        public void LoadData(List<Order> ListOrder)
        {

            
            DgvInvoiceHistoryList.DataSource = null;
            DgvInvoiceHistoryList.Rows.Clear();


            if (ListOrder != null)
            {
                DgvInvoiceHistoryList.ColumnCount = 9;
                DgvInvoiceHistoryList.Columns[0].Name = "Order's ID";
                DgvInvoiceHistoryList.Columns[1].Name = "Date Order";
                DgvInvoiceHistoryList.Columns[2].Name = "Staff Create";
                DgvInvoiceHistoryList.Columns[3].Name = "Customer Number Phone";
                DgvInvoiceHistoryList.Columns[4].Name = "Payment Method";
                DgvInvoiceHistoryList.Columns[5].Name = "Status";
                DgvInvoiceHistoryList.Columns[6].Name = "Amount";

                foreach (var order in ListOrder)
                {
                    string[] ListResult = new string[]
                    {
                        order.OrderId.ToString(),
                        order.DateOrder.ToString(),
                        order.Staff.Fullname.ToString(),
                        order.PhoneNumber.ToString(),
                        order.PaymentMethod.Name.ToString(),
                        order.StatusOrder.Name.ToString(),
                        order.Amount.ToString(),

                    };
                    DgvInvoiceHistoryList.Rows.Add(ListResult);
                }
                
            }
        }


        private void DgvInvoiceHistoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Order = new Order()
                {
                    OrderId = Convert.ToInt32(DgvInvoiceHistoryList.Rows[e.RowIndex].Cells[0].Value.ToString()),
                };
            }
        }

        private void BtnSearchList_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(TxtSearchInvoiceFollowingFilter.Text.Trim());
            var listResult = OrderService.ListALLByOrderID(orderID);
            LoadData(listResult);
        }
    }
}
