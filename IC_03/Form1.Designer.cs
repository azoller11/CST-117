
namespace IC_03
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.tb_enterWeight = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.tb_newWeight = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(17, 58);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(132, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Enter your weight on Earth";
            this.lbl_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_enterWeight
            // 
            this.tb_enterWeight.Location = new System.Drawing.Point(165, 60);
            this.tb_enterWeight.Name = "tb_enterWeight";
            this.tb_enterWeight.Size = new System.Drawing.Size(147, 20);
            this.tb_enterWeight.TabIndex = 1;
            this.tb_enterWeight.TextChanged += new System.EventHandler(this.tb_enterWeight_TextChanged);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(23, 132);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(104, 13);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "Your weight on Mars";
            // 
            // tb_newWeight
            // 
            this.tb_newWeight.Location = new System.Drawing.Point(165, 125);
            this.tb_newWeight.Name = "tb_newWeight";
            this.tb_newWeight.Size = new System.Drawing.Size(147, 20);
            this.tb_newWeight.TabIndex = 3;
            this.tb_newWeight.TextChanged += new System.EventHandler(this.tb_newWeight_TextChanged);
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(236, 209);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 312);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.tb_newWeight);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.tb_enterWeight);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox tb_enterWeight;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox tb_newWeight;
        private System.Windows.Forms.Button btn_convert;
    }
}

