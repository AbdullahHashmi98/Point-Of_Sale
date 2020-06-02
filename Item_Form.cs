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
    public partial class Item_Form : Form
    {
        Database db = new Database();
        public int Item_ID;
        public Item_Form()
        {
            InitializeComponent();
        }

        private void Item_Form_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void Table()
        {
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

        private void Home_btn_Click(object sender, EventArgs e)
        {
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

        private bool isEmpty()
        {
            try
            {
                if (Itemname_txt.Text == string.Empty && Itemprice_txt.Text == string.Empty)
                {
                    MessageBox.Show("Fill the both boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void DoClear()
        {
            try
            {
                Itemname_txt.Clear();
                Itemprice_txt.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    Itemname_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Item_Name"].FormattedValue.ToString();
                    Itemprice_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Item_Price"].FormattedValue.ToString();
                    Item_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmpty())
                {
                    db.Add(Itemname_txt.Text, Itemprice_txt.Text);
                    Table();
                    DoClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmpty())
                {
                    db.Update(Itemname_txt.Text, Itemprice_txt.Text,Item_ID);
                    Table();
                    DoClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmpty())
                {
                    db.Delete(Itemname_txt.Text, Itemprice_txt.Text, Item_ID);
                    Table();
                    DoClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
