using KaraokeManager.AppCode;
using KaraokeManager.EF;
using KaraokeManager.Screen;
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
    public partial class NewManagerForm : Form, Triggerable
    {
        public NewManagerForm()
        {
            InitializeComponent();
            //Trigger(ScreenName.HOME);
            AppState.ManagerForm = this;
            if (Session.LoginAccount.UserType != "Quản trị viên")
            {
                //ribbonAdmin.Visible = false;
            }
        }
        public void Trigger()
        {
            throw new NotImplementedException();
        }
        public void Trigger(string screen)
        {
            Form form = null;

            switch (screen)
            {
                case ScreenName.HOME:
                    form = new HomeForm();
                    break;
                case ScreenName.MUSIC:
                    form = new MusicForm();
                    break;
                case ScreenName.USER_INFO:
                    form = new UserInfoForm();
                    break;
                case ScreenName.ROOM:
                    form = new RoomForm();
                    break;
                case ScreenName.FOOD:
                    form = new FoodForm();
                    break;
                case ScreenName.USER:
                    form = new UserForm();
                    break;


            }

            form.MdiParent = this;
            form.Show();
        }


        public void Trigger(string screen, object data)
        {
            Form form = null;

            switch (screen)
            {
                case ScreenName.ROOM_DETAIL:
                    form = new RoomDetailStatusForm(data as Room);
                    break;
            }

            form.MdiParent = this;
            form.Show();
        }



        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        /*private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo);
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        */

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trigger(ScreenName.HOME);
        }

        private void menuAmNhac_Click(object sender, EventArgs e)
        {
            Trigger(ScreenName.MUSIC);
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo);
            if(thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trigger(ScreenName.ROOM);
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trigger(ScreenName.FOOD);
        }

        private void menuQuantri_Click(object sender, EventArgs e)
        {
            Trigger(ScreenName.USER);
        }

        private void menuTTNV_Click(object sender, EventArgs e)
        {
            Trigger(ScreenName.USER_INFO);
        }

        private void âmNhạcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trigger(ScreenName.MUSIC);
        }
    }
}
