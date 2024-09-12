namespace App
{
    partial class ManageCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomerForm));
            this.RefreshBtnn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBoxx = new System.Windows.Forms.TextBox();
            this.ViewAllBtnn = new System.Windows.Forms.Button();
            this.DeleteBtnn = new System.Windows.Forms.Button();
            this.UpdateBtnn = new System.Windows.Forms.Button();
            this.InsertBtnn = new System.Windows.Forms.Button();
            this.LoadBtnn = new System.Windows.Forms.Button();
            this.CustTable = new System.Windows.Forms.DataGridView();
            this.CustPhnNumberTB2 = new System.Windows.Forms.TextBox();
            this.CustPhnNumberTB1 = new System.Windows.Forms.TextBox();
            this.CustNameTB = new System.Windows.Forms.TextBox();
            this.CustIdTF = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBtnn
            // 
            this.RefreshBtnn.BackColor = System.Drawing.Color.White;
            this.RefreshBtnn.Enabled = false;
            this.RefreshBtnn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtnn.Location = new System.Drawing.Point(16, 96);
            this.RefreshBtnn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefreshBtnn.Name = "RefreshBtnn";
            this.RefreshBtnn.Size = new System.Drawing.Size(432, 28);
            this.RefreshBtnn.TabIndex = 43;
            this.RefreshBtnn.Text = "Refresh Data";
            this.RefreshBtnn.UseVisualStyleBackColor = false;
            this.RefreshBtnn.Click += new System.EventHandler(this.RefreshBtnn_Click_1);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(867, 15);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(160, 55);
            this.LogoutBtn.TabIndex = 42;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(16, 15);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 55);
            this.BackBtn.TabIndex = 41;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Red;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(488, 368);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(114, 19);
            this.SearchLabel.TabIndex = 40;
            this.SearchLabel.Text = "Search Here : ";
            // 
            // SearchBoxx
            // 
            this.SearchBoxx.Location = new System.Drawing.Point(611, 366);
            this.SearchBoxx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBoxx.Name = "SearchBoxx";
            this.SearchBoxx.Size = new System.Drawing.Size(417, 22);
            this.SearchBoxx.TabIndex = 39;
            this.SearchBoxx.TextChanged += new System.EventHandler(this.SearchBoxx_TextChanged);
            // 
            // ViewAllBtnn
            // 
            this.ViewAllBtnn.BackColor = System.Drawing.Color.White;
            this.ViewAllBtnn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllBtnn.Location = new System.Drawing.Point(492, 96);
            this.ViewAllBtnn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewAllBtnn.Name = "ViewAllBtnn";
            this.ViewAllBtnn.Size = new System.Drawing.Size(535, 28);
            this.ViewAllBtnn.TabIndex = 38;
            this.ViewAllBtnn.Text = "View All Customer";
            this.ViewAllBtnn.UseVisualStyleBackColor = false;
            this.ViewAllBtnn.Click += new System.EventHandler(this.ViewAllBtnn_Click_1);
            // 
            // DeleteBtnn
            // 
            this.DeleteBtnn.BackColor = System.Drawing.Color.White;
            this.DeleteBtnn.Enabled = false;
            this.DeleteBtnn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtnn.Location = new System.Drawing.Point(348, 366);
            this.DeleteBtnn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtnn.Name = "DeleteBtnn";
            this.DeleteBtnn.Size = new System.Drawing.Size(100, 28);
            this.DeleteBtnn.TabIndex = 37;
            this.DeleteBtnn.Text = "Delete";
            this.DeleteBtnn.UseVisualStyleBackColor = false;
            this.DeleteBtnn.Click += new System.EventHandler(this.DeleteBtnn_Click_1);
            // 
            // UpdateBtnn
            // 
            this.UpdateBtnn.BackColor = System.Drawing.Color.White;
            this.UpdateBtnn.Enabled = false;
            this.UpdateBtnn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtnn.Location = new System.Drawing.Point(232, 366);
            this.UpdateBtnn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateBtnn.Name = "UpdateBtnn";
            this.UpdateBtnn.Size = new System.Drawing.Size(100, 28);
            this.UpdateBtnn.TabIndex = 36;
            this.UpdateBtnn.Text = "Update";
            this.UpdateBtnn.UseVisualStyleBackColor = false;
            this.UpdateBtnn.Click += new System.EventHandler(this.UpdateBtnn_Click_1);
            // 
            // InsertBtnn
            // 
            this.InsertBtnn.BackColor = System.Drawing.Color.White;
            this.InsertBtnn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtnn.Location = new System.Drawing.Point(124, 366);
            this.InsertBtnn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsertBtnn.Name = "InsertBtnn";
            this.InsertBtnn.Size = new System.Drawing.Size(100, 28);
            this.InsertBtnn.TabIndex = 35;
            this.InsertBtnn.Text = "Insert";
            this.InsertBtnn.UseVisualStyleBackColor = false;
            this.InsertBtnn.Click += new System.EventHandler(this.InsertBtnn_Click_1);
            // 
            // LoadBtnn
            // 
            this.LoadBtnn.BackColor = System.Drawing.Color.White;
            this.LoadBtnn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtnn.Location = new System.Drawing.Point(16, 366);
            this.LoadBtnn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBtnn.Name = "LoadBtnn";
            this.LoadBtnn.Size = new System.Drawing.Size(100, 28);
            this.LoadBtnn.TabIndex = 34;
            this.LoadBtnn.Text = "Load";
            this.LoadBtnn.UseVisualStyleBackColor = false;
            this.LoadBtnn.Click += new System.EventHandler(this.LoadBtnn_Click_1);
            // 
            // CustTable
            // 
            this.CustTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustTable.Location = new System.Drawing.Point(492, 146);
            this.CustTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustTable.Name = "CustTable";
            this.CustTable.ReadOnly = true;
            this.CustTable.RowHeadersWidth = 51;
            this.CustTable.Size = new System.Drawing.Size(535, 192);
            this.CustTable.TabIndex = 33;
            this.CustTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustTable_CellContentClick);
            // 
            // CustPhnNumberTB2
            // 
            this.CustPhnNumberTB2.Location = new System.Drawing.Point(277, 279);
            this.CustPhnNumberTB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustPhnNumberTB2.Name = "CustPhnNumberTB2";
            this.CustPhnNumberTB2.Size = new System.Drawing.Size(169, 22);
            this.CustPhnNumberTB2.TabIndex = 32;
            // 
            // CustPhnNumberTB1
            // 
            this.CustPhnNumberTB1.Enabled = false;
            this.CustPhnNumberTB1.Location = new System.Drawing.Point(223, 279);
            this.CustPhnNumberTB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustPhnNumberTB1.Name = "CustPhnNumberTB1";
            this.CustPhnNumberTB1.Size = new System.Drawing.Size(45, 22);
            this.CustPhnNumberTB1.TabIndex = 29;
            this.CustPhnNumberTB1.Text = "+880";
            // 
            // CustNameTB
            // 
            this.CustNameTB.Location = new System.Drawing.Point(223, 229);
            this.CustNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustNameTB.Name = "CustNameTB";
            this.CustNameTB.Size = new System.Drawing.Size(224, 22);
            this.CustNameTB.TabIndex = 28;
            // 
            // CustIdTF
            // 
            this.CustIdTF.Location = new System.Drawing.Point(223, 177);
            this.CustIdTF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustIdTF.Name = "CustIdTF";
            this.CustIdTF.Size = new System.Drawing.Size(224, 22);
            this.CustIdTF.TabIndex = 27;
            // 
            // EmpPhnNumberLabel
            // 
            this.EmpPhnNumberLabel.AutoSize = true;
            this.EmpPhnNumberLabel.BackColor = System.Drawing.Color.Red;
            this.EmpPhnNumberLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNumberLabel.Location = new System.Drawing.Point(12, 283);
            this.EmpPhnNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpPhnNumberLabel.Name = "EmpPhnNumberLabel";
            this.EmpPhnNumberLabel.Size = new System.Drawing.Size(178, 19);
            this.EmpPhnNumberLabel.TabIndex = 24;
            this.EmpPhnNumberLabel.Text = "Customer Phn Number : ";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Red;
            this.EmpNameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Location = new System.Drawing.Point(53, 229);
            this.EmpNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(133, 19);
            this.EmpNameLabel.TabIndex = 23;
            this.EmpNameLabel.Text = "Customer Name : ";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.BackColor = System.Drawing.Color.Red;
            this.EmpIdLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLabel.Location = new System.Drawing.Point(76, 177);
            this.EmpIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(110, 19);
            this.EmpIdLabel.TabIndex = 22;
            this.EmpIdLabel.Text = "Customer ID : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 418);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(679, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // ManageCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RefreshBtnn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBoxx);
            this.Controls.Add(this.ViewAllBtnn);
            this.Controls.Add(this.DeleteBtnn);
            this.Controls.Add(this.UpdateBtnn);
            this.Controls.Add(this.InsertBtnn);
            this.Controls.Add(this.LoadBtnn);
            this.Controls.Add(this.CustTable);
            this.Controls.Add(this.CustPhnNumberTB2);
            this.Controls.Add(this.CustPhnNumberTB1);
            this.Controls.Add(this.CustNameTB);
            this.Controls.Add(this.CustIdTF);
            this.Controls.Add(this.EmpPhnNumberLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageCustomerForm";
            this.Text = "ManageCustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.CustTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtnn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchBoxx;
        private System.Windows.Forms.Button ViewAllBtnn;
        private System.Windows.Forms.Button DeleteBtnn;
        private System.Windows.Forms.Button UpdateBtnn;
        private System.Windows.Forms.Button InsertBtnn;
        private System.Windows.Forms.Button LoadBtnn;
        private System.Windows.Forms.DataGridView CustTable;
        private System.Windows.Forms.TextBox CustPhnNumberTB2;
        private System.Windows.Forms.TextBox CustPhnNumberTB1;
        private System.Windows.Forms.TextBox CustNameTB;
        private System.Windows.Forms.TextBox CustIdTF;
        private System.Windows.Forms.Label EmpPhnNumberLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}