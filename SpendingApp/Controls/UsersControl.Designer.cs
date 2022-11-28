namespace SpendingApp.Controls
{
    partial class UsersControl
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
            this._lblName = new System.Windows.Forms.Label();
            this._lblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblName.Location = new System.Drawing.Point(41, 18);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(56, 21);
            this._lblName.TabIndex = 2;
            this._lblName.Text = "Name";
            // 
            // _lblSurname
            // 
            this._lblSurname.AutoSize = true;
            this._lblSurname.BackColor = System.Drawing.SystemColors.Control;
            this._lblSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblSurname.Location = new System.Drawing.Point(132, 18);
            this._lblSurname.Name = "_lblSurname";
            this._lblSurname.Size = new System.Drawing.Size(78, 21);
            this._lblSurname.TabIndex = 3;
            this._lblSurname.Text = "Surname";
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this._lblSurname);
            this.Controls.Add(this._lblName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(234, 54);
            this.Load += new System.EventHandler(this.UsersControl_Load);
            this.Click += new System.EventHandler(this.UsersControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label _lblName;
        private Label _lblSurname;
    }
}
