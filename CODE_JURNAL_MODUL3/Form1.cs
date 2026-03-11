namespace CODE_JURNAL_MODUL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSoal_Click(object sender, EventArgs e)
        {

        }

        // Event ini akan dijalankan ketika tombol A diklik oleh user
        private void btnA_Click(object sender, EventArgs e)
        {
            // Tombol A adalah jawaban yang benar
            // Jika user menekan tombol ini maka program akan menampilkan
            // pesan bahwa jawaban yang dipilih adalah benar
            lblOutput.Text = "Jawaban Anda Benar";
        }

        // Event ini dijalankan ketika tombol B diklik
        private void btnB_Click(object sender, EventArgs e)
        {
            // Jawaban B adalah jawaban yang salah
            // Program akan menampilkan pesan bahwa jawaban salah
            lblOutput.Text = "Jawaban Anda Salah";
        }

        // Event ini dijalankan ketika tombol C diklik
        private void btnC_Click(object sender, EventArgs e)
        {
            // Jawaban C juga merupakan jawaban yang salah
            // Maka program akan menampilkan pesan jawaban salah
            lblOutput.Text = "Jawaban Anda Salah";
        }

        // Event ini dijalankan ketika tombol D diklik
        private void btnD_Click(object sender, EventArgs e)
        {
            // Jawaban D juga salah
            // Output yang ditampilkan adalah jawaban salah
            lblOutput.Text = "Jawaban Anda Salah";
        }
    }
}
