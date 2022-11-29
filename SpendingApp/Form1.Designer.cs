namespace SpendingApp
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
            this._pnlUsers = new System.Windows.Forms.Panel();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtSurname = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _pnlUsers
            // 
            this._pnlUsers.AutoScroll = true;
            this._pnlUsers.Location = new System.Drawing.Point(0, 65);
            this._pnlUsers.Name = "_pnlUsers";
            this._pnlUsers.Size = new System.Drawing.Size(542, 385);
            this._pnlUsers.TabIndex = 0;
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(608, 83);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(151, 23);
            this._txtName.TabIndex = 1;
            // 
            // _txtSurname
            // 
            this._txtSurname.Location = new System.Drawing.Point(608, 135);
            this._txtSurname.Name = "_txtSurname";
            this._txtSurname.Size = new System.Drawing.Size(151, 23);
            this._txtSurname.TabIndex = 2;
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(608, 191);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(151, 23);
            this._txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(608, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(608, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(650, 240);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 7;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(608, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "🆕Add user🆕";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(198, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "⛄List of users⛄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this._txtSurname);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._pnlUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel _pnlUsers;
        private TextBox _txtName;
        private TextBox _txtSurname;
        private TextBox _txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button _btnAdd;
        private Label label4;
        private Label label5;
    }
}