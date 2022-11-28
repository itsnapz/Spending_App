namespace SpendingApp.Controls
{
    partial class SpendControl
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
            this._lblSpendName = new System.Windows.Forms.Label();
            this._lblPrice = new System.Windows.Forms.Label();
            this._checkIsPaid = new System.Windows.Forms.CheckBox();
            this._lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblSpendName
            // 
            this._lblSpendName.AutoSize = true;
            this._lblSpendName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblSpendName.Location = new System.Drawing.Point(14, 15);
            this._lblSpendName.Name = "_lblSpendName";
            this._lblSpendName.Size = new System.Drawing.Size(39, 15);
            this._lblSpendName.TabIndex = 0;
            this._lblSpendName.Text = "Name";
            // 
            // _lblPrice
            // 
            this._lblPrice.AutoSize = true;
            this._lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblPrice.Location = new System.Drawing.Point(101, 15);
            this._lblPrice.Name = "_lblPrice";
            this._lblPrice.Size = new System.Drawing.Size(33, 15);
            this._lblPrice.TabIndex = 1;
            this._lblPrice.Text = "Price";
            // 
            // _checkIsPaid
            // 
            this._checkIsPaid.AutoSize = true;
            this._checkIsPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._checkIsPaid.Location = new System.Drawing.Point(182, 14);
            this._checkIsPaid.Name = "_checkIsPaid";
            this._checkIsPaid.Size = new System.Drawing.Size(49, 19);
            this._checkIsPaid.TabIndex = 2;
            this._checkIsPaid.Text = "Paid";
            this._checkIsPaid.UseVisualStyleBackColor = true;
            this._checkIsPaid.CheckedChanged += new System.EventHandler(this._checkIsPaid_CheckedChanged);
            // 
            // _lblDate
            // 
            this._lblDate.AutoSize = true;
            this._lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblDate.Location = new System.Drawing.Point(268, 15);
            this._lblDate.Name = "_lblDate";
            this._lblDate.Size = new System.Drawing.Size(32, 15);
            this._lblDate.TabIndex = 3;
            this._lblDate.Text = "Date";
            // 
            // SpendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblDate);
            this.Controls.Add(this._checkIsPaid);
            this.Controls.Add(this._lblPrice);
            this.Controls.Add(this._lblSpendName);
            this.Name = "SpendControl";
            this.Size = new System.Drawing.Size(375, 46);
            this.Load += new System.EventHandler(this.SpendControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblSpendName;
        private Label _lblPrice;
        private CheckBox _checkIsPaid;
        private Label _lblDate;
    }
}
