using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_02
{
    public partial class frmSanpham : Form
    {

        public frmSanpham()
        {
            InitializeComponent();
            LoadDaTa();
            LoadComboBox();
        }
        DBcontext context = new DBcontext();
        List<SanphamViewModel> listView = new List<SanphamViewModel>();
        public void LoadDaTa()
        {
            listView.Clear();
            var lstLoaiSP = context.LoaiSPs.ToList();
            var lstSP = context.Sanphams.ToList();
            foreach (var item in lstSP)
            {
                SanphamViewModel sp = new SanphamViewModel();
                sp.Masp = item.MaSP;
                sp.Tensp = item.TenSP;
                sp.Ngaynhap = item.NgayNhap;
                sp.Loaisp= item.LoaiSP.TenLoai;
                listView.Add(sp);
            }
            lvSanpham.DataSource = null;
            lvSanpham.DataSource = listView;
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            LoadDaTa();
            btnluu.Enabled = false;
            btnkluu.Enabled = false;


        }
        public void LoadComboBox()
        {
            var tenSP = context.LoaiSPs.ToList();
            cboLoaisp.DataSource = tenSP;
            cboLoaisp.DisplayMember = "TenLoai";
            cboLoaisp.ValueMember = "MaLoai";
        }

        private void lvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow row = lvSanpham.Rows[e.RowIndex];
            if (row != null)
            {
                txtMasp.Text = row.Cells[0].Value.ToString();
                txtTensp.Text = row.Cells[1].Value.ToString();
                dtNgaynhap.Text = row.Cells[2].Value.ToString();
                cboLoaisp.Text = row.Cells[3].Value.ToString();
            }
        }
        public void RefeshTextBox()
        {
            txtMasp.Clear();
            txtTensp.Clear();
            cboLoaisp.SelectedIndex = -1;
            dtNgaynhap.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(context.Sanphams.Any(t => t.MaLoai == txtMasp.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }
            var sanpham = new Sanpham()
            {
                MaSP = txtMasp.Text,
                TenSP = txtTensp.Text,
                NgayNhap = dtNgaynhap.Value,
                MaLoai = cboLoaisp.SelectedValue.ToString(),
            };
            context.Sanphams.Add(sanpham);
            context.SaveChanges();
            MessageBox.Show("Thêm mới dữ liệu thành công!");
            RefeshTextBox();
            btnluu.Enabled = true;     
            btnkluu.Enabled = true; 
            LoadDaTa();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var existingSanPham = context.Sanphams.FirstOrDefault(s => s.MaSP == txtMasp.Text);
            if (existingSanPham == null)
            {
                MessageBox.Show("Không tìm thấy mã sản phẩm cần sửa!");
                return;
            }
            existingSanPham.TenSP = txtTensp.Text;
            existingSanPham.NgayNhap = dtNgaynhap.Value;
            existingSanPham.MaLoai = cboLoaisp.SelectedValue.ToString();
            context.SaveChanges();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
            RefeshTextBox();
            LoadDaTa();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var sanPhamID = lvSanpham.SelectedRows[0].Cells[0].Value.ToString();
            var sanPham = context.Sanphams.FirstOrDefault(x => x.MaSP == sanPhamID);
            if (sanPham == null)
            {
                MessageBox.Show("Không tìm thấy mã sản phẩm cần xóa!");
                return;
            }
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                context.Sanphams.Remove(sanPham);
                context.SaveChanges();
                MessageBox.Show("Xóa sản phẩm thành công !");
                RefeshTextBox();
                LoadDaTa();
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchText = txtTim.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                listView.Clear();
                var lstSP = context.Sanphams.Where(tim => tim.TenSP.Contains(searchText)).ToList();
                foreach (var item in lstSP)
                {
                    SanphamViewModel sp = new SanphamViewModel();
                    sp.Masp = item.MaSP;
                    sp.Tensp = item.TenSP;
                    sp.Ngaynhap = item.NgayNhap;
                    sp.Loaisp = item.LoaiSP.TenLoai;
                    listView.Add(sp);
                }
                lvSanpham.DataSource = null;
                lvSanpham.DataSource = listView;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
                return;
            }

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công!");
            btnluu.Enabled = false;    
            btnkluu.Enabled = false;
        }

        private void btnkluu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy thao tác!");
            RefeshTextBox();          
            btnluu.Enabled = false;
            btnkluu.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
