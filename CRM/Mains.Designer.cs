namespace CRM
{
    partial class Mains
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
            Debug.Log("##################################Exit##################################");
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mains));
            this.nTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.bClient = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nTray
            // 
            this.nTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nTray.Icon")));
            this.nTray.Text = "REOTEK";
            this.nTray.Visible = true;
            this.nTray.DoubleClick += new System.EventHandler(this.nTray_DoubleClick);
            // 
            // bClient
            // 
            this.bClient.Location = new System.Drawing.Point(13, 13);
            this.bClient.Name = "bClient";
            this.bClient.Size = new System.Drawing.Size(75, 23);
            this.bClient.TabIndex = 0;
            this.bClient.Text = "Клиенты";
            this.bClient.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(13, 269);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // Mains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 301);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClient);
            this.Name = "Mains";
            this.Text = "REOTEK CRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mains_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nTray;
        private System.Windows.Forms.Button bClient;
        private System.Windows.Forms.Button bExit;
    }
}

