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

namespace KaraokeManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        
        private AppDB db = new AppDB();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginQuery = db.Users.Where(x => x.Username == txtUsername.Text && x.Password == txtPassword.Text);
            if (loginQuery.Count() > 0)
            {
                this.Hide();
                User loginAccount = loginQuery.First();
                Session.LoginAccount = loginAccount;
                NewManagerForm f = new NewManagerForm();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại!!!");
            }
        }
    }
}
