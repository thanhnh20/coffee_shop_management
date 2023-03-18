using CoffeeManagement.Properties;
using FontAwesome.Sharp;
using Library.Model;
using Library.Service;
using Library.Service.ServicesImplement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmStaffOrderProduct : Form
    {
        public IProductService productServices = new ProductServiceIml();
        public FrmStaffDashboard FrmStaffDashboard { get; set; }

        List<Product> listOrder;

        public Product Product { get; set; }

        private static int maxWidth = 175;

        private static int maxHeight = 107;

        private double AmountOrder { get; set; }

        public Account AccountStaff { get; set; }
        public FrmStaffOrderProduct()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void BtnSearchList_Click(object sender, EventArgs e)
        {

        }

        private void LoadProduct()
        {
            var allProduct = productServices.GetAllProduct();
            ResourceManager rm = Resources.ResourceManager;
            foreach (var product in allProduct)
            {
                //set data for button
                IconButton button = new IconButton()
                {              
                    Width = maxWidth,
                    Height = maxHeight,
                    Text = product.ProductName,
                    TextAlign = ContentAlignment.BottomCenter,
                    BackgroundImage = (Bitmap)rm.GetObject(product.Image),
                    BackgroundImageLayout = ImageLayout.Zoom,
                    FlatStyle = FlatStyle.Flat,   
                    ForeColor = Color.White,     
                    
                };
                button.Tag = product;
                button.Click += Button_Click;
                button.Font = new Font("Calibri", 10F, FontStyle.Bold);
                if (product.Status == 1)
                {
                    button.BackColor = Color.Green;
                }
                else
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                    button.ForeColor = Color.White;
                }
                flpProduct.Controls.Add(button);
                //set id for button
                
            }
        }

        //Product click
        private void Button_Click(object? sender, EventArgs e)
        {
            if(sender != null)
            {
                Button button = sender as Button;
                Product = (Product)button.Tag;
                lbProductName.Text = Product.ProductName;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            if(listOrder == null)
            {
                listOrder = new List<Product>();
            }

            if(Product != null)
            {
                
                    var productFound = listOrder.Where(m => m.ProductId == Product.ProductId).FirstOrDefault();
                    if (productFound != null)
                    {
                        Product.CategoryId += int.Parse(dudQuantity.Text);
                    }
                    else
                    {
                        Product.CategoryId = int.Parse(dudQuantity.Text);
                        listOrder.Add(Product);
                    }
                

                                         
            }
            loadListOrder(listOrder);
        }

        public void loadListOrder(List<Product> ordersl)
        {
            if(ordersl != null)
            {
                dgvListProductOrdered.DataSource = ordersl.ToList();
                dgvListProductOrdered.Columns[0].Visible = false; 
                dgvListProductOrdered.Columns[2].Visible = false;
                dgvListProductOrdered.Columns[4].Visible = false;
                dgvListProductOrdered.Columns[5].Visible = false;
                dgvListProductOrdered.Columns[6].HeaderText = "Quantity";
                dgvListProductOrdered.Columns[7].Visible = false;
                dgvListProductOrdered.Columns[8].Visible = false;
                dgvListProductOrdered.Columns[9].Visible = false;

                double amount = 0;
                foreach (Product product in ordersl)
                {
                    amount += (double)(product.Price * product.CategoryId);
                }
                AmountOrder = amount;
                var amountFormat = string.Format("{0:#,##0}", amount);
                txtAmount.Text = amountFormat + " VND";
                txtAmount.ForeColor = Color.Red;
            }
        }

        private Product GetProductAtRowSelect() 
        {
                var product = new Product()
                {
                    ProductId = int.Parse(dgvListProductOrdered.SelectedCells[0].OwningRow.Cells[0].Value.ToString()),
                    ProductName = dgvListProductOrdered.SelectedCells[0].OwningRow.Cells[1].Value.ToString(),
                    Price = int.Parse(dgvListProductOrdered.SelectedCells[0].OwningRow.Cells[3].Value.ToString()),
                    CategoryId = int.Parse(dgvListProductOrdered.SelectedCells[0].OwningRow.Cells[6].Value.ToString()),
                };
                return product;   
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var productSelect = GetProductAtRowSelect();
                if (listOrder.Count > 0 && productSelect != null)
                {
                    var productFound = listOrder.Where(m => m.ProductId == productSelect.ProductId).FirstOrDefault();
                    listOrder.Remove(productFound);
                }
                loadListOrder(listOrder);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select Product to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void iconButton21_Click(object sender, EventArgs e)
        {
            if (listOrder == null || listOrder.Count == 0)
            {
                MessageBox.Show("Let's Order Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmStaffInsertCustomer frmStaffInsertCustomer = new FrmStaffInsertCustomer()
                {
                    AccountStaff = AccountStaff,
                    listOrder = listOrder,
                    isPayment = true,
                    amount = AmountOrder
                };
                this.Hide();
                frmStaffInsertCustomer.ShowDialog();
            }       
        }

    }
}
