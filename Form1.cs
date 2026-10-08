using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách loại sự cố cho ComboBox
            cboLoaiSuCo.Items.Clear();
            cboLoaiSuCo.Items.Add("Sự cố Phần cứng");
            cboLoaiSuCo.Items.Add("Sự cố Phần mềm");
            cboLoaiSuCo.Items.Add("Lỗi Mạng / Internet");
            cboLoaiSuCo.Items.Add("Tài khoản & Phân quyền");
            cboLoaiSuCo.Items.Add("Khác");
            cboLoaiSuCo.SelectedIndex = 0;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh chụp lỗi";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picAnhLoi.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            // Lấy mức độ ưu tiên
            string mucDoUuTien = "Thấp";
            if (rdoTrungBinh.Checked) mucDoUuTien = "Trung bình";
            else if (rdoKhanCap.Checked) mucDoUuTien = "Khẩn cấp";

            // Lấy danh sách thiết bị ảnh hưởng
            List<string> thietBi = new List<string>();
            if (chkMayTinhBan.Checked) thietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) thietBi.Add("Laptop");
            if (chkMayIn.Checked) thietBi.Add("Máy in");
            if (chkDienThoai.Checked) thietBi.Add("Điện thoại");

            string dsThietBi = thietBi.Count > 0 ? string.Join(", ", thietBi) : "Không xác định";

            // Hiển thị tóm tắt thông tin
            string thongTinPhieu = $"--- TÓM TẮT PHIẾU YÊU CẦU IT ---\n\n" +
                                   $"Mã phiếu: {txtMaPhieu.Text}\n" +
                                   $"Người yêu cầu: {txtNguoiYeuCau.Text}\n" +
                                   $"Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}\n" +
                                   $"Mức độ ưu tiên: {mucDoUuTien}\n" +
                                   $"Loại sự cố: {cboLoaiSuCo.SelectedItem}\n" +
                                   $"Thiết bị ảnh hưởng: {dsThietBi}\n" +
                                   $"Đã đính kèm ảnh: {(picAnhLoi.Image != null ? "Có" : "Không")}";

            MessageBox.Show(thongTinPhieu, "Gửi yêu cầu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            rdoThap.Checked = true;
            if (cboLoaiSuCo.Items.Count > 0) cboLoaiSuCo.SelectedIndex = 0;

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }

            txtMaPhieu.Focus();
        }
    }
}