
namespace CS464_F_Nguyen_Son_5999
{
    partial class frm_ThongTinMatHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_ncc = new System.Windows.Forms.ComboBox();
            this.cb_donvitinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(102, 85);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(171, 27);
            this.txt_mahang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(452, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN MẶT HÀNG";
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(406, 85);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(171, 27);
            this.txt_tenhang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // cb_ncc
            // 
            this.cb_ncc.FormattingEnabled = true;
            this.cb_ncc.Location = new System.Drawing.Point(760, 85);
            this.cb_ncc.Name = "cb_ncc";
            this.cb_ncc.Size = new System.Drawing.Size(190, 28);
            this.cb_ncc.TabIndex = 6;
            this.cb_ncc.SelectedIndexChanged += new System.EventHandler(this.cb_ncc_SelectedIndexChanged);
            // 
            // cb_donvitinh
            // 
            this.cb_donvitinh.FormattingEnabled = true;
            this.cb_donvitinh.Items.AddRange(new object[] {
            "Cái",
            "Tấn",
            "Tạ",
            "Yến",
            "Thùng"});
            this.cb_donvitinh.Location = new System.Drawing.Point(1079, 85);
            this.cb_donvitinh.Name = "cb_donvitinh";
            this.cb_donvitinh.Size = new System.Drawing.Size(177, 28);
            this.cb_donvitinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(979, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị tính";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(88, 204);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(483, 204);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(94, 29);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(292, 204);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(94, 29);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1079, 242);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 29);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 295);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_ThongTinMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_donvitinh);
            this.Controls.Add(this.cb_ncc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThongTinMatHang";
            this.Text = "frm_ThongTinMatHang";
            this.Load += new System.EventHandler(this.frm_ThongTinMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_ncc;
        private System.Windows.Forms.ComboBox cb_donvitinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}