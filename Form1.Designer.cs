namespace Water_Bills
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ExitButton = new Button();
            ManageInvocesMenuButton = new Button();
            AddInvoiceMenuButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            addInvoiceUserControl = new AddInvoiceUserControl();
            managenvoiceUserControl = new ManagenvoiceUserControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(ManageInvocesMenuButton);
            panel1.Controls.Add(AddInvoiceMenuButton);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 519);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(0, 426);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(203, 53);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ManageInvocesMenuButton
            // 
            ManageInvocesMenuButton.Location = new Point(3, 197);
            ManageInvocesMenuButton.Name = "ManageInvocesMenuButton";
            ManageInvocesMenuButton.Size = new Size(200, 65);
            ManageInvocesMenuButton.TabIndex = 2;
            ManageInvocesMenuButton.Text = "Manage Invoices";
            ManageInvocesMenuButton.UseVisualStyleBackColor = true;
            ManageInvocesMenuButton.Click += ManageInvocesMenuButton_Click;
            // 
            // AddInvoiceMenuButton
            // 
            AddInvoiceMenuButton.Location = new Point(3, 125);
            AddInvoiceMenuButton.Name = "AddInvoiceMenuButton";
            AddInvoiceMenuButton.Size = new Size(200, 61);
            AddInvoiceMenuButton.TabIndex = 1;
            AddInvoiceMenuButton.Text = "Add Invoice";
            AddInvoiceMenuButton.UseVisualStyleBackColor = true;
            AddInvoiceMenuButton.Click += AddInvoiceMenuButton_Click;
            // 
            // addInvoiceUserControl
            // 
            addInvoiceUserControl.Location = new Point(198, 0);
            addInvoiceUserControl.Name = "addInvoiceUserControl";
            addInvoiceUserControl.Size = new Size(648, 508);
            addInvoiceUserControl.TabIndex = 1;
            // 
            // managenvoiceUserControl
            // 
            managenvoiceUserControl.Location = new Point(188, 3);
            managenvoiceUserControl.Name = "managenvoiceUserControl";
            managenvoiceUserControl.Size = new Size(604, 545);
            managenvoiceUserControl.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 475);
            Controls.Add(managenvoiceUserControl);
            Controls.Add(addInvoiceUserControl);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ExitButton;
        private Button ManageInvocesMenuButton;
        private Button AddInvoiceMenuButton;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AddInvoiceUserControl addInvoiceUserControl;
        private ManagenvoiceUserControl managenvoiceUserControl1;
        private ManagenvoiceUserControl managenvoiceUserControl;
    }
}
