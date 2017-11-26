namespace WiFi_Networks
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
            this.components = new System.ComponentModel.Container();
            this.NetworkList = new System.Windows.Forms.ListView();
            this.Signal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Network_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pingBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NetworkList
            // 
            this.NetworkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Signal,
            this.Network_name});
            this.NetworkList.FullRowSelect = true;
            this.NetworkList.Location = new System.Drawing.Point(10, 12);
            this.NetworkList.Name = "NetworkList";
            this.NetworkList.Size = new System.Drawing.Size(299, 396);
            this.NetworkList.TabIndex = 0;
            this.NetworkList.UseCompatibleStateImageBehavior = false;
            this.NetworkList.View = System.Windows.Forms.View.Details;
            this.NetworkList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NetworkList_DoubleMouseClick);
            // 
            // Signal
            // 
            this.Signal.Text = "Signal";
            // 
            // Network_name
            // 
            this.Network_name.Text = "Name";
            this.Network_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Network_name.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pingBt
            // 
            this.pingBt.Location = new System.Drawing.Point(12, 414);
            this.pingBt.Name = "pingBt";
            this.pingBt.Size = new System.Drawing.Size(111, 29);
            this.pingBt.TabIndex = 1;
            this.pingBt.Text = "Ping";
            this.pingBt.UseVisualStyleBackColor = true;
            this.pingBt.Click += new System.EventHandler(this.pingBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 455);
            this.Controls.Add(this.pingBt);
            this.Controls.Add(this.NetworkList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView NetworkList;
        private System.Windows.Forms.ColumnHeader Signal;
        private System.Windows.Forms.ColumnHeader Network_name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pingBt;
    }
}

