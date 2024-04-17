namespace WFA240417
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbFilter = new TextBox();
            dgvPeople = new DataGridView();
            lblSelName = new Label();
            txbEmail = new TextBox();
            btnUpdate = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // txbFilter
            // 
            txbFilter.Font = new Font("Microsoft Sans Serif", 12F);
            txbFilter.Location = new Point(12, 12);
            txbFilter.Name = "txbFilter";
            txbFilter.Size = new Size(615, 26);
            txbFilter.TabIndex = 0;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeColumns = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvPeople.Location = new Point(12, 51);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersVisible = false;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(615, 299);
            dgvPeople.TabIndex = 1;
            // 
            // lblSelName
            // 
            lblSelName.AutoSize = true;
            lblSelName.Font = new Font("Microsoft Sans Serif", 12F);
            lblSelName.Location = new Point(12, 379);
            lblSelName.Name = "lblSelName";
            lblSelName.Size = new Size(180, 20);
            lblSelName.TabIndex = 2;
            lblSelName.Text = "###placeholder_text###";
            lblSelName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txbEmail.Location = new Point(198, 376);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(222, 26);
            txbEmail.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(426, 376);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 26);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE e-mail";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 2F;
            Column2.HeaderText = "name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 1F;
            Column3.HeaderText = "age";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 2F;
            Column4.HeaderText = "e-mail";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 2F;
            Column5.HeaderText = "city";
            Column5.Name = "Column5";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 423);
            Controls.Add(btnUpdate);
            Controls.Add(txbEmail);
            Controls.Add(lblSelName);
            Controls.Add(dgvPeople);
            Controls.Add(txbFilter);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbFilter;
        private DataGridView dgvPeople;
        private Label lblSelName;
        private TextBox txbEmail;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
