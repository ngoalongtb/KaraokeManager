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
    public partial class UserForm : Form
    {

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;
            ChangeHeader();
            LoadDataBinding();
        }

        public void LoadDtgv()
        {
            bds.DataSource = db.Users.Select(x => new { x.Username, x.Fullname, x.PhoneNumber, x.PersonId, x.UserType}).ToList();
        }

        public void ChangeHeader()
        {
            dtgv.Columns["Username"].HeaderText = "Tên đăng nhập";
            dtgv.Columns["Fullname"].HeaderText = "Họ tên";
            dtgv.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dtgv.Columns["PersonId"].HeaderText = "CMTND";
            dtgv.Columns["UserType"].HeaderText = "Loại người dùng";
        }

        public void LoadDataBinding()
        {
            txtUsername.DataBindings.Add("Text", dtgv.DataSource, "Username", true, DataSourceUpdateMode.Never);
            txtFullName.DataBindings.Add("Text", dtgv.DataSource, "Fullname", true, DataSourceUpdateMode.Never);
            txtPhoneNumber.DataBindings.Add("Text", dtgv.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never);
            txtPersonId.DataBindings.Add("Text", dtgv.DataSource, "PersonId", true, DataSourceUpdateMode.Never);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                User user = db.Users.Find(txtUsername.Text);
                
                user.Password = txtPassword.Text;
                user.Fullname = txtFullName.Text;
                user.PhoneNumber = txtPhoneNumber.Text;
                user.PersonId = txtPersonId.Text;
                user.Username = cbxUserType.Text;

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
            User user = new User();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Fullname = txtFullName.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.PersonId = txtPersonId.Text;
            user.UserType = cbxUserType.Text;
            try
            {
                db.Users.Add(user);
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
                    User user = db.Users.Find(txtUsername.Text);
                    db.Users.Remove(user);
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
            bds.DataSource = db.Users.Where(x => x.Username.Contains(txtTimKiem.Text) || x.Fullname.Contains(txtTimKiem.Text)).Select(x => new { x.Username, x.Fullname, x.PhoneNumber, x.PersonId, x.UserType }).ToList();
        }

        
    }
}
