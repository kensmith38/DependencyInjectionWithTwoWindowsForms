namespace DependencyInjectionWithTwoWindowsForms
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
            textBoxNextNumber = new TextBox();
            label3 = new Label();
            buttonLaunchForm2 = new Button();
            label1 = new Label();
            textBoxSettingValue = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxNextNumber
            // 
            textBoxNextNumber.Location = new Point(238, 131);
            textBoxNextNumber.Name = "textBoxNextNumber";
            textBoxNextNumber.ReadOnly = true;
            textBoxNextNumber.Size = new Size(55, 23);
            textBoxNextNumber.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 134);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 11;
            label3.Text = "Value of next number:";
            // 
            // buttonLaunchForm2
            // 
            buttonLaunchForm2.Location = new Point(196, 198);
            buttonLaunchForm2.Name = "buttonLaunchForm2";
            buttonLaunchForm2.Size = new Size(140, 23);
            buttonLaunchForm2.TabIndex = 8;
            buttonLaunchForm2.Text = "Launch Form2";
            buttonLaunchForm2.UseVisualStyleBackColor = true;
            buttonLaunchForm2.Click += buttonLaunchForm2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 7;
            label1.Text = "This is Form1";
            // 
            // textBoxSettingValue
            // 
            textBoxSettingValue.Location = new Point(238, 57);
            textBoxSettingValue.Name = "textBoxSettingValue";
            textBoxSettingValue.ReadOnly = true;
            textBoxSettingValue.Size = new Size(365, 23);
            textBoxSettingValue.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 60);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 13;
            label2.Text = "Value of config setting, MyTestKey:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkViolet;
            label4.Location = new Point(238, 39);
            label4.Name = "label4";
            label4.Size = new Size(271, 15);
            label4.TabIndex = 15;
            label4.Text = "Using DI for IConfiguration (appsettings.json, etc.)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkViolet;
            label5.Location = new Point(238, 113);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 16;
            label5.Text = "Using DI for IGetNextNumber";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 259);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxSettingValue);
            Controls.Add(label2);
            Controls.Add(textBoxNextNumber);
            Controls.Add(label3);
            Controls.Add(buttonLaunchForm2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNextNumber;
        private Label label3;
        private Button buttonLaunchForm2;
        private Label label1;
        private TextBox textBoxSettingValue;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}
