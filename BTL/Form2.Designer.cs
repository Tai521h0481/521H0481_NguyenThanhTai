namespace BTL
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnCF = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(163, 33);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(202, 23);
            this.txtNum.TabIndex = 12;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(240, 148);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(125, 64);
            this.btnCC.TabIndex = 11;
            this.btnCC.Text = "Cancel";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // btnCF
            // 
            this.btnCF.Location = new System.Drawing.Point(68, 148);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(125, 64);
            this.btnCF.TabIndex = 10;
            this.btnCF.Text = "Confirm";
            this.btnCF.UseVisualStyleBackColor = true;
            this.btnCF.Click += new System.EventHandler(this.btnCF_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(163, 84);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(202, 23);
            this.txtPIN.TabIndex = 9;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "PIN code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Credit Number";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 254);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnCC);
            this.Controls.Add(this.btnCF);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNum;
        private Button btnCC;
        private Button btnCF;
        private TextBox txtPIN;
        private Label label2;
        private Label label1;
    }
}