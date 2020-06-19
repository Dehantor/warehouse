namespace Warehouse
{
    partial class FormAccept
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
            this.ассеptButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название товара";
            // 
            // ассеptButton
            // 
            this.ассеptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ассеptButton.Location = new System.Drawing.Point(405, 204);
            this.ассеptButton.Name = "ассеptButton";
            this.ассеptButton.Size = new System.Drawing.Size(119, 38);
            this.ассеptButton.TabIndex = 1;
            this.ассеptButton.Text = "Принять";
            this.ассеptButton.UseVisualStyleBackColor = true;
            this.ассеptButton.Click += new System.EventHandler(this.АссеptButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(222, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(302, 30);
            this.NameTextBox.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(222, 93);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(302, 81);
            this.textBoxDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(273, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ассеptButton);
            this.Controls.Add(this.label1);
            this.Name = "FormAccept";
            this.Text = "FormAccept";
            this.Load += new System.EventHandler(this.FormAccept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ассеptButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}