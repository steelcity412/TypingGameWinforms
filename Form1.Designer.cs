namespace TypingGame
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
            this.lblright = new System.Windows.Forms.Label();
            this.lblwrong = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblright
            // 
            this.lblright.AutoSize = true;
            this.lblright.Location = new System.Drawing.Point(12, 9);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(58, 15);
            this.lblright.TabIndex = 0;
            this.lblright.Text = "Correct: 0";
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.Location = new System.Drawing.Point(734, 19);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(66, 15);
            this.lblwrong.TabIndex = 1;
            this.lblwrong.Text = "Incorrect: 0";
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblword.Location = new System.Drawing.Point(322, 116);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(121, 51);
            this.lblword.TabIndex = 2;
            this.lblword.Text = "Word";
            this.lblword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Press enter to check the text with word";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(74, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 57);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.lblright);
            this.Name = "Form1";
            this.Text = "Typing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblright;
        private Label lblwrong;
        private Label lblword;
        private Label label4;
        private TextBox textBox1;
    }
}