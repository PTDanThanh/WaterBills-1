namespace Water_Bills
{
    public partial class Form1 : Form
    {
        public ManageInvoices  FormListInvoice=new ManageInvoices();
        public Form1()
        {
            InitializeComponent();

            addInvoiceUserControl.Hide();
            managenvoiceUserControl.Hide();

            addInvoiceUserControl.ListInvoices = FormListInvoice;
            managenvoiceUserControl.ListInvoice = FormListInvoice;
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
            managenvoiceUserControl.Hide();
            AddInvoiceMenuButton.BackColor = Color.DarkGray;
            AddInvoiceMenuButton.ForeColor = Color.Black;

            AddInvoiceMenuButton.BackColor = Color.White;
            AddInvoiceMenuButton.ForeColor = Color.Black;
        }

        private void ManageInvocesMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Hide();
            managenvoiceUserControl.RefreshInvoiceList();
            managenvoiceUserControl.Show();

            AddInvoiceMenuButton.BackColor = Color.White;
            AddInvoiceMenuButton.ForeColor = Color.Black;

            AddInvoiceMenuButton.BackColor = Color.DarkGray;
            AddInvoiceMenuButton.ForeColor = Color.White;
        }

    }
}
