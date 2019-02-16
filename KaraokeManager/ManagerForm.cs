using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using KaraokeManager.AppCode;
using KaraokeManager.Screen;

namespace KaraokeManager
{
    public partial class ManagerForm : DevExpress.XtraBars.Ribbon.RibbonForm, Triggerable
    {
        public ManagerForm()
        {
            InitializeComponent();
            Trigger(ScreenName.HOME);
            AppState.ManagerForm = this;
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
        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            Trigger(ScreenName.HOME);
        }

        private void btnFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            Trigger(ScreenName.FOOD);
        }

        private void btnMusic_ItemClick(object sender, ItemClickEventArgs e)
        {
            Trigger(ScreenName.MUSIC);
        }

        private void btnRoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            Trigger(ScreenName.ROOM);
        }

        public void Trigger(string screen, object data)
        {
            throw new NotImplementedException();
        }

        private void btnUserInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Trigger(ScreenName.USER_INFO);
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            Trigger(ScreenName.USER);
        }

        private void btnSinhVienThucHien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Trigger(ScreenName.USER_INFO);
        }
    }
}