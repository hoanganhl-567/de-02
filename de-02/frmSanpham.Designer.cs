namespace de_02
{
    partial class frmSanpham
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvSanpham = new System.Windows.Forms.DataGridView();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cboLoaisp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnkluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Sản Phẩm";
            // 
            // lvSanpham
            // 
            this.lvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvSanpham.Location = new System.Drawing.Point(12, 125);
            this.lvSanpham.Name = "lvSanpham";
            this.lvSanpham.RowHeadersWidth = 51;
            this.lvSanpham.RowTemplate.Height = 24;
            this.lvSanpham.Size = new System.Drawing.Size(473, 229);
            this.lvSanpham.TabIndex = 1;
            this.lvSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvSanpham_CellClick);
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(667, 135);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(171, 22);
            this.txtMasp.TabIndex = 2;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(667, 199);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(171, 22);
            this.txtTensp.TabIndex = 2;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.Location = new System.Drawing.Point(667, 267);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(200, 22);
            this.dtNgaynhap.TabIndex = 3;
            this.dtNgaynhap.Value = new System.DateTime(2024, 12, 30, 0, 0, 0, 0);
            // 
            // cboLoaisp
            // 
            this.cboLoaisp.FormattingEnabled = true;
            this.cboLoaisp.Location = new System.Drawing.Point(667, 330);
            this.cboLoaisp.Name = "cboLoaisp";
            this.cboLoaisp.Size = new System.Drawing.Size(171, 24);
            this.cboLoaisp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại SP";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(100, 393);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(314, 393);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(204, 393);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(435, 393);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnkluu
            // 
            this.btnkluu.Location = new System.Drawing.Point(555, 393);
            this.btnkluu.Name = "btnkluu";
            this.btnkluu.Size = new System.Drawing.Size(75, 23);
            this.btnkluu.TabIndex = 6;
            this.btnkluu.Text = "klưu";
            this.btnkluu.UseVisualStyleBackColor = true;
            this.btnkluu.Click += new System.EventHandler(this.btnkluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(679, 393);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(51, 84);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(164, 22);
            this.txtTim.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTim.Location = new System.Drawing.Point(230, 73);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 33);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkluu);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLoaisp);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.txtMasp);
            this.Controls.Add(this.lvSanpham);
            this.Controls.Add(this.label1);
            this.Name = "frmSanpham";
            this.Text = "Quan li san pham";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lvSanpham;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.ComboBox cboLoaisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnkluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
    }
}