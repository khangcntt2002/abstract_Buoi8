namespace abstract_Buoi8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SinhVienBiz = new Button();
            SinhVien = new Button();
            txt_Ketoan = new TextBox();
            txt_diemjava = new TextBox();
            txt_diemcss = new TextBox();
            txt_banhang = new TextBox();
            txt_maketting = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 131);
            button1.Name = "button1";
            button1.Size = new Size(159, 62);
            button1.TabIndex = 1;
            button1.Text = "SinhVienIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SinhVienBiz
            // 
            SinhVienBiz.Location = new Point(361, 128);
            SinhVienBiz.Name = "SinhVienBiz";
            SinhVienBiz.Size = new Size(159, 62);
            SinhVienBiz.TabIndex = 1;
            SinhVienBiz.Text = "SinhVienBiz";
            SinhVienBiz.UseVisualStyleBackColor = true;
            SinhVienBiz.Click += SinhVienBiz_Click;
            // 
            // SinhVien
            // 
            SinhVien.Location = new Point(202, 60);
            SinhVien.Name = "SinhVien";
            SinhVien.Size = new Size(159, 62);
            SinhVien.TabIndex = 1;
            SinhVien.Text = "SinhViên";
            SinhVien.UseVisualStyleBackColor = true;
            // 
            // txt_Ketoan
            // 
            txt_Ketoan.Location = new Point(390, 207);
            txt_Ketoan.Name = "txt_Ketoan";
            txt_Ketoan.Size = new Size(100, 35);
            txt_Ketoan.TabIndex = 2;
            // 
            // txt_diemjava
            // 
            txt_diemjava.Location = new Point(41, 240);
            txt_diemjava.Name = "txt_diemjava";
            txt_diemjava.Size = new Size(100, 35);
            txt_diemjava.TabIndex = 2;
            // 
            // txt_diemcss
            // 
            txt_diemcss.Location = new Point(41, 293);
            txt_diemcss.Name = "txt_diemcss";
            txt_diemcss.Size = new Size(100, 35);
            txt_diemcss.TabIndex = 2;
            // 
            // txt_banhang
            // 
            txt_banhang.Location = new Point(390, 300);
            txt_banhang.Name = "txt_banhang";
            txt_banhang.Size = new Size(100, 35);
            txt_banhang.TabIndex = 2;
            // 
            // txt_maketting
            // 
            txt_maketting.Location = new Point(390, 248);
            txt_maketting.Name = "txt_maketting";
            txt_maketting.Size = new Size(100, 35);
            txt_maketting.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 378);
            Controls.Add(txt_diemcss);
            Controls.Add(txt_diemjava);
            Controls.Add(txt_banhang);
            Controls.Add(txt_maketting);
            Controls.Add(txt_Ketoan);
            Controls.Add(SinhVienBiz);
            Controls.Add(SinhVien);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button SinhVienBiz;
        private Button SinhVien;
        private TextBox txt_Ketoan;
        private TextBox txt_diemjava;
        private TextBox txt_diemcss;
        private TextBox txt_banhang;
        private TextBox txt_maketting;
    }
}
