namespace ShopManager
{
    partial class frmPopupClinic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dvClinic = new System.Windows.Forms.DataGridView();
            this.txtSelectPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dvProduct = new System.Windows.Forms.DataGridView();
            this.colSelectYn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CLINIC_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLINIC_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectYn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(298, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(217, 357);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dvClinic
            // 
            this.dvClinic.AllowUserToAddRows = false;
            this.dvClinic.AllowUserToDeleteRows = false;
            this.dvClinic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvClinic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectYn,
            this.CLINIC_NAME,
            this.CLINIC_PRICE});
            this.dvClinic.Location = new System.Drawing.Point(10, 10);
            this.dvClinic.MultiSelect = false;
            this.dvClinic.Name = "dvClinic";
            this.dvClinic.RowHeadersVisible = false;
            this.dvClinic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvClinic.RowTemplate.Height = 23;
            this.dvClinic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvClinic.Size = new System.Drawing.Size(282, 283);
            this.dvClinic.TabIndex = 15;
            this.dvClinic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvClinic_CellContentClick);
            // 
            // txtSelectPrice
            // 
            this.txtSelectPrice.Location = new System.Drawing.Point(480, 312);
            this.txtSelectPrice.Name = "txtSelectPrice";
            this.txtSelectPrice.ReadOnly = true;
            this.txtSelectPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSelectPrice.Size = new System.Drawing.Size(100, 21);
            this.txtSelectPrice.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "총선택금액";
            // 
            // dvProduct
            // 
            this.dvProduct.AllowUserToAddRows = false;
            this.dvProduct.AllowUserToDeleteRows = false;
            this.dvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectYn2,
            this.PRODUCT_NAME,
            this.PRODUCT_PRICE});
            this.dvProduct.Location = new System.Drawing.Point(298, 10);
            this.dvProduct.MultiSelect = false;
            this.dvProduct.Name = "dvProduct";
            this.dvProduct.RowHeadersVisible = false;
            this.dvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvProduct.RowTemplate.Height = 23;
            this.dvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvProduct.Size = new System.Drawing.Size(282, 283);
            this.dvProduct.TabIndex = 21;
            this.dvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvProduct_CellContentClick);
            // 
            // colSelectYn
            // 
            this.colSelectYn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSelectYn.HeaderText = "선택";
            this.colSelectYn.Name = "colSelectYn";
            this.colSelectYn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelectYn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelectYn.Width = 54;
            // 
            // CLINIC_NAME
            // 
            this.CLINIC_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLINIC_NAME.DataPropertyName = "CLINIC_NAME";
            this.CLINIC_NAME.HeaderText = "클리닉명";
            this.CLINIC_NAME.Name = "CLINIC_NAME";
            // 
            // CLINIC_PRICE
            // 
            this.CLINIC_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CLINIC_PRICE.DataPropertyName = "PRICE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.CLINIC_PRICE.DefaultCellStyle = dataGridViewCellStyle1;
            this.CLINIC_PRICE.HeaderText = "가격";
            this.CLINIC_PRICE.Name = "CLINIC_PRICE";
            this.CLINIC_PRICE.Width = 54;
            // 
            // colSelectYn2
            // 
            this.colSelectYn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSelectYn2.HeaderText = "선택";
            this.colSelectYn2.Name = "colSelectYn2";
            this.colSelectYn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelectYn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelectYn2.Width = 54;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "상품명";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            // 
            // PRODUCT_PRICE
            // 
            this.PRODUCT_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRODUCT_PRICE.DataPropertyName = "PRICE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.PRODUCT_PRICE.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRODUCT_PRICE.HeaderText = "가격";
            this.PRODUCT_PRICE.Name = "PRODUCT_PRICE";
            this.PRODUCT_PRICE.Width = 54;
            // 
            // frmPopupClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 401);
            this.Controls.Add(this.dvProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dvClinic);
            this.Controls.Add(this.txtSelectPrice);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPopupClinic";
            this.Text = "클리닉/상품 선택";
            this.Load += new System.EventHandler(this.frmPopupClinic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView dvClinic;
        public System.Windows.Forms.DataGridView dvProduct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectYn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLINIC_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLINIC_PRICE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectYn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_PRICE;
    }
}