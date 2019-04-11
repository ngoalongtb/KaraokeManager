using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using KaraokeManager.AppCode;
using KaraokeManager.EF;
using KaraokeManager.Report;

namespace KaraokeManager.Screen
{
    public partial class RoomDetailStatusForm : Form
    {
        private Room room;
        private AppDB db = new AppDB();
        private Order order;


        private BindingSource bdsFood = new BindingSource();
        private BindingSource bdsMusic = new BindingSource();

        public RoomDetailStatusForm(Room room)
        {
            this.room = db.Rooms.Find(room.Code);
            InitializeComponent();
            LoadCbxItem();
            LoadRoomInfo();
        }

        public void LoadCbxItem()
        {
            cbxTrangThai.Items.Add(RoomStatus.TRONG);
            cbxTrangThai.Items.Add(RoomStatus.CO_KHACH);
            cbxTrangThai.Items.Add(RoomStatus.BAN);
            cbxTrangThai.Items.Add(RoomStatus.DANG_DON_DEP);
            cbxTrangThai.Items.Add(RoomStatus.DANG_SUA_CHUA);
            cbxTrangThai.Items.Add(RoomStatus.DAT_TRUOC);
        }

        public void LoadDtgvs()
        {
            LoadDtgvFood();
            LoadDtgvMusic();
        }
        public void LoadDtgvFood()
        {
            bdsFood.DataSource = order.OrderFoods.Select(x => new {x.FoodId, x.FoodPrice, x.Food.Name});
            dtgvFood.DataSource = bdsFood;

            double price = 0;
            foreach (var orderFood in order.OrderFoods)
            {
                price += orderFood.FoodPrice.Value;
            }

            lblTotalFood.Text = price.ToString();
            lblTotalPriceFood.Text = price.ToString();
            lblTotalPrice.Text = (int.Parse(lblTotalPriceFood.Text) + int.Parse(lblTotalPriceRoomOrMusic.Text)).ToString();
        }

        public void LoadDtgvMusic()
        {
            try
            {
                bdsMusic.DataSource = order.OrderMusics.Select(x => new { x.MusicId, x.Music.Name });
                dtgvMusic.DataSource = bdsMusic;
                lblTotalMusic.Text = (order.OrderMusics.Count() * 20000).ToString();

                if (cbxOrderType.Text == "Theo giờ")
                {
                    lblThoiLuongOrBaiHatKey.Text = "Thời lượng:";
                    dtpkEnd.Value = DateTime.Now;
                    if (dtpkStart.Value != null && dtpkEnd.Value != null)
                    {
                        TimeSpan span = dtpkEnd.Value - dtpkStart.Value;
                        int mm = span.Minutes;
                        lblThoiLuongOrBaiHatValue.Text = mm.ToString() + " phút";
                        lblTotalPriceRoomOrMusic.Text = ((1.0 * mm / 60) * order.Room.Price).ToString();
                    }
                }
                else
                {
                    lblThoiLuongOrBaiHatKey.Text = "Số bài hát:";
                    lblThoiLuongOrBaiHatValue.Text = (int.Parse(lblTotalMusic.Text) / 20000).ToString();
                    lblTotalPriceRoomOrMusic.Text = lblTotalMusic.Text;
                }
                lblTotalPrice.Text = (int.Parse(lblTotalPriceFood.Text) + double.Parse(lblTotalPriceRoomOrMusic.Text)).ToString();
            }
            catch (Exception)
            {
                
            }
        }

        public void LoadRoomInfo()
        {
            lblMaPhong.Text = this.room.Code;
            lblTenPhong.Text = this.room.Name;
            cbxTrangThai.Text = this.room.Status;
            lblGia.Text = this.room.Price.ToString();

            switch (this.room.Status)
            {
                case RoomStatus.TRONG:
                case RoomStatus.DANG_DON_DEP:
                case RoomStatus.DANG_SUA_CHUA:
                case RoomStatus.BAN:
                    break;
                case RoomStatus.DAT_TRUOC:
                case RoomStatus.CO_KHACH:
                    LoadThongTinPhongCoKhach();
                    break;
                default:
                    break;
            }
        }

        public void ValidateStatus()
        {
            if (order.Status == OrderStatus.DA_THANH_TOAN)
            {
                btnThanhToan.Enabled = false;
                btnBatDau.Enabled = false;
                btnThanhToan.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            else if (order.Status == OrderStatus.DAT_TRUOC)
            {
                btnDatTruoc.Enabled = false;
                btnBatDau.Enabled = false;
            }
            
        }

        public void LoadThongTinPhongCoKhach()
        {
            this.order = db.Orders.OrderByDescending(x => x.Id).FirstOrDefault(x => x.Room.Code == this.room.Code);

            if (order == null)
            {
                order = new Order();
                db.Orders.Add(order);
                db.SaveChanges();
            }

            txtKhachHang.Text = order.CustomerName;
            txtCMTND.Text = order.PersonID;
            txtSoDienThoai.Text = order.PhoneNumber;
            if (order.StartDateTime != null)
            {
                dtpkStart.Value = order.StartDateTime.Value;
            }

            LoadDtgvs();
            ValidateStatus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                order.CustomerName = txtKhachHang.Text;
                order.PhoneNumber = txtSoDienThoai.Text;
                order.PersonID = txtCMTND.Text;

                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                LoadDtgvs();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại" + exception.Message);
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean confirmOrderBefore = false;
                Order orderBefore =
                    db.Orders.SingleOrDefault(x => x.RoomCode == room.Code && x.Status == RoomStatus.DAT_TRUOC);
                if (orderBefore != null)
                {
                    var confirmResult = MessageBox.Show(string.Format("Bạn là {0} CMTND {1}", orderBefore.CustomerName, orderBefore.PersonID ) ,
                        "Có phải bạn đã đặt trước phòng này!!",
                        MessageBoxButtons.YesNo);

                    confirmOrderBefore = (confirmResult == DialogResult.Yes);
                }

                if (!confirmOrderBefore)
                {
                    order = new Order();
                    order.StartDateTime = DateTime.Now;
                    order.CustomerName = txtKhachHang.Text;
                    order.PhoneNumber = txtSoDienThoai.Text;
                    order.PersonID = txtCMTND.Text;
                    
                    order.RoomCode = lblMaPhong.Text;

                    db.Orders.Add(order);
                }
                else
                {
                    orderBefore.StartDateTime = DateTime.Now;
                    orderBefore.Status = "";
                    order = orderBefore;
                }
                room.Status = RoomStatus.CO_KHACH;
                db.SaveChanges();

                dtpkStart.Enabled = true;
                dtpkEnd.Enabled = true;
                dtpkStart.Value = DateTime.Now;
                MessageBox.Show("Nhận phòng thành công");
                LoadRoomInfo();
                LoadDtgvs();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại" + exception.Message);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            OrderReportModel reportModel = new OrderReportModel();
            OrderReport report = new OrderReport(reportModel);
            //report.DataSource = list;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            try
            {
                order = new Order();
                order.StartDateTime = dtpkStart.Value;
                order.CustomerName = txtKhachHang.Text;
                order.PhoneNumber = txtSoDienThoai.Text;
                order.PersonID = txtCMTND.Text;
                order.Status = OrderStatus.DAT_TRUOC;
                order.RoomCode = room.Code;
                order.KaraokeType = cbxOrderType.SelectedText;

                db.Orders.Add(order);
                db.SaveChanges();
                LoadRoomInfo();
                MessageBox.Show("Đặt trước thành công");
                LoadDtgvs();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại" + exception.Message);
            }
        }

        private void btnFillFood_Click(object sender, EventArgs e)
        {
            int maMon = int.Parse(txtMaMon.Text);
            Food food = db.Foods.SingleOrDefault(x => x.Id == maMon);
            if (food != null)
            {
                lblMaMonAn.Text = food.Id.ToString();
                lblTenMonAn.Text = food.Name;
                lblGiaMonAn.Text = food.Price.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã món ăn");
            }
        }

        private void btnFillMusic_Click(object sender, EventArgs e)
        {
            int maBaiHat = int.Parse(txtMaBaiHat.Text);
            Music music = db.Musics.SingleOrDefault(x => x.Id == maBaiHat);
            if (music != null)
            {
                lblMaBaiHat.Text = music.Id.ToString();
                lblTenBaiHat.Text = music.Name;
                lblCaSi.Text = music.Singer;
                lblTacGia.Text = music.Author;
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã bài hát");
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                OrderFood orderFood = new OrderFood();
                orderFood.FoodId = int.Parse(lblMaMonAn.Text);
                orderFood.FoodPrice = double.Parse(lblGiaMonAn.Text);

                order.OrderFoods.Add(orderFood);
                db.SaveChanges();
                LoadDtgvFood();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có lỗi xảy ra " + exception.Message);
            }
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            try
            {
                OrderMusic orderMusic = new OrderMusic();
                orderMusic.MusicId = int.Parse(lblMaBaiHat.Text);

                order.OrderMusics.Add(orderMusic);
                db.SaveChanges();
                LoadDtgvMusic();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có lỗi xảy ra " + exception.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dtpkEnd.Value = DateTime.Now;
            if (dtpkStart.Value != null && dtpkEnd.Value != null)
            {
                TimeSpan span = dtpkEnd.Value - dtpkStart.Value;
                int mm = span.Minutes;
                lblThoiLuongOrBaiHatValue.Text = mm.ToString() + " phút";
            } 
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                order.Status = OrderStatus.DA_THANH_TOAN;
                room.Status = RoomStatus.TRONG;
                db.SaveChanges();

                MessageBox.Show("Thanh toán thành công");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có lỗi xảy ra " + exception.Message);
            }
        }

        private void cbxOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomInfo();
            LoadDtgvMusic();
        }
    }
}
