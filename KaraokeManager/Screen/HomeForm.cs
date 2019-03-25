using KaraokeManager.AppCode;
using KaraokeManager.Components;
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
    public partial class HomeForm : Form
    {
        public AppDB db = new AppDB();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadRooms();
        }

        private void loadRooms()
        {
            lblSoPhongTrong.Text = db.Rooms.Count(x => x.Status == RoomStatus.TRONG).ToString();
            lblSoPhongCoKhach.Text = db.Rooms.Count(x => x.Status == RoomStatus.CO_KHACH).ToString();
            lblSoPhongBan.Text = db.Rooms.Count(x => x.Status == RoomStatus.BAN).ToString();
            lblSoPhongDangDonDep.Text = db.Rooms.Count(x => x.Status == RoomStatus.DANG_DON_DEP).ToString();
            lblSoPhongDangSuaChua.Text = db.Rooms.Count(x => x.Status == RoomStatus.DANG_SUA_CHUA).ToString();
            lblSoPhongDatTruoc.Text = db.Rooms.Count(x => x.Status == RoomStatus.DAT_TRUOC).ToString();
            lblTongCong.Text = db.Rooms.Count().ToString();

            foreach (var room in db.Rooms.ToList())
            {
                RoomUC roomUC = new RoomUC(room);
                pnContent.Controls.Add(roomUC);
            }
        }
    }
}
