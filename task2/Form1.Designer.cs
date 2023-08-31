namespace task2
{
    partial class Form1
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
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonName = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(40, 25);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(134, 20);
            this.textBoxMoney.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(40, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(134, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(40, 180);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(134, 20);
            this.textBoxPercent.TabIndex = 2;
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(40, 52);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(75, 23);
            this.buttonMoney.TabIndex = 3;
            this.buttonMoney.Text = "Изменить";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonName
            // 
            this.buttonName.Location = new System.Drawing.Point(40, 132);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(75, 23);
            this.buttonName.TabIndex = 4;
            this.buttonName.Text = "Изменить";
            this.buttonName.UseVisualStyleBackColor = true;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(40, 207);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(75, 23);
            this.buttonPercent.TabIndex = 5;
            this.buttonPercent.Text = "Изменить";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 255);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonName);
            this.Controls.Add(this.buttonMoney);
            this.Controls.Add(this.textBoxPercent);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxMoney);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPercent;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Button buttonPercent;
    }
}

