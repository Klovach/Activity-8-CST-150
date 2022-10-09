namespace Activity_8
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
            this.txtCarbGrams = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalFat = new System.Windows.Forms.Label();
            this.txtCarbCalories = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalCalories = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFatGrams = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFatCalories = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCarbGrams
            // 
            this.txtCarbGrams.Location = new System.Drawing.Point(170, 140);
            this.txtCarbGrams.Name = "txtCarbGrams";
            this.txtCarbGrams.Size = new System.Drawing.Size(113, 22);
            this.txtCarbGrams.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carb Grams";
            // 
            // lblCalFat
            // 
            this.lblCalFat.AutoSize = true;
            this.lblCalFat.Location = new System.Drawing.Point(85, 276);
            this.lblCalFat.Name = "lblCalFat";
            this.lblCalFat.Size = new System.Drawing.Size(89, 16);
            this.lblCalFat.TabIndex = 5;
            this.lblCalFat.Text = "Carb Calories";
            // 
            // txtCarbCalories
            // 
            this.txtCarbCalories.Location = new System.Drawing.Point(180, 273);
            this.txtCarbCalories.Name = "txtCarbCalories";
            this.txtCarbCalories.Size = new System.Drawing.Size(113, 22);
            this.txtCarbCalories.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(81, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calories Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please enter a number value.";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(79, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 37);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Calories";
            // 
            // txtTotalCalories
            // 
            this.txtTotalCalories.Location = new System.Drawing.Point(180, 301);
            this.txtTotalCalories.Name = "txtTotalCalories";
            this.txtTotalCalories.Size = new System.Drawing.Size(113, 22);
            this.txtTotalCalories.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(79, 348);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(214, 41);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate Results";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fat Grams";
            // 
            // txtFatGrams
            // 
            this.txtFatGrams.Location = new System.Drawing.Point(170, 112);
            this.txtFatGrams.Name = "txtFatGrams";
            this.txtFatGrams.Size = new System.Drawing.Size(113, 22);
            this.txtFatGrams.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fat Calories";
            // 
            // txtFatCalories
            // 
            this.txtFatCalories.Location = new System.Drawing.Point(180, 245);
            this.txtFatCalories.Name = "txtFatCalories";
            this.txtFatCalories.Size = new System.Drawing.Size(113, 22);
            this.txtFatCalories.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Your results will appear down here.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(83, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Calculator Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 516);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFatCalories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFatGrams);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalCalories);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCalFat);
            this.Controls.Add(this.txtCarbCalories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarbGrams);
            this.Name = "Form1";
            this.Text = "Activity 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarbGrams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalFat;
        private System.Windows.Forms.TextBox txtCarbCalories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalCalories;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFatGrams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFatCalories;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

