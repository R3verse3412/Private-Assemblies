namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.txtBox_number1 = new System.Windows.Forms.TextBox();
            this.txtBox_number2 = new System.Windows.Forms.TextBox();
            this.txtBox_Results = new System.Windows.Forms.TextBox();
            this.cmBox_Operator = new System.Windows.Forms.ComboBox();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // txtBox_number1
            // 
            this.txtBox_number1.Location = new System.Drawing.Point(57, 107);
            this.txtBox_number1.Name = "txtBox_number1";
            this.txtBox_number1.Size = new System.Drawing.Size(226, 20);
            this.txtBox_number1.TabIndex = 1;
            // 
            // txtBox_number2
            // 
            this.txtBox_number2.Location = new System.Drawing.Point(57, 185);
            this.txtBox_number2.Name = "txtBox_number2";
            this.txtBox_number2.Size = new System.Drawing.Size(226, 20);
            this.txtBox_number2.TabIndex = 2;
            // 
            // txtBox_Results
            // 
            this.txtBox_Results.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBox_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Results.ForeColor = System.Drawing.Color.Lime;
            this.txtBox_Results.Location = new System.Drawing.Point(57, 222);
            this.txtBox_Results.Multiline = true;
            this.txtBox_Results.Name = "txtBox_Results";
            this.txtBox_Results.Size = new System.Drawing.Size(226, 115);
            this.txtBox_Results.TabIndex = 3;
            this.txtBox_Results.Text = "Total:\r\n\r\n000000\r\n";
            // 
            // cmBox_Operator
            // 
            this.cmBox_Operator.FormattingEnabled = true;
            this.cmBox_Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmBox_Operator.Location = new System.Drawing.Point(111, 143);
            this.cmBox_Operator.Name = "cmBox_Operator";
            this.cmBox_Operator.Size = new System.Drawing.Size(121, 21);
            this.cmBox_Operator.TabIndex = 4;
            // 
            // btn_Compute
            // 
            this.btn_Compute.Location = new System.Drawing.Point(121, 343);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(75, 23);
            this.btn_Compute.TabIndex = 5;
            this.btn_Compute.Text = "Compute";
            this.btn_Compute.UseVisualStyleBackColor = true;
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 395);
            this.Controls.Add(this.btn_Compute);
            this.Controls.Add(this.cmBox_Operator);
            this.Controls.Add(this.txtBox_Results);
            this.Controls.Add(this.txtBox_number2);
            this.Controls.Add(this.txtBox_number1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_number1;
        private System.Windows.Forms.TextBox txtBox_number2;
        private System.Windows.Forms.TextBox txtBox_Results;
        private System.Windows.Forms.ComboBox cmBox_Operator;
        private System.Windows.Forms.Button btn_Compute;
    }
}