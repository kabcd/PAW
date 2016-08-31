namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.lb_codL = new System.Windows.Forms.Label();
            this.lb_denumL = new System.Windows.Forms.Label();
            this.lb_sectiuni = new System.Windows.Forms.Label();
            this.tb_codL = new System.Windows.Forms.TextBox();
            this.tb_denumL = new System.Windows.Forms.TextBox();
            this.tb_sectiuni = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_codL
            // 
            this.lb_codL.AutoSize = true;
            this.lb_codL.Location = new System.Drawing.Point(44, 54);
            this.lb_codL.Name = "lb_codL";
            this.lb_codL.Size = new System.Drawing.Size(31, 13);
            this.lb_codL.TabIndex = 0;
            this.lb_codL.Text = "codL";
            // 
            // lb_denumL
            // 
            this.lb_denumL.AutoSize = true;
            this.lb_denumL.Location = new System.Drawing.Point(44, 87);
            this.lb_denumL.Name = "lb_denumL";
            this.lb_denumL.Size = new System.Drawing.Size(45, 13);
            this.lb_denumL.TabIndex = 1;
            this.lb_denumL.Text = "denumL";
            // 
            // lb_sectiuni
            // 
            this.lb_sectiuni.AutoSize = true;
            this.lb_sectiuni.Location = new System.Drawing.Point(44, 119);
            this.lb_sectiuni.Name = "lb_sectiuni";
            this.lb_sectiuni.Size = new System.Drawing.Size(43, 13);
            this.lb_sectiuni.TabIndex = 2;
            this.lb_sectiuni.Text = "sectiuni";
            // 
            // tb_codL
            // 
            this.tb_codL.Location = new System.Drawing.Point(125, 54);
            this.tb_codL.Name = "tb_codL";
            this.tb_codL.Size = new System.Drawing.Size(100, 20);
            this.tb_codL.TabIndex = 3;
            // 
            // tb_denumL
            // 
            this.tb_denumL.Location = new System.Drawing.Point(125, 84);
            this.tb_denumL.Name = "tb_denumL";
            this.tb_denumL.Size = new System.Drawing.Size(100, 20);
            this.tb_denumL.TabIndex = 4;
            // 
            // tb_sectiuni
            // 
            this.tb_sectiuni.Location = new System.Drawing.Point(125, 116);
            this.tb_sectiuni.Name = "tb_sectiuni";
            this.tb_sectiuni.Size = new System.Drawing.Size(100, 20);
            this.tb_sectiuni.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(47, 173);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(159, 173);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_sectiuni);
            this.Controls.Add(this.tb_denumL);
            this.Controls.Add(this.tb_codL);
            this.Controls.Add(this.lb_sectiuni);
            this.Controls.Add(this.lb_denumL);
            this.Controls.Add(this.lb_codL);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_codL;
        private System.Windows.Forms.Label lb_denumL;
        private System.Windows.Forms.Label lb_sectiuni;
        private System.Windows.Forms.TextBox tb_codL;
        private System.Windows.Forms.TextBox tb_denumL;
        private System.Windows.Forms.TextBox tb_sectiuni;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}