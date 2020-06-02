namespace Point_Of_Sale
{
    partial class point_of_sale
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
            this.components = new System.ComponentModel.Container();
            this.slidepanel1 = new System.Windows.Forms.Panel();
            this.panel_button = new System.Windows.Forms.Button();
            this.slidepanel2 = new System.Windows.Forms.Panel();
            this.item_btn = new System.Windows.Forms.Button();
            this.Bill_Detail_btn = new System.Windows.Forms.Button();
            this.Order_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slidepanel1.SuspendLayout();
            this.slidepanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidepanel1
            // 
            this.slidepanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.slidepanel1.Controls.Add(this.panel_button);
            this.slidepanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidepanel1.Location = new System.Drawing.Point(0, 0);
            this.slidepanel1.Name = "slidepanel1";
            this.slidepanel1.Size = new System.Drawing.Size(30, 493);
            this.slidepanel1.TabIndex = 0;
            // 
            // panel_button
            // 
            this.panel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_button.Location = new System.Drawing.Point(0, 0);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(30, 34);
            this.panel_button.TabIndex = 2;
            this.panel_button.Text = ">\r\n";
            this.panel_button.UseVisualStyleBackColor = true;
            this.panel_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // slidepanel2
            // 
            this.slidepanel2.BackColor = System.Drawing.Color.Transparent;
            this.slidepanel2.Controls.Add(this.item_btn);
            this.slidepanel2.Controls.Add(this.Bill_Detail_btn);
            this.slidepanel2.Controls.Add(this.Order_btn);
            this.slidepanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidepanel2.Location = new System.Drawing.Point(30, 0);
            this.slidepanel2.Name = "slidepanel2";
            this.slidepanel2.Size = new System.Drawing.Size(137, 493);
            this.slidepanel2.TabIndex = 1;
            // 
            // item_btn
            // 
            this.item_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_btn.Location = new System.Drawing.Point(28, 224);
            this.item_btn.Name = "item_btn";
            this.item_btn.Size = new System.Drawing.Size(75, 50);
            this.item_btn.TabIndex = 4;
            this.item_btn.Text = "Items";
            this.item_btn.UseVisualStyleBackColor = true;
            this.item_btn.Click += new System.EventHandler(this.item_btn_Click);
            // 
            // Bill_Detail_btn
            // 
            this.Bill_Detail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Detail_btn.Location = new System.Drawing.Point(28, 122);
            this.Bill_Detail_btn.Name = "Bill_Detail_btn";
            this.Bill_Detail_btn.Size = new System.Drawing.Size(75, 47);
            this.Bill_Detail_btn.TabIndex = 3;
            this.Bill_Detail_btn.Text = "Bill";
            this.Bill_Detail_btn.UseVisualStyleBackColor = true;
            this.Bill_Detail_btn.Click += new System.EventHandler(this.Bill_Detail_btn_Click);
            // 
            // Order_btn
            // 
            this.Order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_btn.Location = new System.Drawing.Point(28, 25);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Size = new System.Drawing.Size(75, 45);
            this.Order_btn.TabIndex = 2;
            this.Order_btn.Text = "Order";
            this.Order_btn.UseVisualStyleBackColor = true;
            this.Order_btn.Click += new System.EventHandler(this.Order_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // point_of_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Point_Of_Sale.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(703, 493);
            this.Controls.Add(this.slidepanel2);
            this.Controls.Add(this.slidepanel1);
            this.Name = "point_of_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Of Sale";
            this.slidepanel1.ResumeLayout(false);
            this.slidepanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slidepanel1;
        private System.Windows.Forms.Button panel_button;
        private System.Windows.Forms.Panel slidepanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.Button item_btn;
        private System.Windows.Forms.Button Bill_Detail_btn;
    }
}

