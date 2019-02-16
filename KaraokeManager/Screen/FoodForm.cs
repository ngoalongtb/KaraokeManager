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
    public partial class FoodForm : Form
    {
        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;
            ChangeHeader();
            LoadDataBinding();
        }

        public void LoadDtgv()
        {
            bds.DataSource = db.Foods.Select(x => new { x.Id, x.Name, x.Price }).ToList();
        }
        public void ChangeHeader()
        {
            dtgv.Columns["Id"].HeaderText = "Mã món ăn";
            dtgv.Columns["Name"].HeaderText = "Tên món ăn";
            dtgv.Columns["Price"].HeaderText = "Giá";
        }
        public void LoadDataBinding()
        {
            txtMa.DataBindings.Add("Text", dtgv.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txtTen.DataBindings.Add("Text", dtgv.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txtPrice.DataBindings.Add("Text", dtgv.DataSource, "Price", true, DataSourceUpdateMode.Never);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = db.Foods.Find(int.Parse(txtMa.Text));

                food.Name = txtTen.Text;
                food.Price = double.Parse(txtPrice.Text);


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
            try
            {
                Food food = new Food();

                food.Name = txtTen.Text;
                food.Price = double.Parse(txtPrice.Text);
                db.Foods.Add(food);
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
                    Food food = db.Foods.Find(int.Parse(txtMa.Text));
                    db.Foods.Remove(food);
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
            bds.DataSource = db.Foods.Where(x => x.Name.Contains(txtTimKiem.Text) || x.Id.ToString().Contains(txtTimKiem.Text)).Select(x => new { x.Id, x.Name, x.Price }).ToList();
        }
    }
}
