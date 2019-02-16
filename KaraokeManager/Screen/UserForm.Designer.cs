namespace KaraokeManager.Screen
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::KaraokeManager.Properties.Resources.delete_32x32;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(78, 409);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 42);
            this.btnXoa.TabIndex = 73;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(78, 361);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 42);
            this.btnThem.TabIndex = 71;
            this.btnThem.Text = "      Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Image = global::KaraokeManager.Properties.Resources.Refresh2_32x32;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(201, 409);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(117, 42);
            this.btnXem.TabIndex = 74;
            this.btnXem.Text = "    Tải lại";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::KaraokeManager.Properties.Resources.Zoom_32x32;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(533, 12);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 35);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "     Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::KaraokeManager.Properties.Resources.Apply_32x32;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(201, 361);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 42);
            this.btnSua.TabIndex = 72;
            this.btnSua.Text = "     Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 480);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxUserType);
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonId);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 459);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người dùng";
            // 
            // cbxUserType
            // 
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Quản trị viên",
            "Nhân viên"});
            this.cbxUserType.Location = new System.Drawing.Point(159, 105);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(150, 27);
            this.cbxUserType.TabIndex = 109;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(159, 138);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(151, 27);
            this.dtpkNgaySinh.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 102;
            this.label6.Text = "CMTND :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 103;
            this.label5.Text = "Sinh nhật :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 104;
            this.label7.Text = "Tên đầy đủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 105;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 106;
            this.label3.Text = "Loại tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "Tên người dùng :";
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(159, 172);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(150, 27);
            this.txtPersonId.TabIndex = 96;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(159, 248);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(150, 27);
            this.txtFullName.TabIndex = 98;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(159, 206);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 27);
            this.txtPhoneNumber.TabIndex = 99;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 27);
            this.txtPassword.TabIndex = 100;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(159, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 27);
            this.txtUsername.TabIndex = 95;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(340, 17);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(183, 27);
            this.txtTimKiem.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(349, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 427);
            this.panel3.TabIndex = 17;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dtgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.dtgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(659, 427);
            this.dtgv.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 53);
            this.panel2.TabIndex = 16;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Name = "UserForm";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxUserType;
    }
}