namespace TemperatureConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conversionBox = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature:";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(283, 34);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(76, 26);
            this.tempBox.TabIndex = 1;
            this.tempBox.TextChanged += new System.EventHandler(this.tempBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conversion:";
            // 
            // conversionBox
            // 
            this.conversionBox.Location = new System.Drawing.Point(283, 221);
            this.conversionBox.Name = "conversionBox";
            this.conversionBox.ReadOnly = true;
            this.conversionBox.Size = new System.Drawing.Size(76, 26);
            this.conversionBox.TabIndex = 3;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(26, 119);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(180, 46);
            this.btnFahrenheit.TabIndex = 4;
            this.btnFahrenheit.Text = "Convert to Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(239, 119);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(173, 46);
            this.btnCelsius.TabIndex = 5;
            this.btnCelsius.Text = "Convert to Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 274);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.conversionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox conversionBox;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
    }
}

