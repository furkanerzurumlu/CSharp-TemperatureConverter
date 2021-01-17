namespace WindowsFormsApplication1
{
    partial class TemperatureConverter
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFahrenayt = new System.Windows.Forms.Button();
            this.btnSantigrad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(79, 56);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(123, 20);
            this.txtValue.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(79, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(123, 20);
            this.txtResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result : ";
            // 
            // btnFahrenayt
            // 
            this.btnFahrenayt.Location = new System.Drawing.Point(88, 104);
            this.btnFahrenayt.Name = "btnFahrenayt";
            this.btnFahrenayt.Size = new System.Drawing.Size(100, 23);
            this.btnFahrenayt.TabIndex = 4;
            this.btnFahrenayt.Text = "Fahrenayt";
            this.btnFahrenayt.UseVisualStyleBackColor = true;
            this.btnFahrenayt.Click += new System.EventHandler(this.btnFahrenayt_Click);
            // 
            // btnSantigrad
            // 
            this.btnSantigrad.Location = new System.Drawing.Point(88, 145);
            this.btnSantigrad.Name = "btnSantigrad";
            this.btnSantigrad.Size = new System.Drawing.Size(100, 23);
            this.btnSantigrad.TabIndex = 5;
            this.btnSantigrad.Text = "Santigrad";
            this.btnSantigrad.UseVisualStyleBackColor = true;
            this.btnSantigrad.Click += new System.EventHandler(this.btnSantigrad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temperature Converter";
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(267, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSantigrad);
            this.Controls.Add(this.btnFahrenayt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFahrenayt;
        private System.Windows.Forms.Button btnSantigrad;
        private System.Windows.Forms.Label label3;
    }
}

