using Library.Service.ServicesImplement;
using Library.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Library.Model;
using System.Windows.Controls;

namespace CoffeeManagement
{
    public partial class FrmAdminUpdateProduct : Form
    {
        private IProductService productService = new ProductServiceIml();
        private ICategoryProductService categoryProductService = new CategoryProductServiceIml();
        private IIngredientService ingredientService = new IngredientServiceIml();
        private IIngredientProductService ingredientProductService = new IngredientProductServiceIml();



        private bool isClose { get; set; } = true;

        public Product ProductStore { get; set; }

        public FrmAdminUpdateProduct()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (isClose)
            {
                {
                    DialogResult isExit = MessageBox.Show("Are your sure that you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (isExit == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }

        }

        private void BtnInsertANewProduct_Click(object sender, EventArgs e)
        {

            Product product = productService.GetProductByID(ProductStore.ProductId);
            product.ProductName = txtProductName.Text;
            product.Price = Convert.ToDouble(txtPrice.Text);
            product.Image = txtImage.Text;
            product.Status = ((KeyValuePair<int, string>)cbStatus.SelectedItem).Key;
            product.CategoryId = categoryProductService.GetCategoryProductByName(CbCategory.SelectedItem.ToString()).CategoryId;
            product.Description = txtDescription.Text;
            productService.UpdateProduct(product);
            var listIngredients = ingredientService.GetIngredientByName(cbIngredient.SelectedItem.ToString());


            foreach (var ingredient in listIngredients)
            {
                var ingredientId = ingredient.IngredientId;
                var mass = Convert.ToInt32(txtMass.Text);
                ingredientProductService.updateIngredientProduct(product, ingredientId, mass);
            }
            MessageBox.Show("Update successfully", "Update a Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }


        private void FrmAdminInsertNewProduct_Load(object sender, EventArgs e)
        {
            BtnInsertANewProduct.Text = "Update";
            LbHeader.Text = "Update a product";
            txtPrice.PasswordChar = '\0';
            cklIngredient.Visible = false;
            ProductStore = productService.GetProductByID(ProductStore.ProductId);
            txtProductName.Text = ProductStore.ProductName;
            txtDescription.Text = ProductStore.Description;
            txtImage.Text = ProductStore.Image;
            txtPrice.Text = ProductStore.Price.ToString();


            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(0, "Unavailable");
            comboSource.Add(1, "Available");
            cbStatus.DataSource = new BindingSource(comboSource, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
            // For example get from database continentals.
            cbIngredient.DataSource = ingredientService.GetNameIngredient();
            CbCategory.DataSource = categoryProductService.GetCategoryProductsName();

            var ingredientProductStore = ingredientProductService.GetByID(ProductStore.ProductId);

            txtMass.Text = ingredientProductStore.Mass.ToString();

            CbCategory.SelectedItem = ProductStore.CategoryId;
            cbStatus.SelectedIndex = (int)ProductStore.Status;
            //cbIngredient.SelectedIndex = ProductStore.IngredientProducts.i
        }
    }
}
