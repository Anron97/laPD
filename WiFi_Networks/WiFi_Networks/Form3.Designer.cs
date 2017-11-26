namespace WiFi_Networks
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.addressF = new System.Windows.Forms.TextBox();
            this.Ping = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address: ";
            // 
            // addressF
            // 
            this.addressF.Location = new System.Drawing.Point(110, 37);
            this.addressF.Name = "addressF";
            this.addressF.Size = new System.Drawing.Size(211, 22);
            this.addressF.TabIndex = 1;
            // 
            // Ping
            // 
            this.Ping.Location = new System.Drawing.Point(227, 65);
            this.Ping.Name = "Ping";
            this.Ping.Size = new System.Drawing.Size(94, 34);
            this.Ping.TabIndex = 2;
            this.Ping.Text = "Ping";
            this.Ping.UseVisualStyleBackColor = true;
            this.Ping.Click += new System.EventHandler(this.Ping_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(27, 122);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(294, 135);
            this.outputText.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 317);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.Ping);
            this.Controls.Add(this.addressF);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressF;
        private System.Windows.Forms.Button Ping;
        private System.Windows.Forms.TextBox outputText;
    }
}