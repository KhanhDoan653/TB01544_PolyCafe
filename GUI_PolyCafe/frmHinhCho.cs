namespace GUI_PolyCafe
{
    public partial class frmHinhCho : Form
    {
        public ProgressBar progressBar; // Khai báo đúng kiểu dữ liệu

        public frmHinhCho()
        {
            InitializeComponent();

            // Khởi tạo progressBar nếu chưa có
            progressBarwelcome.Style = ProgressBarStyle.Marquee;
            // Tốc độ chạy của ProgressBar
            progressBarwelcome.Text = "Đang tải dữ liệu...";
            Task.Delay(3000).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    this.Dispose();
                }));
            });
        }



        private void frmHinhCho_Load(object sender, EventArgs e)
        {
            // Có thể thêm logic nếu cần
        }

        private void frmHinhCho_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ngăn chặn người dùng đóng ứng dụng
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
