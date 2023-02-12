namespace WinForms.Calculator
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
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_dziel = new System.Windows.Forms.Button();
            this.button_clearentry = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_mnoz = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_rowna = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_7.Location = new System.Drawing.Point(22, 98);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(50, 50);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_8.Location = new System.Drawing.Point(78, 98);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(50, 50);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_9.Location = new System.Drawing.Point(134, 98);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(50, 50);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_click);
            // 
            // button_dziel
            // 
            this.button_dziel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_dziel.Location = new System.Drawing.Point(190, 98);
            this.button_dziel.Name = "button_dziel";
            this.button_dziel.Size = new System.Drawing.Size(50, 50);
            this.button_dziel.TabIndex = 3;
            this.button_dziel.Text = "/";
            this.button_dziel.UseVisualStyleBackColor = true;
            this.button_dziel.Click += new System.EventHandler(this.operator_click);
            // 
            // button_clearentry
            // 
            this.button_clearentry.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clearentry.Location = new System.Drawing.Point(246, 98);
            this.button_clearentry.Name = "button_clearentry";
            this.button_clearentry.Size = new System.Drawing.Size(50, 50);
            this.button_clearentry.TabIndex = 4;
            this.button_clearentry.Text = "CE";
            this.button_clearentry.UseVisualStyleBackColor = true;
            this.button_clearentry.Click += new System.EventHandler(this.button_clearentry_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(246, 154);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(50, 50);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_mnoz
            // 
            this.button_mnoz.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_mnoz.Location = new System.Drawing.Point(190, 154);
            this.button_mnoz.Name = "button_mnoz";
            this.button_mnoz.Size = new System.Drawing.Size(50, 50);
            this.button_mnoz.TabIndex = 8;
            this.button_mnoz.Text = "*";
            this.button_mnoz.UseVisualStyleBackColor = true;
            this.button_mnoz.Click += new System.EventHandler(this.operator_click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_6.Location = new System.Drawing.Point(134, 154);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(50, 50);
            this.button_6.TabIndex = 7;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_5.Location = new System.Drawing.Point(78, 154);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(50, 50);
            this.button_5.TabIndex = 6;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_4.Location = new System.Drawing.Point(22, 154);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(50, 50);
            this.button_4.TabIndex = 5;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_minus.Location = new System.Drawing.Point(190, 210);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(50, 50);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.operator_click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_3.Location = new System.Drawing.Point(134, 210);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(50, 50);
            this.button_3.TabIndex = 12;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_2.Location = new System.Drawing.Point(78, 210);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(50, 50);
            this.button_2.TabIndex = 11;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1.Location = new System.Drawing.Point(22, 210);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(50, 50);
            this.button_1.TabIndex = 10;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_click);
            // 
            // button_rowna
            // 
            this.button_rowna.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_rowna.Location = new System.Drawing.Point(246, 210);
            this.button_rowna.Name = "button_rowna";
            this.button_rowna.Size = new System.Drawing.Size(50, 106);
            this.button_rowna.TabIndex = 19;
            this.button_rowna.Text = "=";
            this.button_rowna.UseVisualStyleBackColor = true;
            this.button_rowna.Click += new System.EventHandler(this.button_rowna_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_plus.Location = new System.Drawing.Point(190, 266);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(50, 50);
            this.button_plus.TabIndex = 18;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.operator_click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_dot.Location = new System.Drawing.Point(134, 266);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(50, 50);
            this.button_dot.TabIndex = 17;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_0.Location = new System.Drawing.Point(22, 266);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(106, 50);
            this.button_0.TabIndex = 15;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(22, 58);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(274, 23);
            this.textBox_result.TabIndex = 20;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentOperation.Location = new System.Drawing.Point(22, 25);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 30);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 333);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_rowna);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_mnoz);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_clearentry);
            this.Controls.Add(this.button_dziel);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_dziel;
        private Button button_clearentry;
        private Button button_clear;
        private Button button_mnoz;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_minus;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private Button button_rowna;
        private Button button_plus;
        private Button button_dot;
        private Button button_0;
        private TextBox textBox_result;
        private Label labelCurrentOperation;
    }
}