namespace BTL
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
            this.btnDW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.ComboBox();
            this.btnCC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnIT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDW
            // 
            this.btnDW.Location = new System.Drawing.Point(198, 15);
            this.btnDW.Name = "btnDW";
            this.btnDW.Size = new System.Drawing.Size(112, 33);
            this.btnDW.TabIndex = 12;
            this.btnDW.Text = "Digital Wallet";
            this.btnDW.UseVisualStyleBackColor = true;
            this.btnDW.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGV);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 173);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket List";
            // 
            // dtGV
            // 
            this.dtGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGV.Location = new System.Drawing.Point(3, 19);
            this.dtGV.Name = "dtGV";
            this.dtGV.RowTemplate.Height = 25;
            this.dtGV.Size = new System.Drawing.Size(581, 151);
            this.dtGV.TabIndex = 0;
            this.dtGV.Click += new System.EventHandler(this.dtGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Destination";
            // 
            // txtDes
            // 
            this.txtDes.FormattingEnabled = true;
            this.txtDes.Items.AddRange(new object[] {
            "TP HCM",
            "Ha Noi",
            "Vung Tau",
            "Da Lat",
            "Quy Nhon",
            "Ca Mau"});
            this.txtDes.Location = new System.Drawing.Point(148, 22);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(321, 23);
            this.txtDes.TabIndex = 8;
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(69, 15);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(102, 34);
            this.btnCC.TabIndex = 7;
            this.btnCC.Text = "Credit Card";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDes);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 56);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infomation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnChange);
            this.groupBox3.Controls.Add(this.btnCC);
            this.groupBox3.Controls.Add(this.btnDW);
            this.groupBox3.Location = new System.Drawing.Point(12, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 55);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment and Function";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(339, 15);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(108, 33);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIT
            // 
            this.btnIT.Location = new System.Drawing.Point(107, 333);
            this.btnIT.Name = "btnIT";
            this.btnIT.Size = new System.Drawing.Size(149, 43);
            this.btnIT.TabIndex = 15;
            this.btnIT.Text = "Issue Ticket";
            this.btnIT.UseVisualStyleBackColor = true;
            this.btnIT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ticket Vendor Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDW;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dtGV;
        private Label label1;
        private ComboBox txtDes;
        private Button btnCC;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnIT;
        private Button button1;
        private Button btnChange;
        private Button btnSave;
    }
}