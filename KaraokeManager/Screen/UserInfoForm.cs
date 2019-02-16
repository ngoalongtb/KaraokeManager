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
    public partial class UserInfoForm : Form
    {
        private AppDB db = new AppDB();
        public UserInfoForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            User loginAccount = Session.LoginAccount;
            txtUsername.Text = Session.LoginAccount.Username;

            if (loginAccount != null)
            {
                txtHoTen.Text = loginAccount.Fullname;
                txtSoDienThoai.Text = loginAccount.PhoneNumber;
                txtCMTND.Text = loginAccount.PersonId;
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            if (txtPassword.Text != Session.LoginAccount.Password)
            {
                MessageBox.Show("Mật khẩu không chính xác");
                return;
            }
            if (txtNewPass.Text != txtReNewPass.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                return;
            }
            string strNewPass = Session.LoginAccount.Password;
            if (txtNewPass.Text.Trim() != "")
                strNewPass = txtNewPass.Text;

            User account = db.Users.Find(Session.LoginAccount.Username);
            account.Password = strNewPass;
            account.Fullname = txtHoTen.Text;
            account.PhoneNumber = txtSoDienThoai.Text;
            account.PersonId = txtCMTND.Text;


            try
            {
                db.SaveChanges();
                Session.LoginAccount = db.Users.Find(Session.LoginAccount.Username);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại. Xin lỗi vì sự cố đáng tiếc. Vui lòng gặp admin để sửa lỗi!!!");
            }
        }

    }
}
