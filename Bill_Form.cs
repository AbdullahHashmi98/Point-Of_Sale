using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Bill_Form : Form
    {
        Database db = new Database();
        List<int> item_id = new List<int>();
        List<string> item_name=new List<string>();
        List<int> item_price=new List<int>();
        List<int> item_qty=new List<int>();
        public Bill_Form()
        {
            InitializeComponent();
        }
        private void Cancel_btn_Click(object sender, EventArgs e)
        {//cancel order 
           DialogResult ask = MessageBox.Show("Are you sure want to cancel the order", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ask.Equals(DialogResult.Yes))//if yes then cancle
            {//move to order form and close current form
                try
                {
                    Order_Form order_form = new Order_Form();
                    order_form.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void List_View(int id,string name,int price,int qty)
        {//show all order item in list view
            item_id.Add(id);
            item_name.Add(name);
            item_price.Add(price);
            item_qty.Add(qty);

            Bill_View.Items.Add(id.ToString());
            Bill_View.Items.Add(name);
            Bill_View.Items.Add(price.ToString());
            Bill_View.Items.Add(qty.ToString());
        }

        private void Bill_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //foreach (object item in Bill_View.Items)
            //{
            //    sb.Append(item.ToString());
            //    sb.Append(" ");
            //}
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {//Add all order item in database.
            db.Add_In_Bill(item_id, item_name, item_price, item_qty);
        }
    }
}

