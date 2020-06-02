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
    public partial class Bill_Details : Form
    {
        Database db = new Database();
        public Bill_Details()
        {
            InitializeComponent();
        }
        private void Bill_Details_Load(object sender, EventArgs e)
        {//show datatable (from database class) on datagridview.
            try
            {
                DataTable dt = db.View_Bills();
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {//show main form and close current form.
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

        private void Search_btn_Click(object sender, EventArgs e)
        {//Show search data here.
            try
            {
                DataTable dt = db.Search(Date_txt.Text);
                dataGridView1.DataSource = dt;
                string data = Convert.ToString(dataGridView1.DataSource);
                MessageBox.Show("" + data, "Data", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
