namespace DependencyInjectionWithTwoWindowsForms
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
            textBoxSettingValue = new TextBox();
            label2 = new Label();
            textBoxNextNumber = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxSettingValue
            // 
            textBoxSettingValue.Location = new Point(238, 53);
            textBoxSettingValue.Name = "textBoxSettingValue";
            textBoxSettingValue.ReadOnly = true;
            textBoxSettingValue.Size = new Size(365, 23);
            textBoxSettingValue.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 56);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 18;
            label2.Text = "Value of config setting, MyTestKey:";
            // 
            // textBoxNextNumber
            // 
            textBoxNextNumber.Location = new Point(238, 112);
            textBoxNextNumber.Name = "textBoxNextNumber";
            textBoxNextNumber.ReadOnly = true;
            textBoxNextNumber.Size = new Size(55, 23);
            textBoxNextNumber.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 115);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 16;
            label3.Text = "Value of next number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 15;
            label1.Text = "This is Form2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkViolet;
            label5.Location = new Point(238, 94);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 21;
            label5.Text = "Using DI for IGetNextNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkViolet;
            label4.Location = new Point(238, 35);
            label4.Name = "label4";
            label4.Size = new Size(271, 15);
            label4.TabIndex = 20;
            label4.Text = "Using DI for IConfiguration (appsettings.json, etc.)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkViolet;
            label6.Location = new Point(238, 167);
            label6.Name = "label6";
            label6.Size = new Size(182, 15);
            label6.TabIndex = 22;
            label6.Text = "Form2 will also use DI for ILogger";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 273);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxSettingValue);
            Controls.Add(label2);
            Controls.Add(textBoxNextNumber);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSettingValue;
        private Label label2;
        private TextBox textBoxNextNumber;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}