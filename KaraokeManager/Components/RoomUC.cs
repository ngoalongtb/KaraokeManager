using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaraokeManager.EF;
using KaraokeManager.AppCode;

namespace KaraokeManager.Components
{
    public partial class RoomUC : UserControl
    {
        private Room room;

        public RoomUC(Room room)
        {
            InitializeComponent();
            Room = room;
            lblTimeStart.Text = "";
            lblTotalPrice.Text = "";
            lblTotalTime.Text = "";
        }

        public Room Room
        {
            get
            {
                return room;
            }
            set
            {
                lblRoomName.Text = value.Name;
                lblStatus.Text = value.Status.ToUpper();
                switch (value.Status)
                {
                    case RoomStatus.TRONG:
                        this.BackColor = ColorTranslator.FromHtml(StatusColor.TRONG);
                        break;
                    case RoomStatus.CO_KHACH:
                        this.BackColor = ColorTranslator.FromHtml(StatusColor.CO_KHACH);
                        break;
                    case RoomStatus.BAN:
                        this.BackColor = ColorTranslator.FromHtml(StatusColor.BAN);
                        break;
                    case RoomStatus.DANG_DON_DEP:
                        this.BackColor = ColorTranslator.FromHtml(StatusColor.DANG_DON_DEP);
                        break;
                    case RoomStatus.DANG_SUA_CHUA:
                        this.BackColor = ColorTranslator.FromHtml(StatusColor.DANG_SUA_CHUA);
                        break;
                    case RoomStatus.DAT_TRUOC:
                        this.BackColor = ColorTranslator.FromHtml(StatusColor.DAT_TRUOC);
                        break;
                    default:
                        break;
                }
                room = value;
            }
        }

        private void RoomUC_Click(object sender, EventArgs e)
        {
            AppState.ManagerForm.Trigger(ScreenName.ROOM_DETAIL, this.room);
        }
    }
}
