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
    public partial class FrmAdminInsertNewProduct : Form
    {
        private IProductService productService = new ProductServiceIml();
        private ICategoryProductService categoryProductService = new CategoryProductServiceIml();
        private IIngredientService ingredientService = new IngredientServiceIml();
        private IIngredientProductService ingredientProductService = new IngredientProductServiceIml();



        private bool isClose { get; set; } = true;
        public FrmAdminInsertNewProduct()
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

            Product product = new Product()
            {
                ProductName = txtProductName.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDouble(txtPrice.Text),
                Image = txtImage.Text,
                Status = ((KeyValuePair<int, string>)cbStatus.SelectedItem).Key,
                CategoryId = categoryProductService.GetCategoryProductByName(CbCategory.SelectedItem.ToString()).CategoryId
            };
            productService.InsertProduct(product);
            var listIngredientName = ingredientService.GetIngredientByName(cbIngredient.SelectedItem.ToString());


            foreach (var ingredientName in listIngredientName)
            {
                var ingredientId = ingredientName.IngredientId;
                var mass = Convert.ToInt32(txtMass.Text);
                ingredientProductService.insertIngredientProduct(product, ingredientId, mass);
            }
            MessageBox.Show("Inserted successfully", "Insert a Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }


        private void FrmAdminInsertNewProduct_Load(object sender, EventArgs e)
        {
            txtPrice.PasswordChar = '\0';
            cklIngredient.Visible = false;
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(0, "Out of stocks");
            comboSource.Add(1, "In stocks");
            cbStatus.DataSource = new BindingSource(comboSource, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
            // For example get from database continentals.
            cbIngredient.DataSource = ingredientService.GetNameIngredient();
            CbCategory.DataSource = categoryProductService.GetCategoryProductsName();
            var Result = ingredientService.GetNameIngredient().ToList();
            foreach (var item in Result)
            {
                cklIngredient.Items.Add(item);
            }
        }
    }
}
