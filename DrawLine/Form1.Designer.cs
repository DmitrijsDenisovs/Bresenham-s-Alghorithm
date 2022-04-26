
namespace DrawLine
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
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(406, 29);
            this.x1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(88, 23);
            this.x1.TabIndex = 0;
            this.x1.TextChanged += new System.EventHandler(this.NumericInput_KeyPress);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(406, 68);
            this.y1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(88, 23);
            this.y1.TabIndex = 1;
            this.y1.TextChanged += new System.EventHandler(this.NumericInput_KeyPress);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(536, 68);
            this.y2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(88, 23);
            this.y2.TabIndex = 3;
            this.y2.TextChanged += new System.EventHandler(this.NumericInput_KeyPress);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(536, 29);
            this.x2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(88, 23);
            this.x2.TabIndex = 2;
            this.x2.TextChanged += new System.EventHandler(this.NumericInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "X2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Draw line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

