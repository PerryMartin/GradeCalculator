namespace GradeCalculator
{
    partial class frmGardeCal
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
            this.lblEntGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnCalculater = new System.Windows.Forms.Button();
            this.lblOuput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEntGrade
            // 
            this.lblEntGrade.AutoSize = true;
            this.lblEntGrade.Location = new System.Drawing.Point(98, 11);
            this.lblEntGrade.Name = "lblEntGrade";
            this.lblEntGrade.Size = new System.Drawing.Size(62, 16);
            this.lblEntGrade.TabIndex = 0;
            this.lblEntGrade.Text = "Enter Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(85, 49);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 21);
            this.txtGrade.TabIndex = 1;
            // 
            // btnCalculater
            // 
            this.btnCalculater.Location = new System.Drawing.Point(101, 104);
            this.btnCalculater.Name = "btnCalculater";
            this.btnCalculater.Size = new System.Drawing.Size(75, 23);
            this.btnCalculater.TabIndex = 2;
            this.btnCalculater.Text = "Calculator";
            this.btnCalculater.UseVisualStyleBackColor = true;
            this.btnCalculater.Click += new System.EventHandler(this.btnCalculater_Click);
            // 
            // lblOuput
            // 
            this.lblOuput.AutoSize = true;
            this.lblOuput.Location = new System.Drawing.Point(123, 169);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(0, 16);
            this.lblOuput.TabIndex = 3;
            // 
            // frmGardeCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 226);
            this.Controls.Add(this.lblOuput);
            this.Controls.Add(this.btnCalculater);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblEntGrade);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGardeCal";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnCalculater;
        private System.Windows.Forms.Label lblOuput;
    }
}

