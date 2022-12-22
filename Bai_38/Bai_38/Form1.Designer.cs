namespace Bai_38
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMangGoc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnXuatMangNgauNhien = new System.Windows.Forms.Button();
            this.btnTimPhanTuNhoNhat = new System.Windows.Forms.Button();
            this.btnTinhTongGiaTriMang = new System.Windows.Forms.Button();
            this.btnTangMoiPhanTuLen2 = new System.Windows.Forms.Button();
            this.btnTongGiaTriPhanTuLe = new System.Windows.Forms.Button();
            this.btnSapMangGiam = new System.Windows.Forms.Button();
            this.btnDemSoPhanTuLe = new System.Windows.Forms.Button();
            this.btnSapMangTang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMangGoc);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng gốc:";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMangGoc.Location = new System.Drawing.Point(3, 16);
            this.txtMangGoc.Multiline = true;
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(358, 27);
            this.txtMangGoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Location = new System.Drawing.Point(2, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKetQua.Location = new System.Drawing.Point(3, 16);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(355, 27);
            this.txtKetQua.TabIndex = 0;
            // 
            // btnXuatMangNgauNhien
            // 
            this.btnXuatMangNgauNhien.Location = new System.Drawing.Point(2, 130);
            this.btnXuatMangNgauNhien.Name = "btnXuatMangNgauNhien";
            this.btnXuatMangNgauNhien.Size = new System.Drawing.Size(175, 23);
            this.btnXuatMangNgauNhien.TabIndex = 2;
            this.btnXuatMangNgauNhien.Text = "Xuất mảng ngẫu nhiên";
            this.btnXuatMangNgauNhien.UseVisualStyleBackColor = true;
            this.btnXuatMangNgauNhien.Click += new System.EventHandler(this.btnXuatMangNgauNhien_Click);
            // 
            // btnTimPhanTuNhoNhat
            // 
            this.btnTimPhanTuNhoNhat.Location = new System.Drawing.Point(188, 130);
            this.btnTimPhanTuNhoNhat.Name = "btnTimPhanTuNhoNhat";
            this.btnTimPhanTuNhoNhat.Size = new System.Drawing.Size(175, 23);
            this.btnTimPhanTuNhoNhat.TabIndex = 6;
            this.btnTimPhanTuNhoNhat.Text = "Tìm phần tử nhỏ nhất";
            this.btnTimPhanTuNhoNhat.UseVisualStyleBackColor = true;
            this.btnTimPhanTuNhoNhat.Click += new System.EventHandler(this.btnTimPhanTuNhoNhat_Click);
            // 
            // btnTinhTongGiaTriMang
            // 
            this.btnTinhTongGiaTriMang.Location = new System.Drawing.Point(2, 168);
            this.btnTinhTongGiaTriMang.Name = "btnTinhTongGiaTriMang";
            this.btnTinhTongGiaTriMang.Size = new System.Drawing.Size(175, 23);
            this.btnTinhTongGiaTriMang.TabIndex = 3;
            this.btnTinhTongGiaTriMang.Text = "Tính tổng giá trị mảng";
            this.btnTinhTongGiaTriMang.UseVisualStyleBackColor = true;
            this.btnTinhTongGiaTriMang.Click += new System.EventHandler(this.btnTinhTongGiaTriMang_Click);
            // 
            // btnTangMoiPhanTuLen2
            // 
            this.btnTangMoiPhanTuLen2.Location = new System.Drawing.Point(188, 168);
            this.btnTangMoiPhanTuLen2.Name = "btnTangMoiPhanTuLen2";
            this.btnTangMoiPhanTuLen2.Size = new System.Drawing.Size(175, 23);
            this.btnTangMoiPhanTuLen2.TabIndex = 7;
            this.btnTangMoiPhanTuLen2.Text = "Tăng mỗi phần tử mảng lên 2";
            this.btnTangMoiPhanTuLen2.UseVisualStyleBackColor = true;
            this.btnTangMoiPhanTuLen2.Click += new System.EventHandler(this.btnTangMoiPhanTuLen2_Click);
            // 
            // btnTongGiaTriPhanTuLe
            // 
            this.btnTongGiaTriPhanTuLe.Location = new System.Drawing.Point(2, 247);
            this.btnTongGiaTriPhanTuLe.Name = "btnTongGiaTriPhanTuLe";
            this.btnTongGiaTriPhanTuLe.Size = new System.Drawing.Size(175, 23);
            this.btnTongGiaTriPhanTuLe.TabIndex = 5;
            this.btnTongGiaTriPhanTuLe.Text = "Tổng giá trị phần tử lẻ";
            this.btnTongGiaTriPhanTuLe.UseVisualStyleBackColor = true;
            this.btnTongGiaTriPhanTuLe.Click += new System.EventHandler(this.btnTongGiaTriPhanTuLe_Click);
            // 
            // btnSapMangGiam
            // 
            this.btnSapMangGiam.Location = new System.Drawing.Point(188, 247);
            this.btnSapMangGiam.Name = "btnSapMangGiam";
            this.btnSapMangGiam.Size = new System.Drawing.Size(175, 23);
            this.btnSapMangGiam.TabIndex = 9;
            this.btnSapMangGiam.Text = "Sắp mảng giảm";
            this.btnSapMangGiam.UseVisualStyleBackColor = true;
            this.btnSapMangGiam.Click += new System.EventHandler(this.btnSapMangGiam_Click);
            // 
            // btnDemSoPhanTuLe
            // 
            this.btnDemSoPhanTuLe.Location = new System.Drawing.Point(2, 207);
            this.btnDemSoPhanTuLe.Name = "btnDemSoPhanTuLe";
            this.btnDemSoPhanTuLe.Size = new System.Drawing.Size(175, 23);
            this.btnDemSoPhanTuLe.TabIndex = 4;
            this.btnDemSoPhanTuLe.Text = "Đếm số phần tử lẻ";
            this.btnDemSoPhanTuLe.UseVisualStyleBackColor = true;
            this.btnDemSoPhanTuLe.Click += new System.EventHandler(this.btnDemSoPhanTuLe_Click);
            // 
            // btnSapMangTang
            // 
            this.btnSapMangTang.Location = new System.Drawing.Point(188, 207);
            this.btnSapMangTang.Name = "btnSapMangTang";
            this.btnSapMangTang.Size = new System.Drawing.Size(175, 23);
            this.btnSapMangTang.TabIndex = 8;
            this.btnSapMangTang.Text = "Sắp mảng tăng";
            this.btnSapMangTang.UseVisualStyleBackColor = true;
            this.btnSapMangTang.Click += new System.EventHandler(this.btnSapMangTang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 276);
            this.Controls.Add(this.btnSapMangTang);
            this.Controls.Add(this.btnDemSoPhanTuLe);
            this.Controls.Add(this.btnSapMangGiam);
            this.Controls.Add(this.btnTongGiaTriPhanTuLe);
            this.Controls.Add(this.btnTangMoiPhanTuLen2);
            this.Controls.Add(this.btnTinhTongGiaTriMang);
            this.Controls.Add(this.btnTimPhanTuNhoNhat);
            this.Controls.Add(this.btnXuatMangNgauNhien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm việc với mảng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMangGoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnXuatMangNgauNhien;
        private System.Windows.Forms.Button btnTimPhanTuNhoNhat;
        private System.Windows.Forms.Button btnTinhTongGiaTriMang;
        private System.Windows.Forms.Button btnTangMoiPhanTuLen2;
        private System.Windows.Forms.Button btnTongGiaTriPhanTuLe;
        private System.Windows.Forms.Button btnSapMangGiam;
        private System.Windows.Forms.Button btnDemSoPhanTuLe;
        private System.Windows.Forms.Button btnSapMangTang;
    }
}

