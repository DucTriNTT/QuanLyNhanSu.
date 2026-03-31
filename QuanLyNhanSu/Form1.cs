namespace QuanLyNhanSu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox có tên là txtHoTen
            string hoTen = txtHoTen.Text;

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
            }
            else
            {
                // Thêm một dòng mới vào bảng dataGridView1
                dataGridView1.Rows.Add(hoTen, "Phòng nhân sự");
                MessageBox.Show("Đã thêm nhân viên: " + hoTen);

                // Xóa chữ trong ô để nhập người tiếp theo
                txtHoTen.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
