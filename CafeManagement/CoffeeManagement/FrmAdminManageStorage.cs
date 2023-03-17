using Library.Model;
using Library.Service;
using Library.Service.ServicesImplement;
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
    public partial class FrmAdminManageStorage : Form
    {
        public FrmAdminDashboard FrmAdminDashboard { get; set; }
        public FrmAdminManageStorage()
        {
            InitializeComponent();
        }

        private IIngredientService ingredientSevice = new IngredientServiceIml();

        private Ingredient ingredientStore { get; set; }

        private IEnumerable<Ingredient> listIngredientFilter;
        private void BtnAddNewIngreadient_Click(object sender, EventArgs e)
        {
            FrmAdminInsertIngredient frm = new FrmAdminInsertIngredient();
            frm.ShowDialog();
            searchByFilter();
        }

        private void FrmAdminManageStorage_Load(object sender, EventArgs e)
        {

            CbFilterIngredientList.Text = "Ingredient ID";

            IEnumerable<Ingredient> ingredientList = ingredientSevice.LoadIngredient();
            LoadIngredient(ingredientList);
        }

        public void LoadIngredient(IEnumerable<Ingredient> list)
        {
            //source = new BindingSource();
            //source.DataSource = list;
            DgvIngredientList.DataSource = null;
            DgvIngredientList.Rows.Clear();

            if (list != null)
            {
                DgvIngredientList.ColumnCount = 9;
                DgvIngredientList.Columns[0].Name = "Ingredient's ID";
                DgvIngredientList.Columns[1].Name = "Ingredient Name";
                DgvIngredientList.Columns[2].Name = "Unit";
                DgvIngredientList.Columns[3].Name = "Status";

                string status = "";

                foreach (var ingredient in list)
                {
                    if (ingredient.Status == 0)
                    {
                        status = "Inactive";
                    }
                    else
                    {
                        status = "Active";
                    }

                    string[] tmpIngredient = new string[]
                    {
                        ingredient.IngredientId.ToString(),
                        ingredient.Name.ToString(),
                        ingredient.Unit.ToString(),
                        status
                    };
                    DgvIngredientList.Rows.Add(tmpIngredient);
                }
            }

            DgvIngredientList.AllowUserToAddRows = false;
        }

        private void DgvIngredientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAdminUpdateIngredient frmAdminUpdateIngredient = new FrmAdminUpdateIngredient()
            {
                IngredientStore = this.ingredientStore,
            };
            frmAdminUpdateIngredient.ShowDialog();
            searchByFilter();
        }

        public void searchByFilter()
        {
            if (string.IsNullOrEmpty(TxtSearchIngredientFollowingFilter.Text.Trim()))
            {
                listIngredientFilter = ingredientSevice.LoadIngredient();
                LoadIngredient(listIngredientFilter);
            }
            else
            {
                switch (CbFilterIngredientList.Text)
                {
                    case "Ingredient ID":
                        if (int.TryParse(TxtSearchIngredientFollowingFilter.Text, out int id))
                        {
                            listIngredientFilter = ingredientSevice.GetIngredientByID(Convert.ToInt32(TxtSearchIngredientFollowingFilter.Text));
                            if (listIngredientFilter == null)
                            {
                                MessageBox.Show("Ingredient ID not found", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingredient ID is number", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }
            LoadIngredient(listIngredientFilter);

        }

        private void DgvIngredientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ingredientStore = new Ingredient()
                {
                    IngredientId = Convert.ToInt32(DgvIngredientList.Rows[e.RowIndex].Cells[0].Value.ToString()),
                };
            }
        }

        private void BtnSearchList_Click(object sender, EventArgs e)
        {
            searchByFilter();
        }
    }
}
