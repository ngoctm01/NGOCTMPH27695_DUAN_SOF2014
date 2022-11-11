using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _3.PL.Views
{
    public partial class FrmQLNhanVien : Form
    {
        private IQLNhanVienServices _IQLNhanVienServices;
        private IQLChucVuServices _IQLChucVuServices;
        private IQLCuaHangServices _IQLCuaHangServices;

        public FrmQLNhanVien()
        {
            InitializeComponent();
            _IQLNhanVienServices = new QLNhanVienServices();
            _IQLCuaHangServices = new QLCuaHangServices();
            _IQLChucVuServices = new QLChucVuServices();
            LoadCH();
            LoadCV();
            LoadData();
        }
        private void LoadCH()
        {
            foreach (var x in _IQLCuaHangServices.GetAll())
            {
                cmb_tench.Items.Add(x.Ten);
            }
        }
        private void LoadCV()
        {
            foreach (var x in _IQLChucVuServices.GetAll())
            {
                cmb_tencv.Items.Add(x.Ten);
            }
        }
        private void LoadData()
        {
            int stt = 1;
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Stt";
            dataGridView1.Columns[1].Name = "Ma";
            dataGridView1.Columns[2].Name = "Ten";
            dataGridView1.Columns[3].Name = "Gioi Tinh";
            dataGridView1.Columns[4].Name = "Ngay SInh";
            dataGridView1.Columns[5].Name = "Sdt";
            dataGridView1.Columns[6].Name = "DiaChi";
            dataGridView1.Columns[7].Name = "TenCH";
            dataGridView1.Columns[8].Name = "TenCV";
            dataGridView1.Rows.Clear();
            foreach (var x in _IQLNhanVienServices.GetAll())
            {
                dataGridView1.Rows.Add(stt++,x.Manv, x.Tennv, x.GioiTinh, x.NgaySinh, x.Sdt, x.Dchi,x.TemCH,x.Tencv);
            }
        }
        private NhanVienViews GetFormGui()
        {
            return new NhanVienViews()
            {
                Manv = txt_ma.Text,
                Tennv = txt_Tennv.Text,
                GioiTinh = txt_gioitinh.Text,
                NgaySinh = Convert.ToDateTime(dtp_ngaysinh.Text),
                Sdt = txt_Sdt.Text,
                Dchi = txt_dchi.Text,
                TemCH = cmb_tench.Text,
                Tencv = cmb_tencv.Text,
            };
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IQLNhanVienServices.Add(GetFormGui()));
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _IQLNhanVienServices.GetAll().Count) return;
            txt_ma.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            txt_Tennv.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            txt_gioitinh.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            dtp_ngaysinh.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            txt_Sdt.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            txt_dchi.Text = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
            cmb_tench.SelectedItem = dataGridView1.Rows[rowindex].Cells[7].Value.ToString();
            cmb_tencv.SelectedItem = dataGridView1.Rows[rowindex].Cells[8].Value.ToString();
        }
    }
}
