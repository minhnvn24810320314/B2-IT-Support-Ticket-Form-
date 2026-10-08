namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_2
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblNguoiYeuCau = new System.Windows.Forms.Label();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.lblNgayGhiNhan = new System.Windows.Forms.Label();
            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.grpMucDoUuTien = new System.Windows.Forms.GroupBox();
            this.rdoThap = new System.Windows.Forms.RadioButton();
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton();
            this.rdoKhanCap = new System.Windows.Forms.RadioButton();
            this.grpPhanLoai = new System.Windows.Forms.GroupBox();
            this.lblLoaiSuCo = new System.Windows.Forms.Label();
            this.cboLoaiSuCo = new System.Windows.Forms.ComboBox();
            this.grpThietBi = new System.Windows.Forms.GroupBox();
            this.chkMayTinhBan = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMayIn = new System.Windows.Forms.CheckBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.grpAnhLoi = new System.Windows.Forms.GroupBox();
            this.picAnhLoi = new System.Windows.Forms.PictureBox();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();

            this.grpThongTin.SuspendLayout();
            this.grpMucDoUuTien.SuspendLayout();
            this.grpPhanLoai.SuspendLayout();
            this.grpThietBi.SuspendLayout();
            this.grpAnhLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.lblTieuDe.Location = new System.Drawing.Point(110, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(430, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TIẾP NHẬN & PHÂN LOẠI SỰ CỐ IT";

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaPhieu);
            this.grpThongTin.Controls.Add(this.txtMaPhieu);
            this.grpThongTin.Controls.Add(this.lblNguoiYeuCau);
            this.grpThongTin.Controls.Add(this.txtNguoiYeuCau);
            this.grpThongTin.Controls.Add(this.lblNgayGhiNhan);
            this.grpThongTin.Controls.Add(this.dtpNgayGhiNhan);
            this.grpThongTin.Controls.Add(this.grpMucDoUuTien);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.Location = new System.Drawing.Point(20, 65);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(320, 240);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin phiếu";

            // lblMaPhieu
            this.lblMaPhieu.Location = new System.Drawing.Point(15, 30);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(100, 23);
            this.lblMaPhieu.Text = "Mã phiếu:";

            // txtMaPhieu
            this.txtMaPhieu.Location = new System.Drawing.Point(120, 27);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(180, 24);

            // lblNguoiYeuCau
            this.lblNguoiYeuCau.Location = new System.Drawing.Point(15, 65);
            this.lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            this.lblNguoiYeuCau.Size = new System.Drawing.Size(100, 23);
            this.lblNguoiYeuCau.Text = "Người yêu cầu:";

            // txtNguoiYeuCau
            this.txtNguoiYeuCau.Location = new System.Drawing.Point(120, 62);
            this.txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            this.txtNguoiYeuCau.Size = new System.Drawing.Size(180, 24);

            // lblNgayGhiNhan
            this.lblNgayGhiNhan.Location = new System.Drawing.Point(15, 100);
            this.lblNgayGhiNhan.Name = "lblNgayGhiNhan";
            this.lblNgayGhiNhan.Size = new System.Drawing.Size(100, 23);
            this.lblNgayGhiNhan.Text = "Ngày ghi nhận:";

            // dtpNgayGhiNhan
            this.dtpNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGhiNhan.Location = new System.Drawing.Point(120, 97);
            this.dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            this.dtpNgayGhiNhan.Size = new System.Drawing.Size(180, 24);

            // grpMucDoUuTien
            this.grpMucDoUuTien.Controls.Add(this.rdoThap);
            this.grpMucDoUuTien.Controls.Add(this.rdoTrungBinh);
            this.grpMucDoUuTien.Controls.Add(this.rdoKhanCap);
            this.grpMucDoUuTien.Location = new System.Drawing.Point(15, 135);
            this.grpMucDoUuTien.Name = "grpMucDoUuTien";
            this.grpMucDoUuTien.Size = new System.Drawing.Size(285, 85);
            this.grpMucDoUuTien.Text = "Mức độ ưu tiên";

            // rdoThap
            this.rdoThap.Checked = true;
            this.rdoThap.Location = new System.Drawing.Point(15, 30);
            this.rdoThap.Name = "rdoThap";
            this.rdoThap.Size = new System.Drawing.Size(70, 24);
            this.rdoThap.Text = "Thấp";

            // rdoTrungBinh
            this.rdoTrungBinh.Location = new System.Drawing.Point(90, 30);
            this.rdoTrungBinh.Name = "rdoTrungBinh";
            this.rdoTrungBinh.Size = new System.Drawing.Size(95, 24);
            this.rdoTrungBinh.Text = "Trung bình";

            // rdoKhanCap
            this.rdoKhanCap.Location = new System.Drawing.Point(190, 30);
            this.rdoKhanCap.Name = "rdoKhanCap";
            this.rdoKhanCap.Size = new System.Drawing.Size(85, 24);
            this.rdoKhanCap.Text = "Khẩn cấp";

            // 
            // grpPhanLoai
            // 
            this.grpPhanLoai.Controls.Add(this.lblLoaiSuCo);
            this.grpPhanLoai.Controls.Add(this.cboLoaiSuCo);
            this.grpPhanLoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPhanLoai.Location = new System.Drawing.Point(20, 315);
            this.grpPhanLoai.Name = "grpPhanLoai";
            this.grpPhanLoai.Size = new System.Drawing.Size(320, 75);
            this.grpPhanLoai.Text = "Phân loại sự cố";

            // lblLoaiSuCo
            this.lblLoaiSuCo.Location = new System.Drawing.Point(15, 30);
            this.lblLoaiSuCo.Name = "lblLoaiSuCo";
            this.lblLoaiSuCo.Size = new System.Drawing.Size(80, 23);
            this.lblLoaiSuCo.Text = "Loại sự cố:";

            // cboLoaiSuCo
            this.cboLoaiSuCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSuCo.Location = new System.Drawing.Point(100, 27);
            this.cboLoaiSuCo.Name = "cboLoaiSuCo";
            this.cboLoaiSuCo.Size = new System.Drawing.Size(200, 24);

            // 
            // grpThietBi
            // 
            this.grpThietBi.Controls.Add(this.chkMayTinhBan);
            this.grpThietBi.Controls.Add(this.chkLaptop);
            this.grpThietBi.Controls.Add(this.chkMayIn);
            this.grpThietBi.Controls.Add(this.chkDienThoai);
            this.grpThietBi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThietBi.Location = new System.Drawing.Point(20, 400);
            this.grpThietBi.Name = "grpThietBi";
            this.grpThietBi.Size = new System.Drawing.Size(320, 90);
            this.grpThietBi.Text = "Thiết bị ảnh hưởng";

            // chkMayTinhBan
            this.chkMayTinhBan.Location = new System.Drawing.Point(15, 25);
            this.chkMayTinhBan.Name = "chkMayTinhBan";
            this.chkMayTinhBan.Size = new System.Drawing.Size(120, 24);
            this.chkMayTinhBan.Text = "Máy tính bàn";

            // chkLaptop
            this.chkLaptop.Location = new System.Drawing.Point(150, 25);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(120, 24);
            this.chkLaptop.Text = "Laptop";

            // chkMayIn
            this.chkMayIn.Location = new System.Drawing.Point(15, 55);
            this.chkMayIn.Name = "chkMayIn";
            this.chkMayIn.Size = new System.Drawing.Size(120, 24);
            this.chkMayIn.Text = "Máy in";

            // chkDienThoai
            this.chkDienThoai.Location = new System.Drawing.Point(150, 55);
            this.chkDienThoai.Name = "chkDienThoai";
            this.chkDienThoai.Size = new System.Drawing.Size(120, 24);
            this.chkDienThoai.Text = "Điện thoại";

            // 
            // grpAnhLoi
            // 
            this.grpAnhLoi.Controls.Add(this.picAnhLoi);
            this.grpAnhLoi.Controls.Add(this.btnTaiAnh);
            this.grpAnhLoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAnhLoi.Location = new System.Drawing.Point(360, 65);
            this.grpAnhLoi.Name = "grpAnhLoi";
            this.grpAnhLoi.Size = new System.Drawing.Size(280, 425);
            this.grpAnhLoi.Text = "Ảnh chụp lỗi";

            // picAnhLoi
            this.picAnhLoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhLoi.Location = new System.Drawing.Point(15, 25);
            this.picAnhLoi.Name = "picAnhLoi";
            this.picAnhLoi.Size = new System.Drawing.Size(250, 340);
            this.picAnhLoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // btnTaiAnh
            this.btnTaiAnh.Location = new System.Drawing.Point(15, 375);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(250, 35);
            this.btnTaiAnh.Text = "Tải ảnh lỗi";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);

            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuiYeuCau.Location = new System.Drawing.Point(180, 510);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(140, 40);
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = true;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);

            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNhapLai.Location = new System.Drawing.Point(340, 510);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(140, 40);
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(660, 570);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpPhanLoai);
            this.Controls.Add(this.grpThietBi);
            this.Controls.Add(this.grpAnhLoi);
            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.btnNhapLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Support Ticket Form";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpMucDoUuTien.ResumeLayout(false);
            this.grpMucDoUuTien.PerformLayout();
            this.grpPhanLoai.ResumeLayout(false);
            this.grpPhanLoai.PerformLayout();
            this.grpThietBi.ResumeLayout(false);
            this.grpThietBi.PerformLayout();
            this.grpAnhLoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblNguoiYeuCau;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;
        private System.Windows.Forms.Label lblNgayGhiNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;
        private System.Windows.Forms.GroupBox grpMucDoUuTien;
        private System.Windows.Forms.RadioButton rdoThap;
        private System.Windows.Forms.RadioButton rdoTrungBinh;
        private System.Windows.Forms.RadioButton rdoKhanCap;
        private System.Windows.Forms.GroupBox grpPhanLoai;
        private System.Windows.Forms.Label lblLoaiSuCo;
        private System.Windows.Forms.ComboBox cboLoaiSuCo;
        private System.Windows.Forms.GroupBox grpThietBi;
        private System.Windows.Forms.CheckBox chkMayTinhBan;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkMayIn;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.GroupBox grpAnhLoi;
        private System.Windows.Forms.PictureBox picAnhLoi;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Button btnNhapLai;
    }
}