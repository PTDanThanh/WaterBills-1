namespace Water_Bills
{
    partial class ManagenvoiceUserControl
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
            invoicesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)invoicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // invoicesDataGridView
            // 
            invoicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoicesDataGridView.Location = new Point(3, 71);
            invoicesDataGridView.Name = "invoicesDataGridView";
            invoicesDataGridView.Size = new Size(621, 344);
            invoicesDataGridView.TabIndex = 0;
            // 
            // ManagenvoiceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(invoicesDataGridView);
            Name = "ManagenvoiceUserControl";
            Size = new Size(702, 499);
            ((System.ComponentModel.ISupportInitialize)invoicesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView invoicesDataGridView;
    }
}
