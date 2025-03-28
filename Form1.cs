namespace Water_Bills
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addInvoiceUserControl.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddInvoiceMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Show();
            AddInvoiceMenuButton.BackColor = Color.DarkBlue;
            AddInvoiceMenuButton. ForeColor = Color.Black;   
        }
    }
}
