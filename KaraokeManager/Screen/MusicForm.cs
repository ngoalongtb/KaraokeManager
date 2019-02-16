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
    public partial class MusicForm : Form
    {
        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        public MusicForm()
        {
            InitializeComponent();
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;
            ChangeHeader();
            LoadDataBinding();
        }
        
        public void LoadDtgv()
        {
            bds.DataSource = db.Musics.Select(x => new { x.Id, x.Name, x.Author, x.Singer}).ToList();
        }
        public void ChangeHeader()
        {
            dtgv.Columns["Id"].HeaderText = "Mã bài hát";
            dtgv.Columns["Name"].HeaderText = "Tên bài hát";
            dtgv.Columns["Author"].HeaderText = "Nhạc sĩ";
            dtgv.Columns["Singer"].HeaderText = "Ca sĩ";
        }
        public void LoadDataBinding()
        {
            txtMa.DataBindings.Add("Text", dtgv.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txtTen.DataBindings.Add("Text", dtgv.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txtAuthor.DataBindings.Add("Text", dtgv.DataSource, "Author", true, DataSourceUpdateMode.Never);
            txtSinger.DataBindings.Add("Text", dtgv.DataSource, "Singer", true, DataSourceUpdateMode.Never);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Music music = db.Musics.Find(int.Parse(txtMa.Text));

                music.Name = txtTen.Text;
                music.Author = txtAuthor.Text;
                music.Singer = txtSinger.Text;

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
            Music music = new Music();
            music.Name = txtTen.Text;
            music.Author = txtAuthor.Text;
            music.Singer = txtSinger.Text;

            try
            {
                db.Musics.Add(music);
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
                    Music music = db.Musics.Find(int.Parse(txtMa.Text));
                    db.Musics.Remove(music);
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
            bds.DataSource = db.Musics.Where(x => x.Name.Contains(txtTimKiem.Text) || x.Author.Contains(txtTimKiem.Text) || x.Singer.Contains(txtTimKiem.Text)).Select(x => new { x.Id, x.Name, x.Author, x.Singer }).ToList();
        }


    }
}
