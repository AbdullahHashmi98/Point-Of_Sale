namespace Point_Of_Sale
{
    partial class Item_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Itemname_txt = new System.Windows.Forms.TextBox();
            this.Itemprice_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 299);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Home_btn
            // 
            this.Home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_btn.Location = new System.Drawing.Point(12, 458);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(98, 34);
            this.Home_btn.TabIndex = 1;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(556, 331);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 32);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(556, 381);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 30);
            this.Update_btn.TabIndex = 3;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(556, 431);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 29);
            this.Delete_btn.TabIndex = 4;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Itemname_txt
            // 
            this.Itemname_txt.Location = new System.Drawing.Point(26, 364);
            this.Itemname_txt.Name = "Itemname_txt";
            this.Itemname_txt.Size = new System.Drawing.Size(297, 20);
            this.Itemname_txt.TabIndex = 5;
            // 
            // Itemprice_txt
            // 
            this.Itemprice_txt.Location = new System.Drawing.Point(349, 364);
            this.Itemprice_txt.Name = "Itemprice_txt";
            this.Itemprice_txt.Size = new System.Drawing.Size(100, 20);
            this.Itemprice_txt.TabIndex = 6;
            // 
            // Item_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 504);
            this.Controls.Add(this.Itemprice_txt);
            this.Controls.Add(this.Itemname_txt);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_Form";
            this.Load += new System.EventHandler(this.Item_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.TextBox Itemname_txt;
        private System.Windows.Forms.TextBox Itemprice_txt;
    }
}