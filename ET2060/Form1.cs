namespace ET2060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                matkhau.PasswordChar = '\0'; 
            }
            else
            {
                matkhau.PasswordChar = '*'; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tendangnhap.Text) || string.IsNullOrEmpty(matkhau.Text))
            {
                MessageBox.Show("Chưa nhập tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tendangnhap.Text.Equals("admin") && matkhau.Text.Equals("admin123"))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 if (string.IsNullOrEmpty(tendangnhap.Text) || string.IsNullOrEmpty(matkhau.Text))
        {
            MessageBox.Show("Chưa nhập tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (tendangnhap.Text.Equals("admin") && matkhau.Text.Equals("admin123"))
        {
            MessageBox.Show("Đăng nhập thành công", "Thông báo");
        }
        else
        {
            MessageBox.Show("Đăng nhập thất bại", "Thông báo");
        }
            }
        }
    }
}
