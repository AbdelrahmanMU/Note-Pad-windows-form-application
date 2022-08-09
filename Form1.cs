namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello welcom", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("copy occure");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("opend");
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            frm_info f = new frm_info(int.Parse(txt_id.Text));
            f.Show();
        }
    }
}