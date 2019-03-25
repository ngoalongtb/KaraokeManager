using KaraokeManager.AppCode;
using KaraokeManager.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManager.Screen
{
    public partial class RoomForm : Form
    {
        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            cbxTrangThai.Items.Add(RoomStatus.TRONG);
            cbxTrangThai.Items.Add(RoomStatus.CO_KHACH);
            cbxTrangThai.Items.Add(RoomStatus.BAN);
            cbxTrangThai.Items.Add(RoomStatus.DANG_DON_DEP);
            cbxTrangThai.Items.Add(RoomStatus.DANG_SUA_CHUA);
            cbxTrangThai.Items.Add(RoomStatus.DAT_TRUOC);


            LoadDtgv();
            dtgv.DataSource = bds;
            ChangeHeader();
            LoadDataBinding();
        }

        public void LoadDtgv()
        {
            bds.DataSource = db.Rooms.Select(x => new { x.Code, x.Name, x.Price, x.Status }).ToList();
        }

        public void ChangeHeader()
        {
            dtgv.Columns["Code"].HeaderText = "Mã phòng";
            dtgv.Columns["Name"].HeaderText = "Tên phòng";
            dtgv.Columns["Price"].HeaderText = "Giá phòng";
            dtgv.Columns["Status"].HeaderText = "Trang thái";
        }

        public void LoadDataBinding()
        {
            txtCode.DataBindings.Add("Text", dtgv.DataSource, "Code", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Add("Text", dtgv.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txtPrice.DataBindings.Add("Text", dtgv.DataSource, "Price", true, DataSourceUpdateMode.Never);
            cbxTrangThai.DataBindings.Add("Text", dtgv.DataSource, "Status", true, DataSourceUpdateMode.Never);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = db.Rooms.Find(txtCode.Text);

                room.Name = txtName.Text;
                room.Price = double.Parse(txtPrice.Text);
                room.Status = cbxTrangThai.Text;

                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                LoadDtgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Code = txtCode.Text;
            room.Name = txtName.Text;
            room.Price = double.Parse(txtPrice.Text);
            room.Status = cbxTrangThai.Text;

            try
            {
                db.Rooms.Add(room);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công");
                LoadDtgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới không thành công. Vui lòng kiểm tra lại");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    Room room = db.Rooms.Find(txtCode.Text);
                    db.Rooms.Remove(room);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    LoadDtgv();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDtgv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bds.DataSource = db.Rooms.Where(x => x.Name.Contains(txtTimKiem.Text) || x.Code.Contains(txtTimKiem.Text)).Select(x => new { x.Code, x.Name, x.Price, x.Status }).ToList();
        }
    }
}
