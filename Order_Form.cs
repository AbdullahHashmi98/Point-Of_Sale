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
    public partial class Order_Form : Form
    {
        Database db = new Database();//make intense of database class.
        Bill_Form bill_form = new Bill_Form();
        public Order_Form()
        {
            InitializeComponent();
        }

        private void Order_Form_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void Table()
        {//show datatable (from database class) on datagridview.
            try
            {
                DataTable dt = db.View_Items();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {//open main form and close current form
            try
            {
                point_of_sale pos = new point_of_sale();
                pos.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            try
            { 
                bill_form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {// Add to cart 
            try
            {
                bill_form.List_View(Convert.ToInt16(ID_txt.Text), Name_txt.Text, Convert.ToInt16(Price_txt.Text), Convert.ToInt16(Qty_txt.Value));
                DoClear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//in this select single row from database.
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {//selected rows shows in text boxes.
                    dataGridView1.CurrentRow.Selected = true;
                    ID_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Item_ID"].FormattedValue.ToString();
                    Name_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Item_Name"].FormattedValue.ToString();
                    Price_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Item_Price"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void DoClear()
        {//Clear text box 
            ID_txt.Clear();
            Name_txt.Clear();
            Price_txt.Clear();
            Qty_txt.ResetText();
        }

    }
}
