namespace WiFi_Networks
{
    partial class Form2
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.ErrorL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.CausesValidation = false;
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(271, 145);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(87, 171);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(196, 22);
            this.PasswordInput.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 174);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(155, 211);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(128, 38);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.ConnectBt_MouseClick);
            // 
            // ErrorL
            // 
            this.ErrorL.AutoSize = true;
            this.ErrorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorL.ForeColor = System.Drawing.Color.Red;
            this.ErrorL.Location = new System.Drawing.Point(29, 215);
            this.ErrorL.Name = "ErrorL";
            this.ErrorL.Size = new System.Drawing.Size(66, 25);
            this.ErrorL.TabIndex = 5;
            this.ErrorL.Text = "Error!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 261);
            this.Controls.Add(this.ErrorL);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.textBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label ErrorL;
    }
}