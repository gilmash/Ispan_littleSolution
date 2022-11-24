namespace ISpan
{
    partial class UsersForm
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
            this.addnewButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIndexVMBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.userIndexVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addnewButton
            // 
            this.addnewButton.Location = new System.Drawing.Point(12, 32);
            this.addnewButton.Name = "addnewButton";
            this.addnewButton.Size = new System.Drawing.Size(84, 33);
            this.addnewButton.TabIndex = 0;
            this.addnewButton.Text = "新增使用者";
            this.addnewButton.UseVisualStyleBackColor = true;
            this.addnewButton.Click += new System.EventHandler(this.addnewButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(402, 195);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userIndexVMBindingSource4
            // 
            this.userIndexVMBindingSource4.DataSource = typeof(ISpan.Model.ViewModels.UserIndexVM);
            // 
            // userIndexVMBindingSource3
            // 
            this.userIndexVMBindingSource3.DataSource = typeof(ISpan.Model.ViewModels.UserIndexVM);
            // 
            // userIndexVMBindingSource2
            // 
            this.userIndexVMBindingSource2.DataSource = typeof(ISpan.Model.ViewModels.UserIndexVM);
            // 
            // userIndexVMBindingSource1
            // 
            this.userIndexVMBindingSource1.DataSource = typeof(ISpan.Model.ViewModels.UserIndexVM);
            // 
            // userIndexVMBindingSource
            // 
            this.userIndexVMBindingSource.DataSource = typeof(ISpan.Model.ViewModels.UserIndexVM);
            // 
            // userVMBindingSource
            // 
            this.userVMBindingSource.DataSource = typeof(ISpan.Model.ViewModels.UserVM);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "帳密";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addnewButton);
            this.Name = "UsersForm";
            this.Text = "使用者資料";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addnewButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userIndexVMBindingSource1;
        private System.Windows.Forms.BindingSource userIndexVMBindingSource;
        private System.Windows.Forms.BindingSource userIndexVMBindingSource2;
        private System.Windows.Forms.BindingSource userIndexVMBindingSource3;
        private System.Windows.Forms.BindingSource userIndexVMBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userVMBindingSource;
    }
}