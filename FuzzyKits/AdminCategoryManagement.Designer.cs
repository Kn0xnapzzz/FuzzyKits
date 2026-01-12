namespace FuzzyKits
{
    partial class AdminCategoryManagement
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
            this.HCategory = new System.Windows.Forms.TextBox();
            this.BtAdd = new RoundedButton();
            this.BtDelete = new RoundedButton();
            this.BtUpdate = new RoundedButton();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.txtCategory = new RoundTextBox();
            this.BtClose = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // HCategory
            // 
            this.HCategory.BackColor = System.Drawing.Color.White;
            this.HCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.HCategory.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HCategory.Location = new System.Drawing.Point(12, 12);
            this.HCategory.Name = "HCategory";
            this.HCategory.ReadOnly = true;
            this.HCategory.Size = new System.Drawing.Size(508, 56);
            this.HCategory.TabIndex = 8;
            this.HCategory.Text = "Category";
            this.HCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtAdd.BorderColor = System.Drawing.Color.Black;
            this.BtAdd.BorderRadius = 15;
            this.BtAdd.BorderThickness = 2;
            this.BtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAdd.FlatAppearance.BorderSize = 0;
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtAdd.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.Location = new System.Drawing.Point(12, 553);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(120, 38);
            this.BtAdd.TabIndex = 22;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = false;
            // 
            // BtDelete
            // 
            this.BtDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtDelete.BorderColor = System.Drawing.Color.Black;
            this.BtDelete.BorderRadius = 15;
            this.BtDelete.BorderThickness = 2;
            this.BtDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtDelete.FlatAppearance.BorderSize = 0;
            this.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtDelete.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDelete.Location = new System.Drawing.Point(138, 553);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(114, 38);
            this.BtDelete.TabIndex = 23;
            this.BtDelete.Text = "Delete";
            this.BtDelete.UseVisualStyleBackColor = false;
            // 
            // BtUpdate
            // 
            this.BtUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtUpdate.BorderColor = System.Drawing.Color.Black;
            this.BtUpdate.BorderRadius = 15;
            this.BtUpdate.BorderThickness = 2;
            this.BtUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtUpdate.FlatAppearance.BorderSize = 0;
            this.BtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtUpdate.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUpdate.Location = new System.Drawing.Point(269, 553);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(118, 38);
            this.BtUpdate.TabIndex = 24;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = false;
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(12, 144);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(508, 392);
            this.dgvCategories.TabIndex = 25;
            this.dgvCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtCategory
            // 
            this.txtCategory.BorderColor = System.Drawing.Color.Black;
            this.txtCategory.BorderRadius = 20;
            this.txtCategory.BorderThickness = 2;
            this.txtCategory.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F);
            this.txtCategory.Location = new System.Drawing.Point(12, 83);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Padding = new System.Windows.Forms.Padding(10);
            this.txtCategory.Size = new System.Drawing.Size(508, 45);
            this.txtCategory.TabIndex = 26;
            this.txtCategory.UseSystemPasswordChar = false;
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtClose.BorderColor = System.Drawing.Color.Black;
            this.BtClose.BorderRadius = 15;
            this.BtClose.BorderThickness = 2;
            this.BtClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtClose.FlatAppearance.BorderSize = 0;
            this.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtClose.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClose.Location = new System.Drawing.Point(402, 553);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(118, 38);
            this.BtClose.TabIndex = 27;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = false;
            // 
            // AdminCategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(532, 603);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtDelete);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.HCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminCategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.Load += new System.EventHandler(this.AdminCategoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HCategory;
        private RoundedButton BtAdd;
        private RoundedButton BtDelete;
        private RoundedButton BtUpdate;
        private System.Windows.Forms.DataGridView dgvCategories;
        private RoundTextBox txtCategory;
        private RoundedButton BtClose;
    }
}