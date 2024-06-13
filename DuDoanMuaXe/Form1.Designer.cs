
namespace DuDoanMuaXe
{
    partial class Form1
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
            this.buttonMoFile = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTuoi = new System.Windows.Forms.ComboBox();
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            this.labelK = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonNhapLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMoFile
            // 
            this.buttonMoFile.Location = new System.Drawing.Point(509, 43);
            this.buttonMoFile.Name = "buttonMoFile";
            this.buttonMoFile.Size = new System.Drawing.Size(75, 23);
            this.buttonMoFile.TabIndex = 0;
            this.buttonMoFile.Text = "Mở file .csv";
            this.buttonMoFile.UseVisualStyleBackColor = true;
            this.buttonMoFile.Click += new System.EventHandler(this.buttonMoFile_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(287, 168);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Chạy";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(43, 43);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(444, 23);
            this.textBoxDiaChi.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(541, 198);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(104, 95);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(97, 23);
            this.textBoxID.TabIndex = 5;
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(104, 125);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(77, 23);
            this.comboBoxGioiTinh.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tuổi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lương năm:";
            // 
            // comboBoxTuoi
            // 
            this.comboBoxTuoi.FormattingEnabled = true;
            this.comboBoxTuoi.Location = new System.Drawing.Point(326, 97);
            this.comboBoxTuoi.Name = "comboBoxTuoi";
            this.comboBoxTuoi.Size = new System.Drawing.Size(77, 23);
            this.comboBoxTuoi.TabIndex = 10;
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Location = new System.Drawing.Point(326, 126);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(136, 23);
            this.textBoxLuong.TabIndex = 11;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelK.ForeColor = System.Drawing.Color.Red;
            this.labelK.Location = new System.Drawing.Point(519, 112);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(45, 20);
            this.labelK.TabIndex = 12;
            this.labelK.Text = "k = 0";
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKetQua.ForeColor = System.Drawing.Color.Red;
            this.labelKetQua.Location = new System.Drawing.Point(425, 168);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(72, 21);
            this.labelKetQua.TabIndex = 13;
            this.labelKetQua.Text = "Kết quả:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(639, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(463, 379);
            this.dataGridView2.TabIndex = 14;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(43, 168);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 15;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonNhapLai
            // 
            this.buttonNhapLai.Location = new System.Drawing.Point(165, 168);
            this.buttonNhapLai.Name = "buttonNhapLai";
            this.buttonNhapLai.Size = new System.Drawing.Size(75, 23);
            this.buttonNhapLai.TabIndex = 16;
            this.buttonNhapLai.Text = "Nhập lại";
            this.buttonNhapLai.UseVisualStyleBackColor = true;
            this.buttonNhapLai.Click += new System.EventHandler(this.buttonNhapLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 435);
            this.Controls.Add(this.buttonNhapLai);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.textBoxLuong);
            this.Controls.Add(this.comboBoxTuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonMoFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMoFile;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTuoi;
        private System.Windows.Forms.TextBox textBoxLuong;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonNhapLai;
    }
}

