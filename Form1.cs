namespace abstract_Buoi8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVienIT sinhVienIT = new SinhVienIT();
            sinhVienIT.diemjava = double.Parse(txt_diemjava.Text);
            sinhVienIT.diemcss = double.Parse(txt_diemcss.Text + " " + sinhVienIT.xeploai());

            MessageBox.Show(sinhVienIT.getdiemtb().ToString());


        }

        private void SinhVienBiz_Click(object sender, EventArgs e)
        {
            SinhVienBiz sinhvienbiz = new SinhVienBiz();
            sinhvienbiz.ketoan = double.Parse(txt_Ketoan.Text);
            sinhvienbiz.Maketting = double.Parse(txt_maketting.Text);
            sinhvienbiz.Banhang = double.Parse(txt_banhang.Text + " " +sinhvienbiz.xeploai());

            MessageBox.Show(sinhvienbiz.getdiemtb().ToString());
        }
    }
}
