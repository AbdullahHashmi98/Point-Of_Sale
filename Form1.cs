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
    public partial class point_of_sale : Form
    {
        int slide_panel;
        bool Hided;
        public point_of_sale()
        {
            
            InitializeComponent();
            slide_panel = slidepanel2.Width;
            Hided = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {//slide panel open and close
            try
            {
                if (Hided)
                {
                    panel_button.Text = ">";
                }
                else
                {
                    panel_button.Text = "<";
                }
                timer1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Hided)
                {//alredy hide then open
                    slidepanel2.Width = slidepanel2.Width + 20;
                    if (slidepanel2.Width >= slide_panel)
                    {
                        timer1.Stop();
                        Hided = false;
                        this.Refresh();
                    }
                }
                else
                {//open then hide
                    slidepanel2.Width = slidepanel2.Width - 20;
                    if (slidepanel2.Width <= 0)
                    {
                        timer1.Stop();
                        Hided = true;
                        this.Refresh();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {//go to order form.
            try
            {
                Order_Form order_form = new Order_Form();
                order_form.Show();
                this.Hide();
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void item_btn_Click(object sender, EventArgs e)
        {//goto item form
            try
            {
                Item_Form item_form = new Item_Form();
                item_form.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bill_Detail_btn_Click(object sender, EventArgs e)
        {//goto bill form.
            try
            {
                Bill_Details bill_datail = new Bill_Details();
                bill_datail.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
