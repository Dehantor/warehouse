namespace Warehouse
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonHouse = new System.Windows.Forms.Button();
            this.buttonSold = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(61, 48);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(129, 54);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonHouse
            // 
            this.buttonHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHouse.Location = new System.Drawing.Point(61, 125);
            this.buttonHouse.Name = "buttonHouse";
            this.buttonHouse.Size = new System.Drawing.Size(129, 56);
            this.buttonHouse.TabIndex = 1;
            this.buttonHouse.Text = "На склад";
            this.buttonHouse.UseVisualStyleBackColor = true;
            this.buttonHouse.Click += new System.EventHandler(this.ButtonHouse_Click);
            // 
            // buttonSold
            // 
            this.buttonSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSold.Location = new System.Drawing.Point(61, 203);
            this.buttonSold.Name = "buttonSold";
            this.buttonSold.Size = new System.Drawing.Size(129, 65);
            this.buttonSold.TabIndex = 2;
            this.buttonSold.Text = "Продан";
            this.buttonSold.UseVisualStyleBackColor = true;
            this.buttonSold.Click += new System.EventHandler(this.ButtonSold_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReport.Location = new System.Drawing.Point(61, 296);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(129, 65);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "Отчёт";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 395);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonSold);
            this.Controls.Add(this.buttonHouse);
            this.Controls.Add(this.buttonAccept);
            this.Name = "Form1";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonHouse;
        private System.Windows.Forms.Button buttonSold;
        private System.Windows.Forms.Button buttonReport;
    }
}

