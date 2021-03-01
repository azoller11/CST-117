
namespace WinForms
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.lb_items = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_submit.Location = new System.Drawing.Point(171, 170);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(27, 170);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(118, 20);
            this.tb_input.TabIndex = 4;
            this.tb_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(252, 12);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(74, 13);
            this.lbl_text.TabIndex = 5;
            this.lbl_text.Text = "Enter a String.";
            this.lbl_text.Click += new System.EventHandler(this.lbl_text_Click);
            // 
            // lb_items
            // 
            this.lb_items.FormattingEnabled = true;
            this.lb_items.Location = new System.Drawing.Point(12, 12);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(234, 147);
            this.lb_items.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 252);
            this.Controls.Add(this.lb_items);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.btn_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.ListBox lb_items;
    }
}

