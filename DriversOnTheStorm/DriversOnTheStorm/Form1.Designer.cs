namespace DriversOnTheStorm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeviceList = new System.Windows.Forms.ListView();
            this.DeviceInfo = new System.Windows.Forms.TextBox();
            this.DisableBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceList
            // 
            this.DeviceList.FullRowSelect = true;
            this.DeviceList.Location = new System.Drawing.Point(0, 12);
            this.DeviceList.MultiSelect = false;
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(478, 450);
            this.DeviceList.TabIndex = 4;
            this.DeviceList.TileSize = new System.Drawing.Size(470, 36);
            this.DeviceList.UseCompatibleStateImageBehavior = false;
            this.DeviceList.View = System.Windows.Forms.View.Tile;
            this.DeviceList.SelectedIndexChanged += new System.EventHandler(this.DeviceList_SelectedIndexChanged);
            this.DeviceList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeviceList_MouseClick);
            // 
            // DeviceInfo
            // 
            this.DeviceInfo.Location = new System.Drawing.Point(495, 12);
            this.DeviceInfo.Multiline = true;
            this.DeviceInfo.Name = "DeviceInfo";
            this.DeviceInfo.Size = new System.Drawing.Size(447, 347);
            this.DeviceInfo.TabIndex = 1;
            // 
            // DisableBt
            // 
            this.DisableBt.Location = new System.Drawing.Point(786, 390);
            this.DisableBt.Name = "DisableBt";
            this.DisableBt.Size = new System.Drawing.Size(156, 55);
            this.DisableBt.TabIndex = 2;
            this.DisableBt.Text = "Disable";
            this.DisableBt.UseVisualStyleBackColor = true;
            this.DisableBt.Click += new System.EventHandler(this.DisableB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 474);
            this.Controls.Add(this.DisableBt);
            this.Controls.Add(this.DeviceInfo);
            this.Controls.Add(this.DeviceList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DeviceList;
        private System.Windows.Forms.TextBox DeviceInfo;
        private System.Windows.Forms.Button DisableBt;
    }
}

