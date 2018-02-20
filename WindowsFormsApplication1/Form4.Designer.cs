namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookCheckoutDataSet = new WindowsFormsApplication1.bookCheckoutDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkoutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookCheckoutDataSet1 = new WindowsFormsApplication1.bookCheckoutDataSet();
            this.bookTableAdapter = new WindowsFormsApplication1.bookCheckoutDataSetTableAdapters.bookTableAdapter();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new WindowsFormsApplication1.bookCheckoutDataSetTableAdapters.TableAdapterManager();
            this.checkoutTableAdapter1 = new WindowsFormsApplication1.bookCheckoutDataSetTableAdapters.checkoutTableAdapter();
            this.userTableAdapter1 = new WindowsFormsApplication1.bookCheckoutDataSetTableAdapters.userTableAdapter();
            this.btn_showCheckedOut = new System.Windows.Forms.Button();
            this.btn_showAllBooks = new System.Windows.Forms.Button();
            this.btn_showFines = new System.Windows.Forms.Button();
            this.txt_UID = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCheckoutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCheckoutDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.bookCheckoutDataSet;
            // 
            // bookCheckoutDataSet
            // 
            this.bookCheckoutDataSet.DataSetName = "bookCheckoutDataSet";
            this.bookCheckoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 481);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkoutBindingSource
            // 
            this.checkoutBindingSource.DataMember = "checkout";
            this.checkoutBindingSource.DataSource = this.bookCheckoutDataSet;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.bookCheckoutDataSet;
            // 
            // checkoutBindingSource1
            // 
            this.checkoutBindingSource1.DataMember = "checkout";
            this.checkoutBindingSource1.DataSource = this.bookCheckoutDataSet1;
            // 
            // bookCheckoutDataSet1
            // 
            this.bookCheckoutDataSet1.DataSetName = "bookCheckoutDataSet";
            this.bookCheckoutDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "book";
            this.bookBindingSource1.DataSource = this.bookCheckoutDataSet;
            // 
            // bookBindingSource2
            // 
            this.bookBindingSource2.DataMember = "book";
            this.bookBindingSource2.DataSource = this.bookCheckoutDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.checkoutTableAdapter = null;
            this.tableAdapterManager.classTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.teachesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.bookCheckoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // checkoutTableAdapter1
            // 
            this.checkoutTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_showCheckedOut
            // 
            this.btn_showCheckedOut.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_showCheckedOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showCheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showCheckedOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showCheckedOut.Location = new System.Drawing.Point(116, 105);
            this.btn_showCheckedOut.Name = "btn_showCheckedOut";
            this.btn_showCheckedOut.Size = new System.Drawing.Size(234, 30);
            this.btn_showCheckedOut.TabIndex = 36;
            this.btn_showCheckedOut.Text = "Show Checked Out Books";
            this.btn_showCheckedOut.UseVisualStyleBackColor = false;
            this.btn_showCheckedOut.Click += new System.EventHandler(this.btn_showCheckedOut_Click);
            // 
            // btn_showAllBooks
            // 
            this.btn_showAllBooks.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_showAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAllBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showAllBooks.Location = new System.Drawing.Point(116, 151);
            this.btn_showAllBooks.Name = "btn_showAllBooks";
            this.btn_showAllBooks.Size = new System.Drawing.Size(234, 30);
            this.btn_showAllBooks.TabIndex = 37;
            this.btn_showAllBooks.Text = "Show All Books";
            this.btn_showAllBooks.UseVisualStyleBackColor = false;
            this.btn_showAllBooks.Click += new System.EventHandler(this.btn_showAllBooks_Click);
            // 
            // btn_showFines
            // 
            this.btn_showFines.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_showFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showFines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showFines.Location = new System.Drawing.Point(116, 197);
            this.btn_showFines.Name = "btn_showFines";
            this.btn_showFines.Size = new System.Drawing.Size(234, 30);
            this.btn_showFines.TabIndex = 38;
            this.btn_showFines.Text = "Show Fines";
            this.btn_showFines.UseVisualStyleBackColor = false;
            this.btn_showFines.Click += new System.EventHandler(this.btn_showFines_Click);
            // 
            // txt_UID
            // 
            this.txt_UID.Location = new System.Drawing.Point(174, 488);
            this.txt_UID.Name = "txt_UID";
            this.txt_UID.Size = new System.Drawing.Size(100, 20);
            this.txt_UID.TabIndex = 39;
            this.txt_UID.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(116, 241);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(234, 30);
            this.btn_exit.TabIndex = 40;
            this.btn_exit.Text = "Quit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 560);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_UID);
            this.Controls.Add(this.btn_showFines);
            this.Controls.Add(this.btn_showAllBooks);
            this.Controls.Add(this.btn_showCheckedOut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Student Book Database";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCheckoutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCheckoutDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private bookCheckoutDataSet bookCheckoutDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private bookCheckoutDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource2;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private bookCheckoutDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bookCheckoutDataSetTableAdapters.checkoutTableAdapter checkoutTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource checkoutBindingSource;
        private bookCheckoutDataSet bookCheckoutDataSet1;
        private System.Windows.Forms.BindingSource checkoutBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private bookCheckoutDataSetTableAdapters.userTableAdapter userTableAdapter1;
        private System.Windows.Forms.Button btn_showCheckedOut;
        private System.Windows.Forms.Button btn_showAllBooks;
        private System.Windows.Forms.Button btn_showFines;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.TextBox txt_UID;
    }
}

