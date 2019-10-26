namespace StockManagementSystem.UI
{
    partial class SalesReportUiController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportUiController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.purchaseReportDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salesStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endDateErrorLabel = new System.Windows.Forms.Label();
            this.startDateErrorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.purchaseReportDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 509);
            this.panel1.TabIndex = 45;
            // 
            // purchaseReportDataGridView
            // 
            this.purchaseReportDataGridView.AllowUserToAddRows = false;
            this.purchaseReportDataGridView.AllowUserToResizeRows = false;
            this.purchaseReportDataGridView.AutoGenerateColumns = false;
            this.purchaseReportDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purchaseReportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.purchaseReportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.purchaseReportDataGridView.ColumnHeadersHeight = 30;
            this.purchaseReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchaseReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.soldQtyDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.purchaseReportDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseReportDataGridView.DataSource = this.salesReportViewModelBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseReportDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.purchaseReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseReportDataGridView.EnableHeadersVisualStyles = false;
            this.purchaseReportDataGridView.GridColor = System.Drawing.Color.White;
            this.purchaseReportDataGridView.Location = new System.Drawing.Point(0, 0);
            this.purchaseReportDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.purchaseReportDataGridView.Name = "purchaseReportDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseReportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.purchaseReportDataGridView.RowHeadersVisible = false;
            this.purchaseReportDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.purchaseReportDataGridView.RowTemplate.Height = 24;
            this.purchaseReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseReportDataGridView.Size = new System.Drawing.Size(1120, 509);
            this.purchaseReportDataGridView.TabIndex = 21;
            this.purchaseReportDataGridView.TabStop = false;
            // 
            // Sl
            // 
            this.Sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sl.HeaderText = "#";
            this.Sl.Name = "Sl";
            this.Sl.Width = 43;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // soldQtyDataGridViewTextBoxColumn
            // 
            this.soldQtyDataGridViewTextBoxColumn.DataPropertyName = "SoldQty";
            this.soldQtyDataGridViewTextBoxColumn.HeaderText = "SoldQty";
            this.soldQtyDataGridViewTextBoxColumn.Name = "soldQtyDataGridViewTextBoxColumn";
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // salesReportViewModelBindingSource
            // 
            this.salesReportViewModelBindingSource.DataSource = typeof(StockManagementSystem.Model.SalesReportViewModel);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(815, 21);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 24);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "     Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Start Date";
            // 
            // purchaseEndDateTimePicker
            // 
            this.purchaseEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.purchaseEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseEndDateTimePicker.Location = new System.Drawing.Point(614, 21);
            this.purchaseEndDateTimePicker.Name = "purchaseEndDateTimePicker";
            this.purchaseEndDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.purchaseEndDateTimePicker.TabIndex = 46;
            // 
            // salesStartDateTimePicker
            // 
            this.salesStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.salesStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salesStartDateTimePicker.Location = new System.Drawing.Point(311, 21);
            this.salesStartDateTimePicker.Name = "salesStartDateTimePicker";
            this.salesStartDateTimePicker.Size = new System.Drawing.Size(168, 22);
            this.salesStartDateTimePicker.TabIndex = 47;
            this.salesStartDateTimePicker.ValueChanged += new System.EventHandler(this.salesStartDateTimePicker_ValueChanged);
            // 
            // purchaseReportViewModelBindingSource
            // 
            this.purchaseReportViewModelBindingSource.DataSource = typeof(StockManagementSystem.Model.PurchaseReportViewModel);
            // 
            // endDateErrorLabel
            // 
            this.endDateErrorLabel.AutoSize = true;
            this.endDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.endDateErrorLabel.Location = new System.Drawing.Point(611, 46);
            this.endDateErrorLabel.Name = "endDateErrorLabel";
            this.endDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.endDateErrorLabel.TabIndex = 48;
            this.endDateErrorLabel.Text = "Error Message";
            // 
            // startDateErrorLabel
            // 
            this.startDateErrorLabel.AutoSize = true;
            this.startDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.startDateErrorLabel.Location = new System.Drawing.Point(311, 46);
            this.startDateErrorLabel.Name = "startDateErrorLabel";
            this.startDateErrorLabel.Size = new System.Drawing.Size(101, 17);
            this.startDateErrorLabel.TabIndex = 49;
            this.startDateErrorLabel.Text = "Error Message";
            // 
            // SalesReportUiController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDateErrorLabel);
            this.Controls.Add(this.startDateErrorLabel);
            this.Controls.Add(this.purchaseEndDateTimePicker);
            this.Controls.Add(this.salesStartDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "SalesReportUiController";
            this.Size = new System.Drawing.Size(1126, 612);
            this.Load += new System.EventHandler(this.SalesReportUiController_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView purchaseReportDataGridView;
        private System.Windows.Forms.BindingSource purchaseReportViewModelBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker purchaseEndDateTimePicker;
        public System.Windows.Forms.DateTimePicker salesStartDateTimePicker;
        private System.Windows.Forms.BindingSource salesReportViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label endDateErrorLabel;
        private System.Windows.Forms.Label startDateErrorLabel;
    }
}
