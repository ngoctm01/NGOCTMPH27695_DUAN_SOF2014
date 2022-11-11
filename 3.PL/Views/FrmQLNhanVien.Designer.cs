namespace _3.PL.Views
{
    partial class FrmQLNhanVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dchi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cmb_tench = new System.Windows.Forms.ComboBox();
            this.cmb_tencv = new System.Windows.Forms.ComboBox();
            this.CH = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(854, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(105, 58);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(195, 27);
            this.dtp_ngaysinh.TabIndex = 1;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(104, 23);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(125, 27);
            this.txt_ma.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngay Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TenNv";
            // 
            // txt_Tennv
            // 
            this.txt_Tennv.Location = new System.Drawing.Point(429, 19);
            this.txt_Tennv.Name = "txt_Tennv";
            this.txt_Tennv.Size = new System.Drawing.Size(125, 27);
            this.txt_Tennv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gioi Tinh";
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Location = new System.Drawing.Point(429, 60);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(125, 27);
            this.txt_gioitinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sdt";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(657, 19);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(125, 27);
            this.txt_Sdt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dchi";
            // 
            // txt_dchi
            // 
            this.txt_dchi.Location = new System.Drawing.Point(657, 58);
            this.txt_dchi.Name = "txt_dchi";
            this.txt_dchi.Size = new System.Drawing.Size(125, 27);
            this.txt_dchi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(803, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(873, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 13;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(847, 63);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cmb_tench
            // 
            this.cmb_tench.FormattingEnabled = true;
            this.cmb_tench.Location = new System.Drawing.Point(973, 126);
            this.cmb_tench.Name = "cmb_tench";
            this.cmb_tench.Size = new System.Drawing.Size(151, 28);
            this.cmb_tench.TabIndex = 16;
            // 
            // cmb_tencv
            // 
            this.cmb_tencv.FormattingEnabled = true;
            this.cmb_tencv.Location = new System.Drawing.Point(973, 171);
            this.cmb_tencv.Name = "cmb_tencv";
            this.cmb_tencv.Size = new System.Drawing.Size(151, 28);
            this.cmb_tencv.TabIndex = 17;
            // 
            // CH
            // 
            this.CH.AutoSize = true;
            this.CH.Location = new System.Drawing.Point(906, 126);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(29, 20);
            this.CH.TabIndex = 18;
            this.CH.Text = "CH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "cv";
            // 
            // FrmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CH);
            this.Controls.Add(this.cmb_tencv);
            this.Controls.Add(this.cmb_tench);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_dchi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_gioitinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmQLNhanVien";
            this.Text = "FrmQLNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dchi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cmb_tench;
        private System.Windows.Forms.ComboBox cmb_tencv;
        private System.Windows.Forms.Label CH;
        private System.Windows.Forms.Label label9;
    }
}