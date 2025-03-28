using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Bills
{
    public partial class AddInvoiceUserControl : UserControl
    {
        public AddInvoiceUserControl()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerID = CustomerIDInput.Text;
            string customerName = CustomerNameInput.Text;
            int thisMonthNumber = Convert.ToInt32(ThisMonthInput.Text);
            int lastMonthNumber = Convert.ToInt32(LastMonthInput.Text);
            string customerType = TypeOfCustomerInput.Text;
            int numberOfPeople = Convert.ToInt32(NumberOfPeopleInput.Text);
            double price = 0;
            double VATFee = 0;
            double envFee = 0;
            double subTotal = 0;
            double total = 0;
            int amountConsumtion = thisMonthNumber - lastMonthNumber;
            if (customerType == "Household customer")
            {
                double amountComsumtionPerPeople = amountConsumtion / numberOfPeople;
                if (amountComsumtionPerPeople >= 10)
                {
                    price = 5973;
                    envFee = 5973.30;
                }
                if (amountComsumtionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 7052.20;
                }
                if (amountComsumtionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 866.90;
                }
                if (amountComsumtionPerPeople < 30)
                {

                    price = 15959;
                    envFee = 1592.9;
                }
            }
            else if (customerType == "Production units")
            {

                price = 11615;
                envFee = 1161.5;
            }
            else if (customerType == "Administrative agency, public servies")
            {

                price = 9955;
                envFee = 995.5;
            }
            else if (customerType == "Business services")
            {
                price = 22068;
                envFee = 2206.8;
            }
            else
            {
                MessageBox.Show("Invalid Type of customer");
                return;
            }
            subTotal = (amountConsumtion * price) + envFee;
            VATFee = subTotal * 0.1;
            total = subTotal + VATFee;

            string invoiceId = DateTime.Now.ToFileTime().ToString();
            Invoice invoice = new Invoice(
                customerID,
                customerName,
                invoiceId,
                DateTime.Now,
                thisMonthNumber,
                lastMonthNumber,
                customerType,
                numberOfPeople,
                amountConsumtion,
                price, envFee, VATFee, subTotal, total
                );
            


        }
    }
}
      
