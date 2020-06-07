namespace VideoGamesProject
{
    partial class frmModifyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSwitch = new System.Windows.Forms.RadioButton();
            this.rdoModify = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbSwitch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpModify = new System.Windows.Forms.GroupBox();
            this.txtMTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMTotal = new System.Windows.Forms.TextBox();
            this.txtMSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSwitch = new System.Windows.Forms.GroupBox();
            this.txtSTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSTotal = new System.Windows.Forms.TextBox();
            this.txtSSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.grpModify.SuspendLayout();
            this.grpSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Orders";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtOrderId.Location = new System.Drawing.Point(188, 39);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(185, 26);
            this.txtOrderId.TabIndex = 2;
            this.txtOrderId.Text = "Search by ID";
            this.txtOrderId.Enter += new System.EventHandler(this.txtOrderId_Enter);
            this.txtOrderId.Leave += new System.EventHandler(this.txtOrderId_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvOrderDetails);
            this.groupBox1.Controls.Add(this.dgvOrderList);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 720);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(416, 79);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 34);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            this.btnReload.MouseLeave += new System.EventHandler(this.btnReload_MouseLeave);
            this.btnReload.MouseHover += new System.EventHandler(this.btnReload_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoSwitch);
            this.groupBox2.Controls.Add(this.rdoModify);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(538, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // rdoSwitch
            // 
            this.rdoSwitch.AutoSize = true;
            this.rdoSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSwitch.Location = new System.Drawing.Point(38, 46);
            this.rdoSwitch.Name = "rdoSwitch";
            this.rdoSwitch.Size = new System.Drawing.Size(139, 24);
            this.rdoSwitch.TabIndex = 4;
            this.rdoSwitch.TabStop = true;
            this.rdoSwitch.Text = "Switch Games";
            this.rdoSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSwitch.UseVisualStyleBackColor = true;
            this.rdoSwitch.CheckedChanged += new System.EventHandler(this.rdoSwitch_CheckedChanged);
            // 
            // rdoModify
            // 
            this.rdoModify.AutoSize = true;
            this.rdoModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModify.Location = new System.Drawing.Point(38, 87);
            this.rdoModify.Name = "rdoModify";
            this.rdoModify.Size = new System.Drawing.Size(136, 24);
            this.rdoModify.TabIndex = 3;
            this.rdoModify.TabStop = true;
            this.rdoModify.Text = "Modify Orders";
            this.rdoModify.UseVisualStyleBackColor = true;
            this.rdoModify.CheckedChanged += new System.EventHandler(this.rdoModify_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Order";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(7, 491);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(784, 206);
            this.dgvOrderDetails.TabIndex = 4;
            this.dgvOrderDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderDetails_RowHeaderMouseClick);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(7, 176);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.Size = new System.Drawing.Size(784, 286);
            this.dgvOrderList.TabIndex = 3;
            this.dgvOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(416, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(223, 44);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(182, 26);
            this.txtQty.TabIndex = 4;
            // 
            // cmbSwitch
            // 
            this.cmbSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSwitch.FormattingEnabled = true;
            this.cmbSwitch.Location = new System.Drawing.Point(104, 71);
            this.cmbSwitch.Name = "cmbSwitch";
            this.cmbSwitch.Size = new System.Drawing.Size(321, 28);
            this.cmbSwitch.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select switch game(s)";
            // 
            // grpModify
            // 
            this.grpModify.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpModify.Controls.Add(this.txtMTax);
            this.grpModify.Controls.Add(this.label8);
            this.grpModify.Controls.Add(this.txtMTotal);
            this.grpModify.Controls.Add(this.txtMSubtotal);
            this.grpModify.Controls.Add(this.label6);
            this.grpModify.Controls.Add(this.label5);
            this.grpModify.Controls.Add(this.txtQty);
            this.grpModify.Controls.Add(this.label3);
            this.grpModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModify.Location = new System.Drawing.Point(856, 377);
            this.grpModify.Name = "grpModify";
            this.grpModify.Size = new System.Drawing.Size(532, 219);
            this.grpModify.TabIndex = 7;
            this.grpModify.TabStop = false;
            this.grpModify.Text = "Modify Orders";
            // 
            // txtMTax
            // 
            this.txtMTax.Location = new System.Drawing.Point(223, 107);
            this.txtMTax.Name = "txtMTax";
            this.txtMTax.ReadOnly = true;
            this.txtMTax.Size = new System.Drawing.Size(182, 26);
            this.txtMTax.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(162, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total";
            // 
            // txtMTotal
            // 
            this.txtMTotal.Location = new System.Drawing.Point(223, 144);
            this.txtMTotal.Name = "txtMTotal";
            this.txtMTotal.ReadOnly = true;
            this.txtMTotal.Size = new System.Drawing.Size(182, 26);
            this.txtMTotal.TabIndex = 9;
            // 
            // txtMSubtotal
            // 
            this.txtMSubtotal.Location = new System.Drawing.Point(223, 76);
            this.txtMSubtotal.Name = "txtMSubtotal";
            this.txtMSubtotal.ReadOnly = true;
            this.txtMSubtotal.Size = new System.Drawing.Size(182, 26);
            this.txtMSubtotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Subtotal";
            // 
            // grpSwitch
            // 
            this.grpSwitch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpSwitch.Controls.Add(this.txtSTax);
            this.grpSwitch.Controls.Add(this.label7);
            this.grpSwitch.Controls.Add(this.txtSTotal);
            this.grpSwitch.Controls.Add(this.txtSSubtotal);
            this.grpSwitch.Controls.Add(this.label9);
            this.grpSwitch.Controls.Add(this.label10);
            this.grpSwitch.Controls.Add(this.cmbSwitch);
            this.grpSwitch.Controls.Add(this.label4);
            this.grpSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSwitch.Location = new System.Drawing.Point(856, 52);
            this.grpSwitch.Name = "grpSwitch";
            this.grpSwitch.Size = new System.Drawing.Size(532, 272);
            this.grpSwitch.TabIndex = 8;
            this.grpSwitch.TabStop = false;
            this.grpSwitch.Text = "Switch Games";
            // 
            // txtSTax
            // 
            this.txtSTax.Location = new System.Drawing.Point(223, 159);
            this.txtSTax.Name = "txtSTax";
            this.txtSTax.ReadOnly = true;
            this.txtSTax.Size = new System.Drawing.Size(182, 26);
            this.txtSTax.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // txtSTotal
            // 
            this.txtSTotal.Location = new System.Drawing.Point(223, 196);
            this.txtSTotal.Name = "txtSTotal";
            this.txtSTotal.ReadOnly = true;
            this.txtSTotal.Size = new System.Drawing.Size(182, 26);
            this.txtSTotal.TabIndex = 16;
            // 
            // txtSSubtotal
            // 
            this.txtSSubtotal.Location = new System.Drawing.Point(223, 128);
            this.txtSSubtotal.Name = "txtSSubtotal";
            this.txtSSubtotal.ReadOnly = true;
            this.txtSSubtotal.Size = new System.Drawing.Size(182, 26);
            this.txtSSubtotal.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tax";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Subtotal";
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(974, 637);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(82, 39);
            this.btnSwitch.TabIndex = 9;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(1053, 637);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(102, 39);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1151, 637);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 39);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1230, 637);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmModifyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 772);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.grpModify);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSwitch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModifyOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Modify";
            this.Text = "Modify Orders";
            this.Load += new System.EventHandler(this.frmModifyOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.grpModify.ResumeLayout(false);
            this.grpModify.PerformLayout();
            this.grpSwitch.ResumeLayout(false);
            this.grpSwitch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoModify;
        private System.Windows.Forms.RadioButton rdoSwitch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbSwitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpModify;
        private System.Windows.Forms.TextBox txtMTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMTotal;
        private System.Windows.Forms.TextBox txtMSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpSwitch;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSTotal;
        private System.Windows.Forms.TextBox txtSSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReload;
    }
}