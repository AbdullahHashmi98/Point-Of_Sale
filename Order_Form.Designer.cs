namespace Point_Of_Sale
{
    partial class Order_Form
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
            this.home_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Qty_txt = new System.Windows.Forms.NumericUpDown();
            this.Confirm_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 467);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(93, 32);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(479, 467);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(146, 31);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Add To Cart";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(21, 342);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.ReadOnly = true;
            this.ID_txt.Size = new System.Drawing.Size(52, 20);
            this.ID_txt.TabIndex = 3;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(93, 342);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.ReadOnly = true;
            this.Name_txt.Size = new System.Drawing.Size(310, 20);
            this.Name_txt.TabIndex = 4;
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(418, 342);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.ReadOnly = true;
            this.Price_txt.Size = new System.Drawing.Size(76, 20);
            this.Price_txt.TabIndex = 5;
            // 
            // Qty_txt
            // 
            this.Qty_txt.Location = new System.Drawing.Point(511, 342);
            this.Qty_txt.Name = "Qty_txt";
            this.Qty_txt.Size = new System.Drawing.Size(52, 20);
            this.Qty_txt.TabIndex = 6;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(344, 467);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(106, 31);
            this.Confirm_btn.TabIndex = 7;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 502);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Qty_txt);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_Form";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.NumericUpDown Qty_txt;
        private System.Windows.Forms.Button Confirm_btn;
    }
}