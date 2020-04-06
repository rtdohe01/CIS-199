namespace GUIDemo_75
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
            this.PrcieOfMeal = new System.Windows.Forms.Label();
            this.priceOfMealTxt = new System.Windows.Forms.TextBox();
            this.TIPRATE1 = new System.Windows.Forms.Label();
            this.TIPRATE2 = new System.Windows.Forms.Label();
            this.TIPRATE3 = new System.Windows.Forms.Label();
            this.TIPRATE_LOW = new System.Windows.Forms.Label();
            this.TIPRATE_MEDIUM = new System.Windows.Forms.Label();
            this.TIPRATE_HIGH = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrcieOfMeal
            // 
            this.PrcieOfMeal.AutoSize = true;
            this.PrcieOfMeal.Location = new System.Drawing.Point(13, 13);
            this.PrcieOfMeal.Name = "PrcieOfMeal";
            this.PrcieOfMeal.Size = new System.Drawing.Size(198, 25);
            this.PrcieOfMeal.TabIndex = 0;
            this.PrcieOfMeal.Text = "Enter price of meal:";
            // 
            // priceOfMealTxt
            // 
            this.priceOfMealTxt.Location = new System.Drawing.Point(217, 7);
            this.priceOfMealTxt.Name = "priceOfMealTxt";
            this.priceOfMealTxt.Size = new System.Drawing.Size(129, 31);
            this.priceOfMealTxt.TabIndex = 1;
            // 
            // TIPRATE1
            // 
            this.TIPRATE1.AutoSize = true;
            this.TIPRATE1.Location = new System.Drawing.Point(156, 79);
            this.TIPRATE1.Name = "TIPRATE1";
            this.TIPRATE1.Size = new System.Drawing.Size(55, 25);
            this.TIPRATE1.TabIndex = 2;
            this.TIPRATE1.Text = "15%";
            // 
            // TIPRATE2
            // 
            this.TIPRATE2.AutoSize = true;
            this.TIPRATE2.Location = new System.Drawing.Point(156, 152);
            this.TIPRATE2.Name = "TIPRATE2";
            this.TIPRATE2.Size = new System.Drawing.Size(55, 25);
            this.TIPRATE2.TabIndex = 3;
            this.TIPRATE2.Text = "18%";
            // 
            // TIPRATE3
            // 
            this.TIPRATE3.AutoSize = true;
            this.TIPRATE3.Location = new System.Drawing.Point(156, 231);
            this.TIPRATE3.Name = "TIPRATE3";
            this.TIPRATE3.Size = new System.Drawing.Size(55, 25);
            this.TIPRATE3.TabIndex = 4;
            this.TIPRATE3.Text = "20%";
            // 
            // TIPRATE_LOW
            // 
            this.TIPRATE_LOW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIPRATE_LOW.Location = new System.Drawing.Point(217, 72);
            this.TIPRATE_LOW.Name = "TIPRATE_LOW";
            this.TIPRATE_LOW.Size = new System.Drawing.Size(129, 32);
            this.TIPRATE_LOW.TabIndex = 5;
            // 
            // TIPRATE_MEDIUM
            // 
            this.TIPRATE_MEDIUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIPRATE_MEDIUM.Location = new System.Drawing.Point(217, 143);
            this.TIPRATE_MEDIUM.Name = "TIPRATE_MEDIUM";
            this.TIPRATE_MEDIUM.Size = new System.Drawing.Size(129, 34);
            this.TIPRATE_MEDIUM.TabIndex = 6;
            // 
            // TIPRATE_HIGH
            // 
            this.TIPRATE_HIGH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIPRATE_HIGH.Location = new System.Drawing.Point(217, 221);
            this.TIPRATE_HIGH.Name = "TIPRATE_HIGH";
            this.TIPRATE_HIGH.Size = new System.Drawing.Size(129, 35);
            this.TIPRATE_HIGH.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(217, 306);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(181, 46);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Clalculate Tip";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.TIPRATE_HIGH);
            this.Controls.Add(this.TIPRATE_MEDIUM);
            this.Controls.Add(this.TIPRATE_LOW);
            this.Controls.Add(this.TIPRATE3);
            this.Controls.Add(this.TIPRATE2);
            this.Controls.Add(this.TIPRATE1);
            this.Controls.Add(this.priceOfMealTxt);
            this.Controls.Add(this.PrcieOfMeal);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrcieOfMeal;
        private System.Windows.Forms.TextBox priceOfMealTxt;
        private System.Windows.Forms.Label TIPRATE1;
        private System.Windows.Forms.Label TIPRATE2;
        private System.Windows.Forms.Label TIPRATE3;
        private System.Windows.Forms.Label TIPRATE_LOW;
        private System.Windows.Forms.Label TIPRATE_MEDIUM;
        private System.Windows.Forms.Label TIPRATE_HIGH;
        private System.Windows.Forms.Button calcBtn;
    }
}

