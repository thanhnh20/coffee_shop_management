using Library.Model;
using Library.Service;
using Library.Service.ServicesImplement;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmAdminManageProductList : Form
    {

        public FrmAdminDashboard FrmAdminDashboard { get; set; }

        private IProductService productService = new ProductServiceIml();

        private IEnumerable<Product> listProduct;

        private Product producttStore { get; set; }

        public FrmAdminManageProductList()
        {
            InitializeComponent();
        }

        private void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            FrmAdminInsertNewProduct frm = new FrmAdminInsertNewProduct();
            frm.ShowDialog();
            this.FrmAdminManageProductList_Load(sender, e);
        }

        private void FrmAdminManageProductList_Load(object sender, EventArgs e)
        {
            IEnumerable<Product> productList = productService.GetProducts();
            LoadProduct(productList);
        }

        public void searchByFilter()
        {
            if (string.IsNullOrEmpty(TxtSearchProductFollowingFilter.Text.Trim()))

            {
                listProduct = productService.GetProducts();
                if (listProduct != null)
                {
                    LoadProduct(listProduct);
                }
                else
                {
                    MessageBox.Show("Product's List is empty", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            else
            {
                switch (CbFilterProductList.Text)
                {
                    case "Product Name":
                        listProduct = productService.GetProductByName(TxtSearchProductFollowingFilter.Text);
                        if (listProduct == null)
                        {
                            MessageBox.Show("Product's Name not found", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        break;
                }


            }
            LoadProduct(listProduct);

        }

        public void LoadProduct(IEnumerable<Product> list)
        {
            DgvProductList.DataSource = null;
            DgvProductList.Rows.Clear();
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(0, "Product Name");
            CbFilterProductList.SelectedItem = "Product's Name";
            if (list != null)
            {
                DgvProductList.ColumnCount = 9;
                DgvProductList.Columns[0].Name = "Product's ID";
                DgvProductList.Columns[1].Name = "Product Name";
                DgvProductList.Columns[2].Name = "Description";
                DgvProductList.Columns[3].Name = "Price";
                DgvProductList.Columns[4].Name = "Image";
                DgvProductList.Columns[5].Name = "Status";
                DgvProductList.Columns[6].Name = "Category's ID";




                string status = "";

                foreach (var product in list)
                {
                    if (product.Status == 0)
                    {
                        status = "Inactive";
                    }
                    else
                    {
                        status = "Active";
                    }

                    string[] tmpProduct = new string[]
                    {
                        product.ProductId.ToString(),
                        product.ProductName.ToString(),
                        product.Description.ToString(),
                        product.Price.ToString(),
                        product.Image.ToString(),
                        status,
                        product.CategoryId.ToString(),
                    };
                    DgvProductList.Rows.Add(tmpProduct);
                }
            }

            DgvProductList.AllowUserToAddRows = false;
        }

        private void BtnSearchList_Click(object sender, EventArgs e)
        {
            searchByFilter();
        }

        private void DgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                producttStore = new Product()
                {
                    ProductId = Convert.ToInt32(DgvProductList.Rows[e.RowIndex].Cells[0].Value.ToString()),
                };
            }

        }

        private void DgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAdminUpdateProduct frmAdminUpdateProduct = new FrmAdminUpdateProduct()
            {
                ProductStore = this.producttStore,
            };
            frmAdminUpdateProduct.ShowDialog();
            searchByFilter();
        }
    }
}
