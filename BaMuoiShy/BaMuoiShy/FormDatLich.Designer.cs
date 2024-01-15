namespace BaMuoiShy
{
    partial class FormDatLich
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
            this.gio = new System.Windows.Forms.ComboBox();
            this.diaDiem = new System.Windows.Forms.ComboBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nhuomToc = new System.Windows.Forms.CheckBox();
            this.uToc = new System.Windows.Forms.CheckBox();
            this.catTocNu = new System.Windows.Forms.CheckBox();
            this.catTocNam = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // gio
            // 
            this.gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gio.FormattingEnabled = true;
            this.gio.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.gio.Location = new System.Drawing.Point(491, 192);
            this.gio.Name = "gio";
            this.gio.Size = new System.Drawing.Size(143, 33);
            this.gio.TabIndex = 1;
            // 
            // diaDiem
            // 
            this.diaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaDiem.FormattingEnabled = true;
            this.diaDiem.Items.AddRange(new object[] {
            "TP.HCM",
            "DA NANG",
            "HA NOI"});
            this.diaDiem.Location = new System.Drawing.Point(491, 233);
            this.diaDiem.Name = "diaDiem";
            this.diaDiem.Size = new System.Drawing.Size(143, 33);
            this.diaDiem.TabIndex = 2;
            // 
            // btnDatLich
            // 
            this.btnDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.Location = new System.Drawing.Point(334, 332);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(110, 33);
            this.btnDatLich.TabIndex = 3;
            this.btnDatLich.Text = "Đặt Lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "GIAO DIỆN ĐẶT LỊCH";
            // 
            // nhuomToc
            // 
            this.nhuomToc.AutoSize = true;
            this.nhuomToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhuomToc.Location = new System.Drawing.Point(179, 253);
            this.nhuomToc.Name = "nhuomToc";
            this.nhuomToc.Size = new System.Drawing.Size(130, 28);
            this.nhuomToc.TabIndex = 11;
            this.nhuomToc.Text = "Nhuộm Tóc";
            this.nhuomToc.UseVisualStyleBackColor = true;
            // 
            // uToc
            // 
            this.uToc.AutoSize = true;
            this.uToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uToc.Location = new System.Drawing.Point(179, 219);
            this.uToc.Name = "uToc";
            this.uToc.Size = new System.Drawing.Size(80, 28);
            this.uToc.TabIndex = 10;
            this.uToc.Text = "Ủ Tóc";
            this.uToc.UseVisualStyleBackColor = true;
            // 
            // catTocNu
            // 
            this.catTocNu.AutoSize = true;
            this.catTocNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTocNu.Location = new System.Drawing.Point(179, 185);
            this.catTocNu.Name = "catTocNu";
            this.catTocNu.Size = new System.Drawing.Size(124, 28);
            this.catTocNu.TabIndex = 9;
            this.catTocNu.Text = "Cắt Tóc Nữ";
            this.catTocNu.UseVisualStyleBackColor = true;
            // 
            // catTocNam
            // 
            this.catTocNam.AutoSize = true;
            this.catTocNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTocNam.Location = new System.Drawing.Point(179, 151);
            this.catTocNam.Name = "catTocNam";
            this.catTocNam.Size = new System.Drawing.Size(139, 28);
            this.catTocNam.TabIndex = 8;
            this.catTocNam.Text = "Cắt Tóc Nam";
            this.catTocNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chọn Dịch Vụ:";
            // 
            // ngay
            // 
            this.ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngay.Location = new System.Drawing.Point(491, 155);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(143, 29);
            this.ngay.TabIndex = 13;
            // 
            // FormDatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nhuomToc);
            this.Controls.Add(this.uToc);
            this.Controls.Add(this.catTocNu);
            this.Controls.Add(this.catTocNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.diaDiem);
            this.Controls.Add(this.gio);
            this.Name = "FormDatLich";
            this.Text = "FormDatLich";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox gio;
        private System.Windows.Forms.ComboBox diaDiem;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox nhuomToc;
        private System.Windows.Forms.CheckBox uToc;
        private System.Windows.Forms.CheckBox catTocNu;
        private System.Windows.Forms.CheckBox catTocNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngay;
    }
}