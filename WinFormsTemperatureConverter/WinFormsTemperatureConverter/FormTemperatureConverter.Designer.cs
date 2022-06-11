namespace WinFormsApp2
{
    partial class Form_Converter
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
            this.textBox_Entry = new System.Windows.Forms.TextBox();
            this.button_FarenheitToCelsius = new System.Windows.Forms.Button();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_CelsiusToFarenheit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Entry
            // 
            this.textBox_Entry.Location = new System.Drawing.Point(152, 12);
            this.textBox_Entry.Name = "textBox_Entry";
            this.textBox_Entry.Size = new System.Drawing.Size(65, 23);
            this.textBox_Entry.TabIndex = 0;
            // 
            // button_FarenheitToCelsius
            // 
            this.button_FarenheitToCelsius.Location = new System.Drawing.Point(80, 59);
            this.button_FarenheitToCelsius.Name = "button_FarenheitToCelsius";
            this.button_FarenheitToCelsius.Size = new System.Drawing.Size(195, 23);
            this.button_FarenheitToCelsius.TabIndex = 3;
            this.button_FarenheitToCelsius.Text = "Convert Farenheit to celsius";
            this.button_FarenheitToCelsius.UseVisualStyleBackColor = true;
            this.button_FarenheitToCelsius.Click += new System.EventHandler(this.button_FarenheitToCelsius_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(152, 162);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(42, 15);
            this.label_Result.TabIndex = 4;
            this.label_Result.Text = "Result:";
            // 
            // button_CelsiusToFarenheit
            // 
            this.button_CelsiusToFarenheit.Location = new System.Drawing.Point(80, 99);
            this.button_CelsiusToFarenheit.Name = "button_CelsiusToFarenheit";
            this.button_CelsiusToFarenheit.Size = new System.Drawing.Size(195, 23);
            this.button_CelsiusToFarenheit.TabIndex = 5;
            this.button_CelsiusToFarenheit.Text = "Convert Celsius to FarenHeit";
            this.button_CelsiusToFarenheit.UseVisualStyleBackColor = true;
            this.button_CelsiusToFarenheit.Click += new System.EventHandler(this.button_CelsiusToFarenheit_Click);
            // 
            // Form_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 197);
            this.Controls.Add(this.button_CelsiusToFarenheit);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.button_FarenheitToCelsius);
            this.Controls.Add(this.textBox_Entry);
            this.Name = "Form_Converter";
            this.Text = "TemperatureDegreesConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Entry;
        private Button button_FarenheitToCelsius;
        private Label label_Result;
        private Button button_CelsiusToFarenheit;
    }
}