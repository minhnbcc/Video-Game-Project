namespace VideoGamesProject
{
    partial class frmGamesMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGamesMaintenance));
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpGameDetails = new System.Windows.Forms.GroupBox();
            this.rdoPending = new System.Windows.Forms.RadioButton();
            this.rdoAllAges = new System.Windows.Forms.RadioButton();
            this.rdo13 = new System.Windows.Forms.RadioButton();
            this.rdo17 = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.rdo18 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdo10 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPulishedYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.grpGameDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(119, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(207, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 26);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.LightGray;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(569, 76);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(345, 203);
            this.txtDesc.TabIndex = 12;
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(578, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(87, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // grpGameDetails
            // 
            this.grpGameDetails.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpGameDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpGameDetails.Controls.Add(this.rdoPending);
            this.grpGameDetails.Controls.Add(this.rdoAllAges);
            this.grpGameDetails.Controls.Add(this.rdo13);
            this.grpGameDetails.Controls.Add(this.rdo17);
            this.grpGameDetails.Controls.Add(this.txtId);
            this.grpGameDetails.Controls.Add(this.rdo18);
            this.grpGameDetails.Controls.Add(this.pictureBox1);
            this.grpGameDetails.Controls.Add(this.rdo10);
            this.grpGameDetails.Controls.Add(this.btnAdd);
            this.grpGameDetails.Controls.Add(this.btnSave);
            this.grpGameDetails.Controls.Add(this.label6);
            this.grpGameDetails.Controls.Add(this.label1);
            this.grpGameDetails.Controls.Add(this.btnCancel);
            this.grpGameDetails.Controls.Add(this.btnPrevious);
            this.grpGameDetails.Controls.Add(this.btnLast);
            this.grpGameDetails.Controls.Add(this.btnFirst);
            this.grpGameDetails.Controls.Add(this.btnNext);
            this.grpGameDetails.Controls.Add(this.cmbGenre);
            this.grpGameDetails.Controls.Add(this.btnDelete);
            this.grpGameDetails.Controls.Add(this.label9);
            this.grpGameDetails.Controls.Add(this.txtManufacturer);
            this.grpGameDetails.Controls.Add(this.label8);
            this.grpGameDetails.Controls.Add(this.txtPulishedYear);
            this.grpGameDetails.Controls.Add(this.label7);
            this.grpGameDetails.Controls.Add(this.txtPrice);
            this.grpGameDetails.Controls.Add(this.label2);
            this.grpGameDetails.Controls.Add(this.label4);
            this.grpGameDetails.Controls.Add(this.label3);
            this.grpGameDetails.Controls.Add(this.txtDesc);
            this.grpGameDetails.Controls.Add(this.txtName);
            this.grpGameDetails.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGameDetails.ForeColor = System.Drawing.Color.DarkCyan;
            this.errProvider.SetIconAlignment(this.grpGameDetails, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.grpGameDetails.Location = new System.Drawing.Point(165, 99);
            this.grpGameDetails.Name = "grpGameDetails";
            this.grpGameDetails.Size = new System.Drawing.Size(955, 534);
            this.grpGameDetails.TabIndex = 7;
            this.grpGameDetails.TabStop = false;
            // 
            // rdoPending
            // 
            this.rdoPending.AutoSize = true;
            this.rdoPending.BackColor = System.Drawing.SystemColors.Highlight;
            this.rdoPending.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPending.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdoPending.Location = new System.Drawing.Point(284, 327);
            this.rdoPending.Name = "rdoPending";
            this.rdoPending.Size = new System.Drawing.Size(149, 24);
            this.rdoPending.TabIndex = 37;
            this.rdoPending.TabStop = true;
            this.rdoPending.Tag = "pending";
            this.rdoPending.Text = "rating pending";
            this.rdoPending.UseVisualStyleBackColor = false;
            // 
            // rdoAllAges
            // 
            this.rdoAllAges.AutoSize = true;
            this.rdoAllAges.BackColor = System.Drawing.SystemColors.Highlight;
            this.rdoAllAges.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoAllAges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAllAges.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdoAllAges.Location = new System.Drawing.Point(284, 296);
            this.rdoAllAges.Name = "rdoAllAges";
            this.rdoAllAges.Size = new System.Drawing.Size(96, 24);
            this.rdoAllAges.TabIndex = 11;
            this.rdoAllAges.TabStop = true;
            this.rdoAllAges.Tag = "all ages";
            this.rdoAllAges.Text = "all ages";
            this.rdoAllAges.UseVisualStyleBackColor = false;
            // 
            // rdo13
            // 
            this.rdo13.AutoSize = true;
            this.rdo13.BackColor = System.Drawing.SystemColors.Highlight;
            this.rdo13.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdo13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo13.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdo13.Location = new System.Drawing.Point(207, 327);
            this.rdo13.Name = "rdo13";
            this.rdo13.Size = new System.Drawing.Size(61, 24);
            this.rdo13.TabIndex = 8;
            this.rdo13.TabStop = true;
            this.rdo13.Tag = "13+";
            this.rdo13.Text = "13+";
            this.rdo13.UseVisualStyleBackColor = false;
            // 
            // rdo17
            // 
            this.rdo17.AutoSize = true;
            this.rdo17.BackColor = System.Drawing.SystemColors.Highlight;
            this.rdo17.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdo17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo17.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdo17.Location = new System.Drawing.Point(207, 355);
            this.rdo17.Name = "rdo17";
            this.rdo17.Size = new System.Drawing.Size(61, 24);
            this.rdo17.TabIndex = 9;
            this.rdo17.TabStop = true;
            this.rdo17.Tag = "17+";
            this.rdo17.Text = "17+";
            this.rdo17.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(207, 34);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(253, 26);
            this.txtId.TabIndex = 36;
            // 
            // rdo18
            // 
            this.rdo18.AutoSize = true;
            this.rdo18.BackColor = System.Drawing.SystemColors.Highlight;
            this.rdo18.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdo18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo18.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdo18.Location = new System.Drawing.Point(207, 385);
            this.rdo18.Name = "rdo18";
            this.rdo18.Size = new System.Drawing.Size(61, 24);
            this.rdo18.TabIndex = 10;
            this.rdo18.TabStop = true;
            this.rdo18.Tag = "18+";
            this.rdo18.Text = "18+";
            this.rdo18.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(63, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 170);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // rdo10
            // 
            this.rdo10.AutoSize = true;
            this.rdo10.BackColor = System.Drawing.SystemColors.Highlight;
            this.rdo10.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdo10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo10.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rdo10.Location = new System.Drawing.Point(207, 297);
            this.rdo10.Name = "rdo10";
            this.rdo10.Size = new System.Drawing.Size(61, 24);
            this.rdo10.TabIndex = 7;
            this.rdo10.TabStop = true;
            this.rdo10.Tag = "10+";
            this.rdo10.Text = "10+";
            this.rdo10.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(420, 403);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 47);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(499, 403);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 47);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(113, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "ESRB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(154, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(851, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 47);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.Location = new System.Drawing.Point(689, 307);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(63, 35);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLast.Location = new System.Drawing.Point(807, 307);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(63, 35);
            this.btnLast.TabIndex = 16;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.Location = new System.Drawing.Point(629, 307);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(63, 35);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(749, 307);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 35);
            this.btnNext.TabIndex = 15;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // cmbGenre
            // 
            this.cmbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(207, 106);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(253, 28);
            this.cmbGenre.TabIndex = 3;
            this.cmbGenre.Tag = "Genre";
            this.cmbGenre.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGenre_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(794, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 47);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(48, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(207, 140);
            this.txtManufacturer.Multiline = true;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(253, 77);
            this.txtManufacturer.TabIndex = 4;
            this.txtManufacturer.Validating += new System.ComponentModel.CancelEventHandler(this.txtManufacturer_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(29, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Published Year";
            // 
            // txtPulishedYear
            // 
            this.txtPulishedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPulishedYear.Location = new System.Drawing.Point(207, 223);
            this.txtPulishedYear.Name = "txtPulishedYear";
            this.txtPulishedYear.Size = new System.Drawing.Size(253, 26);
            this.txtPulishedYear.TabIndex = 5;
            this.txtPulishedYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtPulishedYear_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(126, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(207, 255);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(253, 26);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.prgBar,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1247, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // prgBar
            // 
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(500, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "Game Details";
            // 
            // frmGamesMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::VideoGamesProject.Properties.Resources.game_bg;
            this.ClientSize = new System.Drawing.Size(1247, 724);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpGameDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGamesMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games Maintenance";
            this.Load += new System.EventHandler(this.frmGamesMaintenance_Load);
            this.grpGameDetails.ResumeLayout(false);
            this.grpGameDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpGameDetails;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPulishedYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar prgBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoAllAges;
        private System.Windows.Forms.RadioButton rdo13;
        private System.Windows.Forms.RadioButton rdo17;
        private System.Windows.Forms.RadioButton rdo18;
        private System.Windows.Forms.RadioButton rdo10;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton rdoPending;
        private System.Windows.Forms.Label label6;
    }
}