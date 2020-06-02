using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
//this is the database class in which all database controls are written and call on different forms or class.
namespace Point_Of_Sale
{
    public class Database
    {
        //sql connection with project
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-25T8FI6\SQLEXPRESS;Initial Catalog=Point_Of_Sale;Integrated Security=True");
        DataTable dt = new DataTable();
        public DataTable View_Bills()
        {//In this func it returns datatable (rows and cols).
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Bills", connection);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            return dt;
        }

        public DataTable View_Items()
        {//this is the same return of datatable but different table.
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Items", connection);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private bool IsExits(string itemname)
        {//in this func we check if data is already exits in specific table.
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Items WHERE Item_Name = @Item_Name", connection);
            cmd.Parameters.AddWithValue("@Item_Name", itemname);
            connection.Open();
            int ItemExist = (int)cmd.ExecuteScalar();
            cmd.ExecuteNonQuery();
            connection.Close();

            if (ItemExist > 0)
            {
                MessageBox.Show("Already Exits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Add(string itemname,string itemprice)
        {//in this func we add some data in our database.
            if (IsExits(itemname))//check data exitences.
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Items VALUES (@Item_Name,@Item_Price)", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Item_Name", itemname);
                    cmd.Parameters.AddWithValue("@Item_Price", itemprice);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Your Item is Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Your Item is not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Update(string itemname,string itemprice,int item_id)
        {//in this func we update data in our database. 
            try
            {
                if(item_id > 0)//check if item is selected.
                {

                    SqlCommand cmd = new SqlCommand("UPDATE Items SET Item_Name= @Item_Name,Item_Price= @Item_Price WHERE Item_ID = @Item_ID ", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Item_Name", itemname);
                    cmd.Parameters.AddWithValue("@Item_Price", itemprice);
                    cmd.Parameters.AddWithValue("@Item_ID", item_id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Update Successful", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Update Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(string itemname,string itemprice,int item_id)
        {//in this func we delete specific data from our database.
            try
            {
                if (item_id > 0)//check if item is selected.
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM  Items WHERE Item_ID = @Item_ID ", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Item_ID", item_id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Delete Successful", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Delete Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Add_In_Bill(List<int> id,List<string> name,List<int> price,List<int> qty)
        {
           //in this func we add data in different table.
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Bills VALUES (@Item_ID,@Item_Name,@Item_Price,@Quantity,@Date)", connection);
                    cmd.CommandType = CommandType.Text;
                    for(int i=0;i<id.Count;i++)
                    {
                        cmd.Parameters.AddWithValue("@Item_ID", id[i]);
                        cmd.Parameters.AddWithValue("@Item_Name", name[i]);
                        cmd.Parameters.AddWithValue("@Item_Price", price[i]);
                        cmd.Parameters.AddWithValue("@Quantity", qty[i]);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Your Item is Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Your Item is not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        public DataTable Search(string date)
        {//In this func we search record according to date.
            try
            {
                SqlCommand cmd = new SqlCommand("select * from bills where date = @date", connection);
                cmd.Parameters.AddWithValue("@date", date);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;

        }

    }

}

