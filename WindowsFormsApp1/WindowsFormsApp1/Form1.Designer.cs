namespace QuizzApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radioBtnChoice1 = new System.Windows.Forms.RadioButton();
            this.radioBtnChoice2 = new System.Windows.Forms.RadioButton();
            this.radioBtnChoice3 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblQuestion
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";

            // radioBtnChoice1
            this.radioBtnChoice1.AutoSize = true;
            this.radioBtnChoice1.Location = new System.Drawing.Point(15, 53);
            this.radioBtnChoice1.Name = "radioBtnChoice1";
            this.radioBtnChoice1.Size = new System.Drawing.Size(85, 17);
            this.radioBtnChoice1.TabIndex = 1;
            this.radioBtnChoice1.TabStop = true;
            this.radioBtnChoice1.Text = "radioButton1";
            this.radioBtnChoice1.UseVisualStyleBackColor = true;

            // radioBtnChoice2
            this.radioBtnChoice2.AutoSize = true;
            this.radioBtnChoice2.Location = new System.Drawing.Point(15, 90);
            this.radioBtnChoice2.Name = "radioBtnChoice2";
            this.radioBtnChoice2.Size = new System.Drawing.Size(85, 17);
            this.radioBtnChoice2.TabIndex = 2;
            this.radioBtnChoice2.TabStop = true;
            this.radioBtnChoice2.Text = "radioButton2";
            this.radioBtnChoice2.UseVisualStyleBackColor = true;

            // radioBtnChoice3
            this.radioBtnChoice3.AutoSize = true;
            this.radioBtnChoice3.Location = new System.Drawing.Point(15, 127);
            this.radioBtnChoice3.Name = "radioBtnChoice3";
            this.radioBtnChoice3.Size = new System.Drawing.Size(85, 17);
            this.radioBtnChoice3.TabIndex = 3;
            this.radioBtnChoice3.TabStop = true;
            this.radioBtnChoice3.Text = "radioButton3";
            this.radioBtnChoice3.UseVisualStyleBackColor = true;

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(15, 168);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Soumettre";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.radioBtnChoice3);
            this.Controls.Add(this.radioBtnChoice2);
            this.Controls.Add(this.radioBtnChoice1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "MainForm";
            this.Text = "QuizzApp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radioBtnChoice1;
        private System.Windows.Forms.RadioButton radioBtnChoice2;
        private System.Windows.Forms.RadioButton radioBtnChoice3;
        private System.Windows.Forms.Button btnSubmit;
    }
}
