
using Clothes.Entities;
using Clothes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothes.GUL
{
    public partial class Shopping : Form
    {FormState frmState = FormState.Add;
        Item currentItem = new Item();
        public Shopping()
        {
            InitializeComponent();
        }

        

  
        private void Shopping_Load(object sender, EventArgs e)
        {
            
            txtItemName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmState = FormState.WaitingToSave;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (frmState == FormState.WaitingToSave)
            {
                currentItem.ItemName = txtItemName.Text;
                currentItem.Unit = txtUnit.Text;
                currentItem.Quantity = double.Parse(txtQuantity.Text);
                currentItem.UserId = 1;

            }
            else if (frmState == FormState.WaitingToSaveOrDelete)
            {
                currentItem.ItemName = txtItemName.Text;
                currentItem.Unit = txtUnit.Text;
                currentItem.Quantity = double.Parse(txtQuantity.Text);
            }


            frmState = FormState.Add;
          

            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            frmState = FormState.Add;
           

            ClearForm();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
           

            ClearForm();
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = new DataGridViewRow();
            currentRow = dataGridViewItems.Rows[e.RowIndex];

            currentItem.ItemId = int.Parse(currentRow.Cells[0].Value.ToString());
            currentItem.ItemName = currentRow.Cells[1].Value.ToString();
            currentItem.Unit = currentRow.Cells[2].Value.ToString();
            currentItem.Quantity = double.Parse(currentRow.Cells[3].Value.ToString());
            currentItem.UserId = int.Parse(currentRow.Cells[4].Value.ToString());

            txtItemName.Text = currentItem.ItemName;
            txtUnit.Text = currentItem.Unit;
            txtQuantity.Text = currentItem.Quantity.ToString();


            frmState = FormState.WaitingToSaveOrDelete;
           
        }

     
    

        private void ClearForm()
        {
            txtItemName.Text = "";
            txtUnit.Text = "";
            txtQuantity.Text = "";

            txtItemName.Focus();
        }

       
    }
}  
    
   

