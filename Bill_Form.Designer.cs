namespace Point_Of_Sale
{
    partial class Bill_Form
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
            this.Bill_View = new System.Windows.Forms.ListView();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bill_View
            // 
            this.Bill_View.Location = new System.Drawing.Point(0, 0);
            this.Bill_View.Name = "Bill_View";
            this.Bill_View.Size = new System.Drawing.Size(457, 500);
            this.Bill_View.TabIndex = 0;
            this.Bill_View.UseCompatibleStateImageBehavior = false;
            this.Bill_View.SelectedIndexChanged += new System.EventHandler(this.Bill_View_SelectedIndexChanged);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(515, 39);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(103, 43);
            this.Confirm_btn.TabIndex = 1;
            this.Confirm_btn.Text = " Print";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Location = new System.Drawing.Point(515, 119);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(103, 45);
            this.Cancel_btn.TabIndex = 3;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 500);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Bill_View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Bill_View;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}