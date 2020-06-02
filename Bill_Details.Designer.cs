namespace Point_Of_Sale
{
    partial class Bill_Details
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
            this.Date_txt = new System.Windows.Forms.DateTimePicker();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date_txt
            // 
            this.Date_txt.Location = new System.Drawing.Point(60, 382);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(200, 20);
            this.Date_txt.TabIndex = 1;
            // 
            // Search_btn
            // 
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(436, 379);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(86, 23);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_btn.Location = new System.Drawing.Point(24, 449);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(91, 40);
            this.Home_btn.TabIndex = 3;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Bill_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 501);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Date_txt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill_Details";
            this.Load += new System.EventHandler(this.Bill_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker Date_txt;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Home_btn;
    }
}