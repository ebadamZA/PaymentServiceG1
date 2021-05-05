
namespace PaymentServiceG1
{
    partial class frmCapturePayment
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
            this.txbOrderID = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.txbReference = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.txbCurrency = new System.Windows.Forms.TextBox();
            this.txbChange = new System.Windows.Forms.TextBox();
            this.txbTendered = new System.Windows.Forms.TextBox();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.txbProvider = new System.Windows.Forms.TextBox();
            this.txbLastFour = new System.Windows.Forms.TextBox();
            this.txbHolder = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlCash.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbOrderID
            // 
            this.txbOrderID.Location = new System.Drawing.Point(150, 54);
            this.txbOrderID.Name = "txbOrderID";
            this.txbOrderID.PlaceholderText = "Order ID";
            this.txbOrderID.Size = new System.Drawing.Size(200, 23);
            this.txbOrderID.TabIndex = 0;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(150, 145);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.PlaceholderText = "Amount";
            this.txbAmount.Size = new System.Drawing.Size(200, 23);
            this.txbAmount.TabIndex = 2;
            // 
            // txbReference
            // 
            this.txbReference.Location = new System.Drawing.Point(150, 186);
            this.txbReference.Name = "txbReference";
            this.txbReference.PlaceholderText = "Reference";
            this.txbReference.Size = new System.Drawing.Size(200, 23);
            this.txbReference.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(150, 102);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 4;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.cmbType.Location = new System.Drawing.Point(150, 230);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 23);
            this.cmbType.TabIndex = 5;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.txbCurrency);
            this.pnlCash.Controls.Add(this.txbChange);
            this.pnlCash.Controls.Add(this.txbTendered);
            this.pnlCash.Location = new System.Drawing.Point(458, 44);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(276, 124);
            this.pnlCash.TabIndex = 6;
            this.pnlCash.Visible = false;
            // 
            // txbCurrency
            // 
            this.txbCurrency.Location = new System.Drawing.Point(82, 90);
            this.txbCurrency.Name = "txbCurrency";
            this.txbCurrency.PlaceholderText = "Currency";
            this.txbCurrency.Size = new System.Drawing.Size(100, 23);
            this.txbCurrency.TabIndex = 2;
            // 
            // txbChange
            // 
            this.txbChange.Location = new System.Drawing.Point(82, 49);
            this.txbChange.Name = "txbChange";
            this.txbChange.PlaceholderText = "Change";
            this.txbChange.Size = new System.Drawing.Size(100, 23);
            this.txbChange.TabIndex = 1;
            // 
            // txbTendered
            // 
            this.txbTendered.Location = new System.Drawing.Point(82, 9);
            this.txbTendered.Name = "txbTendered";
            this.txbTendered.PlaceholderText = "Tendered";
            this.txbTendered.Size = new System.Drawing.Size(100, 23);
            this.txbTendered.TabIndex = 0;
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.txbProvider);
            this.pnlCard.Controls.Add(this.txbLastFour);
            this.pnlCard.Controls.Add(this.txbHolder);
            this.pnlCard.Location = new System.Drawing.Point(458, 218);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(276, 118);
            this.pnlCard.TabIndex = 7;
            this.pnlCard.Visible = false;
            // 
            // txbProvider
            // 
            this.txbProvider.Location = new System.Drawing.Point(88, 88);
            this.txbProvider.Name = "txbProvider";
            this.txbProvider.PlaceholderText = "Provider";
            this.txbProvider.Size = new System.Drawing.Size(100, 23);
            this.txbProvider.TabIndex = 5;
            // 
            // txbLastFour
            // 
            this.txbLastFour.Location = new System.Drawing.Point(88, 47);
            this.txbLastFour.Name = "txbLastFour";
            this.txbLastFour.PlaceholderText = "Last 4 digits";
            this.txbLastFour.Size = new System.Drawing.Size(100, 23);
            this.txbLastFour.TabIndex = 4;
            // 
            // txbHolder
            // 
            this.txbHolder.Location = new System.Drawing.Point(88, 7);
            this.txbHolder.Name = "txbHolder";
            this.txbHolder.PlaceholderText = "Holder";
            this.txbHolder.Size = new System.Drawing.Size(100, 23);
            this.txbHolder.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(229, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmCapturePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 414);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txbReference);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.txbOrderID);
            this.Name = "frmCapturePayment";
            this.Text = "Form1";
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOrderID;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.TextBox txbReference;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.TextBox txbCurrency;
        private System.Windows.Forms.TextBox txbChange;
        private System.Windows.Forms.TextBox txbTendered;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TextBox txbProvider;
        private System.Windows.Forms.TextBox txbLastFour;
        private System.Windows.Forms.TextBox txbHolder;
        private System.Windows.Forms.Button btnSubmit;
    }
}

