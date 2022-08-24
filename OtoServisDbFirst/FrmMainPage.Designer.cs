namespace OtoServisDbFirst
{
    partial class FrmMainPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdminInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskBringDate = new System.Windows.Forms.MaskedTextBox();
            this.mskDeliveryDate = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 565);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1496, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHistory);
            this.groupBox1.Controls.Add(this.lblAdminInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 945);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblAdminInfo
            // 
            this.lblAdminInfo.AutoSize = true;
            this.lblAdminInfo.Location = new System.Drawing.Point(20, 64);
            this.lblAdminInfo.Name = "lblAdminInfo";
            this.lblAdminInfo.Size = new System.Drawing.Size(60, 24);
            this.lblAdminInfo.TabIndex = 2;
            this.lblAdminInfo.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Yapan:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(8, 857);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 82);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(716, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 68);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(716, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 68);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(716, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 68);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(416, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(268, 29);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(416, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 29);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(416, 98);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(268, 29);
            this.txtSurname.TabIndex = 7;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(690, 59);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(141, 33);
            this.btnSearchByName.TabIndex = 10;
            this.btnSearchByName.Text = "ada göre ara";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Aracı Getiriş Tarihi:";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(416, 133);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(268, 29);
            this.mskPhone.TabIndex = 16;
            this.mskPhone.Text = "2122221111";
            // 
            // mskBringDate
            // 
            this.mskBringDate.Location = new System.Drawing.Point(416, 170);
            this.mskBringDate.Mask = "00/00/0000";
            this.mskBringDate.Name = "mskBringDate";
            this.mskBringDate.Size = new System.Drawing.Size(268, 29);
            this.mskBringDate.TabIndex = 18;
            this.mskBringDate.Text = "22022022";
            this.mskBringDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskDeliveryDate
            // 
            this.mskDeliveryDate.Location = new System.Drawing.Point(416, 205);
            this.mskDeliveryDate.Mask = "00/00/0000";
            this.mskDeliveryDate.Name = "mskDeliveryDate";
            this.mskDeliveryDate.Size = new System.Drawing.Size(268, 29);
            this.mskDeliveryDate.TabIndex = 19;
            this.mskDeliveryDate.Text = "24022022";
            this.mskDeliveryDate.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aracı Teslim Tarihi:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(416, 240);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(268, 165);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "Disk balata değişimi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Müşteri Talebi:";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(416, 411);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(268, 32);
            this.cmbBrand.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Araç Markası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "İlgilenecek Usta:";
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(416, 449);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(268, 32);
            this.cmbMechanic.TabIndex = 27;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Enabled = false;
            this.txtAdmin.Location = new System.Drawing.Point(416, 487);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(268, 29);
            this.txtAdmin.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Kaydeden Admin:";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(416, 522);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(268, 29);
            this.txtPlate.TabIndex = 30;
            this.txtPlate.Text = "34 KY 2567";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 527);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "Plaka:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(716, 138);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(174, 68);
            this.btnList.TabIndex = 32;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(8, 126);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(187, 68);
            this.btnHistory.TabIndex = 33;
            this.btnHistory.Text = "Müşteri geçmişi sorgula";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 969);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.cmbMechanic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskDeliveryDate);
            this.Controls.Add(this.mskBringDate);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMainPage";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdminInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.MaskedTextBox mskBringDate;
        private System.Windows.Forms.MaskedTextBox mskDeliveryDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHistory;
    }
}