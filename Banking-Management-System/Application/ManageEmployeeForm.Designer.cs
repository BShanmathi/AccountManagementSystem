namespace App
{
    partial class ManageEmployeeForm
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
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpPhnNumberLabel = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmployeeDesignationLabel = new System.Windows.Forms.Label();
            this.EmpIdTF = new System.Windows.Forms.TextBox();
            this.EmpNameTB = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberTB1 = new System.Windows.Forms.TextBox();
            this.EmpSalaryTB = new System.Windows.Forms.TextBox();
            this.EmpDesignationTB = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberTB2 = new System.Windows.Forms.TextBox();
            this.EmpTable = new System.Windows.Forms.DataGridView();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.BackColor = System.Drawing.Color.Red;
            this.EmpIdLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLabel.Location = new System.Drawing.Point(79, 155);
            this.EmpIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(112, 19);
            this.EmpIdLabel.TabIndex = 0;
            this.EmpIdLabel.Text = "Employee ID : ";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.Color.Red;
            this.EmpNameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Location = new System.Drawing.Point(56, 192);
            this.EmpNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(135, 19);
            this.EmpNameLabel.TabIndex = 1;
            this.EmpNameLabel.Text = "Employee Name : ";
            // 
            // EmpPhnNumberLabel
            // 
            this.EmpPhnNumberLabel.AutoSize = true;
            this.EmpPhnNumberLabel.BackColor = System.Drawing.Color.Red;
            this.EmpPhnNumberLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNumberLabel.Location = new System.Drawing.Point(15, 228);
            this.EmpPhnNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpPhnNumberLabel.Name = "EmpPhnNumberLabel";
            this.EmpPhnNumberLabel.Size = new System.Drawing.Size(180, 19);
            this.EmpPhnNumberLabel.TabIndex = 2;
            this.EmpPhnNumberLabel.Text = "Employee Phn Number : ";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.BackColor = System.Drawing.Color.Red;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.Location = new System.Drawing.Point(59, 268);
            this.EmpSalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(133, 19);
            this.EmpSalaryLabel.TabIndex = 3;
            this.EmpSalaryLabel.Text = "Employee Salary :";
            // 
            // EmployeeDesignationLabel
            // 
            this.EmployeeDesignationLabel.AutoSize = true;
            this.EmployeeDesignationLabel.BackColor = System.Drawing.Color.Red;
            this.EmployeeDesignationLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDesignationLabel.Location = new System.Drawing.Point(23, 305);
            this.EmployeeDesignationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeDesignationLabel.Name = "EmployeeDesignationLabel";
            this.EmployeeDesignationLabel.Size = new System.Drawing.Size(173, 19);
            this.EmployeeDesignationLabel.TabIndex = 4;
            this.EmployeeDesignationLabel.Text = "Employee Designation :";
            // 
            // EmpIdTF
            // 
            this.EmpIdTF.Location = new System.Drawing.Point(256, 151);
            this.EmpIdTF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpIdTF.Name = "EmpIdTF";
            this.EmpIdTF.Size = new System.Drawing.Size(193, 22);
            this.EmpIdTF.TabIndex = 5;
            // 
            // EmpNameTB
            // 
            this.EmpNameTB.Location = new System.Drawing.Point(256, 188);
            this.EmpNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpNameTB.Name = "EmpNameTB";
            this.EmpNameTB.Size = new System.Drawing.Size(193, 22);
            this.EmpNameTB.TabIndex = 6;
            this.EmpNameTB.Text = "+91";
            // 
            // EmpPhnNumberTB1
            // 
            this.EmpPhnNumberTB1.Enabled = false;
            this.EmpPhnNumberTB1.Location = new System.Drawing.Point(256, 220);
            this.EmpPhnNumberTB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpPhnNumberTB1.Name = "EmpPhnNumberTB1";
            this.EmpPhnNumberTB1.Size = new System.Drawing.Size(45, 22);
            this.EmpPhnNumberTB1.TabIndex = 7;
            this.EmpPhnNumberTB1.Text = "+91";
            // 
            // EmpSalaryTB
            // 
            this.EmpSalaryTB.Location = new System.Drawing.Point(256, 261);
            this.EmpSalaryTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpSalaryTB.Name = "EmpSalaryTB";
            this.EmpSalaryTB.Size = new System.Drawing.Size(193, 22);
            this.EmpSalaryTB.TabIndex = 8;
            // 
            // EmpDesignationTB
            // 
            this.EmpDesignationTB.Location = new System.Drawing.Point(256, 302);
            this.EmpDesignationTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpDesignationTB.Name = "EmpDesignationTB";
            this.EmpDesignationTB.Size = new System.Drawing.Size(193, 22);
            this.EmpDesignationTB.TabIndex = 9;
            // 
            // EmpPhnNumberTB2
            // 
            this.EmpPhnNumberTB2.Location = new System.Drawing.Point(311, 220);
            this.EmpPhnNumberTB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpPhnNumberTB2.Name = "EmpPhnNumberTB2";
            this.EmpPhnNumberTB2.Size = new System.Drawing.Size(139, 22);
            this.EmpPhnNumberTB2.TabIndex = 10;
            this.EmpPhnNumberTB2.Text = "+91";
            // 
            // EmpTable
            // 
            this.EmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpTable.Location = new System.Drawing.Point(497, 155);
            this.EmpTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpTable.Name = "EmpTable";
            this.EmpTable.ReadOnly = true;
            this.EmpTable.RowHeadersWidth = 51;
            this.EmpTable.Size = new System.Drawing.Size(532, 175);
            this.EmpTable.TabIndex = 11;
            this.EmpTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpTableCellClicked);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.White;
            this.LoadBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(19, 361);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(100, 28);
            this.LoadBtn.TabIndex = 12;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.White;
            this.InsertBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(127, 361);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(100, 28);
            this.InsertBtn.TabIndex = 13;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.White;
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(235, 361);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 28);
            this.UpdateBtn.TabIndex = 14;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(351, 361);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 28);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.BackColor = System.Drawing.Color.White;
            this.ViewAllBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllBtn.Location = new System.Drawing.Point(497, 105);
            this.ViewAllBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(532, 28);
            this.ViewAllBtn.TabIndex = 16;
            this.ViewAllBtn.Text = "View All Employee";
            this.ViewAllBtn.UseVisualStyleBackColor = false;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(616, 363);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(412, 22);
            this.SearchBox.TabIndex = 17;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchTBValueChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Red;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(493, 366);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(114, 19);
            this.SearchLabel.TabIndex = 18;
            this.SearchLabel.Text = "Search Here : ";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(16, 15);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 55);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(869, 15);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(160, 55);
            this.LogoutBtn.TabIndex = 20;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(19, 105);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(432, 28);
            this.RefreshBtn.TabIndex = 21;
            this.RefreshBtn.Text = "Refresh Data";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.EmpTable);
            this.Controls.Add(this.EmpPhnNumberTB2);
            this.Controls.Add(this.EmpDesignationTB);
            this.Controls.Add(this.EmpSalaryTB);
            this.Controls.Add(this.EmpPhnNumberTB1);
            this.Controls.Add(this.EmpNameTB);
            this.Controls.Add(this.EmpIdTF);
            this.Controls.Add(this.EmployeeDesignationLabel);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnNumberLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageEmployeeForm";
            this.Text = "ManageEmployeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpPhnNumberLabel;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmployeeDesignationLabel;
        private System.Windows.Forms.TextBox EmpIdTF;
        private System.Windows.Forms.TextBox EmpNameTB;
        private System.Windows.Forms.TextBox EmpPhnNumberTB1;
        private System.Windows.Forms.TextBox EmpSalaryTB;
        private System.Windows.Forms.TextBox EmpDesignationTB;
        private System.Windows.Forms.TextBox EmpPhnNumberTB2;
        private System.Windows.Forms.DataGridView EmpTable;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}