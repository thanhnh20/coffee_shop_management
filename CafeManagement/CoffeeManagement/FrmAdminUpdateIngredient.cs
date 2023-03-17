using Library.DataAccess;
using Library.Model;
using Library.Service;
using Library.Service.ServicesImplement;
using Library.Utils;
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
    public partial class FrmAdminUpdateIngredient : Form
    {
        public FrmAdminUpdateIngredient()
        {
            InitializeComponent();
        }

        public FrmAdminManageStorage parentForm { get; set; }


        private IIngredientService ingredientSevice = new IngredientServiceIml();

        public Ingredient IngredientStore { get; set; }

        private bool isClose { get; set; } = true;

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


        private void FrmAdminInsertIngredient_Load(object sender, EventArgs e)
        {
            BtnInsertIngredient.Text = "Update";
            DisplayCB();
            LoadIngredientInfo();
        }

        private void DisplayCB()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(0, "Inactive");
            comboSource.Add(1, "Active");
            cbStatus.DataSource = new BindingSource(comboSource, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
        }

        private void LoadIngredientInfo()
        {
            IngredientStore = ingredientSevice.GetIngredientById(IngredientStore.IngredientId);
            txtIngredientName.Text = IngredientStore.Name;
            txtUnit.Text = IngredientStore.Unit;
            DisplayCB();
            cbStatus.SelectedIndex = IngredientStore.Status;


        }

        private void BtnInsertIngredient_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Are you sure that you want to save?", "Insert a new student",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {


                Ingredient ingredient = ingredientSevice.GetIngredientById(IngredientStore.IngredientId);
                ingredient.Name = txtIngredientName.Text;
                ingredient.Unit = txtUnit.Text;
                ingredient.Status = ((KeyValuePair<int, string>)cbStatus.SelectedItem).Key;
                var resultError = MyHelper.CheckValid(ingredient);
                if (resultError != null)
                {
                    MessageBox.Show(resultError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ingredientSevice.UpdateIngredient(ingredient);
                    isClose = true;
                    MessageBox.Show("Update successfully", "Insert a ingredient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
