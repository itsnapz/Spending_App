namespace SpendingApp.Forms
{
    partial class SpendDetailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblName = new System.Windows.Forms.Label();
            this._lblSurname = new System.Windows.Forms.Label();
            this._pnlSpend = new System.Windows.Forms.Panel();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtPrice = new System.Windows.Forms.TextBox();
            this._checkPaid = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblName.Location = new System.Drawing.Point(401, -1);
            this._lblName.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this._lblName.Name = "_lblName";
            this._lblName.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this._lblName.Size = new System.Drawing.Size(116, 32);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Matyáš";
            // 
            // _lblSurname
            // 
            this._lblSurname.AutoSize = true;
            this._lblSurname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblSurname.Location = new System.Drawing.Point(500, -1);
            this._lblSurname.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this._lblSurname.Name = "_lblSurname";
            this._lblSurname.Size = new System.Drawing.Size(113, 32);
            this._lblSurname.TabIndex = 2;
            this._lblSurname.Text = "Novotný";
            // 
            // _pnlSpend
            // 
            this._pnlSpend.AutoScroll = true;
            this._pnlSpend.Location = new System.Drawing.Point(273, 34);
            this._pnlSpend.Name = "_pnlSpend";
            this._pnlSpend.Size = new System.Drawing.Size(515, 404);
            this._pnlSpend.TabIndex = 3;
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(12, 57);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 23);
            this._txtName.TabIndex = 4;
            // 
            // _txtPrice
            // 
            this._txtPrice.Location = new System.Drawing.Point(12, 108);
            this._txtPrice.Name = "_txtPrice";
            this._txtPrice.Size = new System.Drawing.Size(100, 23);
            this._txtPrice.TabIndex = 5;
            // 
            // _checkPaid
            // 
            this._checkPaid.AutoSize = true;
            this._checkPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._checkPaid.Location = new System.Drawing.Point(11, 142);
            this._checkPaid.Name = "_checkPaid";
            this._checkPaid.Size = new System.Drawing.Size(58, 24);
            this._checkPaid.TabIndex = 8;
            this._checkPaid.Text = "Paid";
            this._checkPaid.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // _btnSend
            // 
            this._btnSend.Location = new System.Drawing.Point(11, 172);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(75, 23);
            this._btnSend.TabIndex = 13;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            this._btnSend.Click += new System.EventHandler(this._btnSend_Click);
            // 
            // SpendDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._checkPaid);
            this.Controls.Add(this._txtPrice);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._pnlSpend);
            this.Controls.Add(this._lblSurname);
            this.Controls.Add(this._lblName);
            this.Name = "SpendDetailForm";
            this.Text = "SpendDetailForm";
            this.Load += new System.EventHandler(this.SpendDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblName;
        private Label _lblSurname;
        private Panel _pnlSpend;
        private TextBox _txtName;
        private TextBox _txtPrice;
        private CheckBox _checkPaid;
        private Label label2;
        private Label label3;
        private Button _btnSend;
    }
}