using Clothes.DataAccessLayer;
using Clothes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothes
{
    public partial class Inventory : Form
    {
   
        public  Inventory()
        {
            InitializeComponent();
        }

        private void frmMyInventory_Load(object sender, EventArgs e)
        {
            cbItems.ValueMember = "ItemId";
            cbItems.DisplayMember = "ItemName";
            cbItems.DataSource = ItemsDAL.GetAllItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item currentItem = ItemsDAL.GetItemById(int.Parse(cbItems.SelectedValue.ToString()));
            currentItem.Quantity += int.Parse(txtQuantity.Text);
            ItemsDAL.UpdateItem(currentItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Item currentItem = ItemsDAL.GetItemById(int.Parse(cbItems.SelectedValue.ToString()));
            currentItem.Quantity -= int.Parse(txtQuantity.Text);
            ItemsDAL.UpdateItem(currentItem);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
