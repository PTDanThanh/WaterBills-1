namespace Water_Bills
{
    partial class AddInvoiceUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label01 = new Label();
            label3 = new Label();
            label4 = new Label();
            label = new Label();
            label6 = new Label();
            label7 = new Label();
            CustomerIDInput = new TextBox();
            ThisMonthInput = new TextBox();
            NumberOfPeopleInput = new TextBox();
            LastMonthInput = new TextBox();
            CustomerNameInput = new TextBox();
            button1 = new Button();
            TypeOfCustomerInput = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 0;
            label1.Text = "Add an Invoice";
            // 
            // label01
            // 
            label01.AutoSize = true;
            label01.Font = new Font("Segoe UI", 12F);
            label01.Location = new Point(23, 70);
            label01.Name = "label01";
            label01.Size = new Size(97, 21);
            label01.TabIndex = 1;
            label01.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 167);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 2;
            label3.Text = "Type of Custumer";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 120);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 3;
            label4.Text = "This Month Number";
            label4.Click += label4_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.Location = new Point(222, 70);
            label.Name = "label";
            label.Size = new Size(124, 21);
            label.TabIndex = 4;
            label.Text = "Customer Name";
            label.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(222, 120);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 5;
            label6.Text = "Last Month Number";
            label6.Click += label6_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(222, 167);
            label7.Name = "label7";
            label7.Size = new Size(137, 21);
            label7.TabIndex = 6;
            label7.Text = "Number of people";
            label7.Click += label7_Click_1;
            // 
            // CustomerIDInput
            // 
            CustomerIDInput.Location = new Point(23, 94);
            CustomerIDInput.Name = "CustomerIDInput";
            CustomerIDInput.Size = new Size(150, 23);
            CustomerIDInput.TabIndex = 7;
            // 
            // ThisMonthInput
            // 
            ThisMonthInput.Location = new Point(23, 141);
            ThisMonthInput.Name = "ThisMonthInput";
            ThisMonthInput.Size = new Size(150, 23);
            ThisMonthInput.TabIndex = 8;
            // 
            // NumberOfPeopleInput
            // 
            NumberOfPeopleInput.Location = new Point(222, 191);
            NumberOfPeopleInput.Name = "NumberOfPeopleInput";
            NumberOfPeopleInput.Size = new Size(137, 23);
            NumberOfPeopleInput.TabIndex = 10;
            NumberOfPeopleInput.TextChanged += textBox4_TextChanged;
            // 
            // LastMonthInput
            // 
            LastMonthInput.Location = new Point(222, 144);
            LastMonthInput.Name = "LastMonthInput";
            LastMonthInput.Size = new Size(137, 23);
            LastMonthInput.TabIndex = 11;
            LastMonthInput.TextChanged += textBox5_TextChanged;
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(222, 94);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(137, 23);
            CustomerNameInput.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(254, 220);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 13;
            button1.Text = "Caculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TypeOfCustomerInput
            // 
            TypeOfCustomerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfCustomerInput.FormattingEnabled = true;
            TypeOfCustomerInput.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            TypeOfCustomerInput.Location = new Point(23, 191);
            TypeOfCustomerInput.Name = "TypeOfCustomerInput";
            TypeOfCustomerInput.Size = new Size(150, 23);
            TypeOfCustomerInput.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 235);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 250);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 16;
            label5.Text = "envFee:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 265);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 17;
            label8.Text = "VATFee:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(92, 250);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(92, 235);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(92, 265);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 289);
            label12.Name = "label12";
            label12.Size = new Size(52, 21);
            label12.TabIndex = 21;
            label12.Text = "Total:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(244, 271);
            label13.Name = "label13";
            label13.Size = new Size(0, 21);
            label13.TabIndex = 22;
            // 
            // AddInvoiceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(TypeOfCustomerInput);
            Controls.Add(button1);
            Controls.Add(CustomerNameInput);
            Controls.Add(LastMonthInput);
            Controls.Add(NumberOfPeopleInput);
            Controls.Add(ThisMonthInput);
            Controls.Add(CustomerIDInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label01);
            Controls.Add(label1);
            Name = "AddInvoiceUserControl";
            Size = new Size(400, 340);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label01;
        private Label label3;
        private Label label4;
        private Label label;
        private Label label6;
        private Label label7;
        private TextBox CustomerIDInput;
        private TextBox ThisMonthInput;
        private TextBox NumberOfPeopleInput;
        private TextBox LastMonthInput;
        private TextBox CustomerNameInput;
        private Button button1;
        private ComboBox TypeOfCustomerInput;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
