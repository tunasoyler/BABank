namespace BABank
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
            this.btnbankolustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmusterigeldi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxtc = new System.Windows.Forms.TextBox();
            this.lstVip = new System.Windows.Forms.ListBox();
            this.lstBireysel = new System.Windows.Forms.ListBox();
            this.lstGiseIslem = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbankolustur
            // 
            this.btnbankolustur.Location = new System.Drawing.Point(43, 29);
            this.btnbankolustur.Name = "btnbankolustur";
            this.btnbankolustur.Size = new System.Drawing.Size(144, 60);
            this.btnbankolustur.TabIndex = 0;
            this.btnbankolustur.Text = "Banka Oluştur";
            this.btnbankolustur.UseVisualStyleBackColor = true;
            this.btnbankolustur.Click += new System.EventHandler(this.btnbankolustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmusterigeldi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBoxtc);
            this.groupBox1.Location = new System.Drawing.Point(194, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnmusterigeldi
            // 
            this.btnmusterigeldi.Location = new System.Drawing.Point(235, 96);
            this.btnmusterigeldi.Name = "btnmusterigeldi";
            this.btnmusterigeldi.Size = new System.Drawing.Size(94, 29);
            this.btnmusterigeldi.TabIndex = 2;
            this.btnmusterigeldi.Text = "Müşteri Geldi";
            this.btnmusterigeldi.UseVisualStyleBackColor = true;
            this.btnmusterigeldi.Click += new System.EventHandler(this.btnmusterigeldi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // textBoxtc
            // 
            this.textBoxtc.Location = new System.Drawing.Point(69, 52);
            this.textBoxtc.Name = "textBoxtc";
            this.textBoxtc.Size = new System.Drawing.Size(261, 27);
            this.textBoxtc.TabIndex = 0;
            // 
            // lstVip
            // 
            this.lstVip.FormattingEnabled = true;
            this.lstVip.ItemHeight = 20;
            this.lstVip.Location = new System.Drawing.Point(66, 271);
            this.lstVip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstVip.Name = "lstVip";
            this.lstVip.Size = new System.Drawing.Size(121, 304);
            this.lstVip.TabIndex = 2;
            // 
            // lstBireysel
            // 
            this.lstBireysel.FormattingEnabled = true;
            this.lstBireysel.ItemHeight = 20;
            this.lstBireysel.Location = new System.Drawing.Point(235, 271);
            this.lstBireysel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBireysel.Name = "lstBireysel";
            this.lstBireysel.Size = new System.Drawing.Size(121, 304);
            this.lstBireysel.TabIndex = 3;
            // 
            // lstGiseIslem
            // 
            this.lstGiseIslem.FormattingEnabled = true;
            this.lstGiseIslem.ItemHeight = 20;
            this.lstGiseIslem.Location = new System.Drawing.Point(402, 271);
            this.lstGiseIslem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstGiseIslem.Name = "lstGiseIslem";
            this.lstGiseIslem.Size = new System.Drawing.Size(121, 304);
            this.lstGiseIslem.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(586, 29);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 547);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gişeler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 671);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lstGiseIslem);
            this.Controls.Add(this.lstBireysel);
            this.Controls.Add(this.lstVip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbankolustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnbankolustur;
        private GroupBox groupBox1;
        private Button btnmusterigeldi;
        private ComboBox comboBox1;
        private TextBox textBoxtc;
        private ListBox lstVip;
        private ListBox lstBireysel;
        private ListBox lstGiseIslem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
    }
}