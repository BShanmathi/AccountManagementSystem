namespace App
{
    partial class AccountCreation
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
            this.txtacctype = new System.Windows.Forms.ComboBox();
            this.txtbal = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AccountSearchBox = new System.Windows.Forms.TextBox();
            this.accTable = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.CustId = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtacctype
            // 
            this.txtacctype.AccessibleName = "mmmm";
            this.txtacctype.FormattingEnabled = true;
            this.txtacctype.Items.AddRange(new object[] {
            "Saving",
            "Fix"});
            this.txtacctype.Location = new System.Drawing.Point(196, 186);
            this.txtacctype.Margin = new System.Windows.Forms.Padding(4);
            this.txtacctype.Name = "txtacctype";
            this.txtacctype.Size = new System.Drawing.Size(179, 24);
            this.txtacctype.TabIndex = 16;
            this.txtacctype.Text = "savings";
            this.txtacctype.SelectedIndexChanged += new System.EventHandler(this.txtacctype_SelectedIndexChanged);
            // 
            // txtbal
            // 
            this.txtbal.Location = new System.Drawing.Point(196, 233);
            this.txtbal.Margin = new System.Windows.Forms.Padding(4);
            this.txtbal.Name = "txtbal";
            this.txtbal.Size = new System.Drawing.Size(179, 22);
            this.txtbal.TabIndex = 15;
            this.txtbal.TextChanged += new System.EventHandler(this.txtbal_TextChanged);
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(196, 279);
            this.txtdes.Margin = new System.Windows.Forms.Padding(4);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(179, 68);
            this.txtdes.TabIndex = 14;
            // 
            // txtacc
            // 
            this.txtacc.Location = new System.Drawing.Point(196, 92);
            this.txtacc.Margin = new System.Windows.Forms.Padding(4);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(179, 22);
            this.txtacc.TabIndex = 13;
            this.txtacc.Text = "101120113012";
            this.txtacc.TextChanged += new System.EventHandler(this.txtacc_TextChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Balance :";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 310);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Description :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Account Type :";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Account No :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AccountSearchBox
            // 
            this.AccountSearchBox.Location = new System.Drawing.Point(541, 370);
            this.AccountSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.AccountSearchBox.Name = "AccountSearchBox";
            this.AccountSearchBox.Size = new System.Drawing.Size(465, 22);
            this.AccountSearchBox.TabIndex = 21;
            this.AccountSearchBox.TextChanged += new System.EventHandler(this.AccountSearchBox_TextChanged);
            // 
            // accTable
            // 
            this.accTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accTable.Location = new System.Drawing.Point(423, 143);
            this.accTable.Margin = new System.Windows.Forms.Padding(4);
            this.accTable.Name = "accTable";
            this.accTable.RowHeadersWidth = 51;
            this.accTable.Size = new System.Drawing.Size(585, 206);
            this.accTable.TabIndex = 19;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(423, 92);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(585, 43);
            this.button8.TabIndex = 20;
            this.button8.Text = "ViewCustomer[account]\r\n";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(89, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcid
            // 
            this.txtcid.ForeColor = System.Drawing.Color.Transparent;
            this.txtcid.Location = new System.Drawing.Point(196, 143);
            this.txtcid.Margin = new System.Windows.Forms.Padding(4);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(179, 22);
            this.txtcid.TabIndex = 25;
            this.txtcid.Text = "kumar";
            this.txtcid.TextChanged += new System.EventHandler(this.txtcid_TextChanged);
            // 
            // CustId
            // 
            this.CustId.BackColor = System.Drawing.Color.Red;
            this.CustId.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustId.Location = new System.Drawing.Point(37, 143);
            this.CustId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustId.Name = "CustId";
            this.CustId.Size = new System.Drawing.Size(116, 25);
            this.CustId.TabIndex = 24;
            this.CustId.Text = "Customer  Id :";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(849, 15);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(160, 55);
            this.LogoutBtn.TabIndex = 27;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(37, 15);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 55);
            this.BackBtn.TabIndex = 26;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Red;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(419, 373);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(114, 19);
            this.SearchLabel.TabIndex = 31;
            this.SearchLabel.Text = "Search Here : ";
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.CustId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AccountSearchBox);
            this.Controls.Add(this.accTable);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtacctype);
            this.Controls.Add(this.txtbal);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountCreation";
            this.Text = "AccountCreation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.accTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtacctype;
        private System.Windows.Forms.TextBox txtbal;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AccountSearchBox;
        private System.Windows.Forms.DataGridView accTable;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label CustId;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label SearchLabel;
    }
}