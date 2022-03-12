namespace Calculator
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
            this.seven_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.times_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.decimal_button = new System.Windows.Forms.Button();
            this.subtract_button = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.equals_button = new System.Windows.Forms.Button();
            this.previous_number_n_operator = new System.Windows.Forms.Label();
            this.result_display = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seven_button
            // 
            this.seven_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_button.Location = new System.Drawing.Point(19, 95);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(45, 45);
            this.seven_button.TabIndex = 0;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // eight_button
            // 
            this.eight_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_button.Location = new System.Drawing.Point(70, 95);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(45, 45);
            this.eight_button.TabIndex = 1;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // nine_button
            // 
            this.nine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_button.Location = new System.Drawing.Point(121, 95);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(45, 45);
            this.nine_button.TabIndex = 2;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // times_button
            // 
            this.times_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times_button.Location = new System.Drawing.Point(172, 197);
            this.times_button.Name = "times_button";
            this.times_button.Size = new System.Drawing.Size(45, 45);
            this.times_button.TabIndex = 3;
            this.times_button.Text = "*";
            this.times_button.UseVisualStyleBackColor = true;
            this.times_button.Click += new System.EventHandler(this.operator_clicked);
            // 
            // divide_button
            // 
            this.divide_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_button.Location = new System.Drawing.Point(172, 248);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(45, 45);
            this.divide_button.TabIndex = 7;
            this.divide_button.Text = "/";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.operator_clicked);
            // 
            // six_button
            // 
            this.six_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_button.Location = new System.Drawing.Point(121, 146);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(45, 45);
            this.six_button.TabIndex = 6;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // five_button
            // 
            this.five_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_button.Location = new System.Drawing.Point(70, 146);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(45, 45);
            this.five_button.TabIndex = 5;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // four_button
            // 
            this.four_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_button.Location = new System.Drawing.Point(19, 146);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(45, 45);
            this.four_button.TabIndex = 4;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(172, 146);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(45, 45);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.operator_clicked);
            // 
            // three_button
            // 
            this.three_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_button.Location = new System.Drawing.Point(121, 197);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(45, 45);
            this.three_button.TabIndex = 10;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // two_button
            // 
            this.two_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_button.Location = new System.Drawing.Point(70, 197);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(45, 45);
            this.two_button.TabIndex = 9;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // one_button
            // 
            this.one_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_button.Location = new System.Drawing.Point(19, 197);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(45, 45);
            this.one_button.TabIndex = 8;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.number_clicked);
            // 
            // decimal_button
            // 
            this.decimal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimal_button.Location = new System.Drawing.Point(121, 248);
            this.decimal_button.Name = "decimal_button";
            this.decimal_button.Size = new System.Drawing.Size(45, 45);
            this.decimal_button.TabIndex = 12;
            this.decimal_button.Text = ",";
            this.decimal_button.UseVisualStyleBackColor = true;
            this.decimal_button.Click += new System.EventHandler(this.decimal_clicked);
            // 
            // subtract_button
            // 
            this.subtract_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract_button.Location = new System.Drawing.Point(172, 95);
            this.subtract_button.Name = "subtract_button";
            this.subtract_button.Size = new System.Drawing.Size(45, 45);
            this.subtract_button.TabIndex = 13;
            this.subtract_button.Text = "-";
            this.subtract_button.UseVisualStyleBackColor = true;
            this.subtract_button.Click += new System.EventHandler(this.operator_clicked);
            // 
            // button15
            // 
            this.button15.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(223, 95);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(45, 45);
            this.button15.TabIndex = 14;
            this.button15.Text = "C";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.clear_clicked);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(223, 146);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 45);
            this.button16.TabIndex = 15;
            this.button16.Text = "CE";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.CE_clicked);
            // 
            // zero_button
            // 
            this.zero_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_button.Location = new System.Drawing.Point(70, 248);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(45, 45);
            this.zero_button.TabIndex = 16;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.zero_clicked);
            // 
            // equals_button
            // 
            this.equals_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals_button.Location = new System.Drawing.Point(223, 197);
            this.equals_button.Name = "equals_button";
            this.equals_button.Size = new System.Drawing.Size(45, 96);
            this.equals_button.TabIndex = 17;
            this.equals_button.Text = "=";
            this.equals_button.UseVisualStyleBackColor = true;
            this.equals_button.Click += new System.EventHandler(this.equal_clicked);
            // 
            // previous_number_n_operator
            // 
            this.previous_number_n_operator.AutoSize = true;
            this.previous_number_n_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_number_n_operator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.previous_number_n_operator.Location = new System.Drawing.Point(15, 24);
            this.previous_number_n_operator.Name = "previous_number_n_operator";
            this.previous_number_n_operator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previous_number_n_operator.Size = new System.Drawing.Size(60, 24);
            this.previous_number_n_operator.TabIndex = 18;
            this.previous_number_n_operator.Text = "label1";
            // 
            // result_display
            // 
            this.result_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_display.Location = new System.Drawing.Point(19, 51);
            this.result_display.Name = "result_display";
            this.result_display.ReadOnly = true;
            this.result_display.Size = new System.Drawing.Size(249, 35);
            this.result_display.TabIndex = 20;
            this.result_display.Text = "0";
            this.result_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(19, 249);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(45, 44);
            this.button19.TabIndex = 21;
            this.button19.Text = "+/-";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.negative_positive_convert);
            // 
            // Form1
            // 
            this.AcceptButton = this.equals_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button15;
            this.ClientSize = new System.Drawing.Size(289, 310);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.result_display);
            this.Controls.Add(this.previous_number_n_operator);
            this.Controls.Add(this.equals_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.subtract_button);
            this.Controls.Add(this.decimal_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.times_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.seven_button);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 349);
            this.MinimumSize = new System.Drawing.Size(305, 349);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button times_button;
        private System.Windows.Forms.Button divide_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button decimal_button;
        private System.Windows.Forms.Button subtract_button;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button equals_button;
        private System.Windows.Forms.Label previous_number_n_operator;
        private System.Windows.Forms.TextBox result_display;
        private System.Windows.Forms.Button button19;
    }
}

