
namespace Ex1D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmountCanada = new System.Windows.Forms.TextBox();
            this.txtRateCanada = new System.Windows.Forms.TextBox();
            this.txtCAtoUS = new System.Windows.Forms.TextBox();
            this.txtEUtoUS = new System.Windows.Forms.TextBox();
            this.txtRateEurope = new System.Windows.Forms.TextBox();
            this.txtAmountEurope = new System.Windows.Forms.TextBox();
            this.txtJAtoUS = new System.Windows.Forms.TextBox();
            this.txtRateJapan = new System.Windows.Forms.TextBox();
            this.txtAmountJapan = new System.Windows.Forms.TextBox();
            this.txtUKtoUS = new System.Windows.Forms.TextBox();
            this.txtRateUnitedKingdom = new System.Windows.Forms.TextBox();
            this.txtAmountUnitedKingdom = new System.Windows.Forms.TextBox();
            this.txtUSSubtotal = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAmountCanada
            // 
            this.txtAmountCanada.Location = new System.Drawing.Point(137, 211);
            this.txtAmountCanada.Name = "txtAmountCanada";
            this.txtAmountCanada.Size = new System.Drawing.Size(168, 23);
            this.txtAmountCanada.TabIndex = 0;
            this.txtAmountCanada.Text = "0.00";
            this.txtAmountCanada.TextChanged += new System.EventHandler(this.txtAmountCanada_TextChanged);
            // 
            // txtRateCanada
            // 
            this.txtRateCanada.Location = new System.Drawing.Point(137, 249);
            this.txtRateCanada.Name = "txtRateCanada";
            this.txtRateCanada.Size = new System.Drawing.Size(168, 23);
            this.txtRateCanada.TabIndex = 1;
            this.txtRateCanada.Text = "0.76140989";
            this.txtRateCanada.TextChanged += new System.EventHandler(this.txtRateCanada_TextChanged);
            // 
            // txtCAtoUS
            // 
            this.txtCAtoUS.Location = new System.Drawing.Point(137, 287);
            this.txtCAtoUS.Name = "txtCAtoUS";
            this.txtCAtoUS.Size = new System.Drawing.Size(168, 23);
            this.txtCAtoUS.TabIndex = 2;
            this.txtCAtoUS.Text = "0.00";
            this.txtCAtoUS.TextChanged += new System.EventHandler(this.txtCAtoUS_TextChanged);
            // 
            // txtEUtoUS
            // 
            this.txtEUtoUS.Location = new System.Drawing.Point(326, 287);
            this.txtEUtoUS.Name = "txtEUtoUS";
            this.txtEUtoUS.Size = new System.Drawing.Size(168, 23);
            this.txtEUtoUS.TabIndex = 5;
            this.txtEUtoUS.Text = "0.00";
            this.txtEUtoUS.TextChanged += new System.EventHandler(this.txtEUtoUS_TextChanged);
            // 
            // txtRateEurope
            // 
            this.txtRateEurope.Location = new System.Drawing.Point(326, 249);
            this.txtRateEurope.Name = "txtRateEurope";
            this.txtRateEurope.Size = new System.Drawing.Size(168, 23);
            this.txtRateEurope.TabIndex = 4;
            this.txtRateEurope.Text = "0.99535511";
            // 
            // txtAmountEurope
            // 
            this.txtAmountEurope.Location = new System.Drawing.Point(326, 211);
            this.txtAmountEurope.Name = "txtAmountEurope";
            this.txtAmountEurope.Size = new System.Drawing.Size(168, 23);
            this.txtAmountEurope.TabIndex = 3;
            this.txtAmountEurope.Text = "0.00";
            this.txtAmountEurope.TextChanged += new System.EventHandler(this.txtAmountEurope_TextChanged);
            // 
            // txtJAtoUS
            // 
            this.txtJAtoUS.Location = new System.Drawing.Point(514, 287);
            this.txtJAtoUS.Name = "txtJAtoUS";
            this.txtJAtoUS.Size = new System.Drawing.Size(168, 23);
            this.txtJAtoUS.TabIndex = 8;
            this.txtJAtoUS.Text = "0.00";
            this.txtJAtoUS.TextChanged += new System.EventHandler(this.txtJAtoUS_TextChanged);
            // 
            // txtRateJapan
            // 
            this.txtRateJapan.Location = new System.Drawing.Point(514, 249);
            this.txtRateJapan.Name = "txtRateJapan";
            this.txtRateJapan.Size = new System.Drawing.Size(168, 23);
            this.txtRateJapan.TabIndex = 7;
            this.txtRateJapan.Text = "0.007131922";
            // 
            // txtAmountJapan
            // 
            this.txtAmountJapan.Location = new System.Drawing.Point(514, 211);
            this.txtAmountJapan.Name = "txtAmountJapan";
            this.txtAmountJapan.Size = new System.Drawing.Size(168, 23);
            this.txtAmountJapan.TabIndex = 6;
            this.txtAmountJapan.Text = "0.00";
            this.txtAmountJapan.TextChanged += new System.EventHandler(this.txtAmountJapan_TextChanged);
            // 
            // txtUKtoUS
            // 
            this.txtUKtoUS.Location = new System.Drawing.Point(702, 287);
            this.txtUKtoUS.Name = "txtUKtoUS";
            this.txtUKtoUS.Size = new System.Drawing.Size(168, 23);
            this.txtUKtoUS.TabIndex = 11;
            this.txtUKtoUS.Text = "0.00";
            this.txtUKtoUS.TextChanged += new System.EventHandler(this.txtUKtoUS_TextChanged);
            // 
            // txtRateUnitedKingdom
            // 
            this.txtRateUnitedKingdom.Location = new System.Drawing.Point(702, 249);
            this.txtRateUnitedKingdom.Name = "txtRateUnitedKingdom";
            this.txtRateUnitedKingdom.Size = new System.Drawing.Size(168, 23);
            this.txtRateUnitedKingdom.TabIndex = 10;
            this.txtRateUnitedKingdom.Text = "1.1511001";
            // 
            // txtAmountUnitedKingdom
            // 
            this.txtAmountUnitedKingdom.Location = new System.Drawing.Point(702, 211);
            this.txtAmountUnitedKingdom.Name = "txtAmountUnitedKingdom";
            this.txtAmountUnitedKingdom.Size = new System.Drawing.Size(168, 23);
            this.txtAmountUnitedKingdom.TabIndex = 9;
            this.txtAmountUnitedKingdom.Text = "0.00";
            this.txtAmountUnitedKingdom.TextChanged += new System.EventHandler(this.txtAmountUnitedKingdom_TextChanged);
            // 
            // txtUSSubtotal
            // 
            this.txtUSSubtotal.Location = new System.Drawing.Point(953, 287);
            this.txtUSSubtotal.Name = "txtUSSubtotal";
            this.txtUSSubtotal.Size = new System.Drawing.Size(168, 23);
            this.txtUSSubtotal.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(326, 362);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(514, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "$US:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(137, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 129);
            this.button3.TabIndex = 19;
            this.button3.Text = "Canada";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(326, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 129);
            this.button4.TabIndex = 20;
            this.button4.Text = "Europe";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(514, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 129);
            this.button5.TabIndex = 21;
            this.button5.Text = "Japan";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(702, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 129);
            this.button6.TabIndex = 22;
            this.button6.Text = "United Kingdom";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(953, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 129);
            this.button7.TabIndex = 23;
            this.button7.Text = "Very Self Explanatory Flag";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(789, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 456);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtUSSubtotal);
            this.Controls.Add(this.txtUKtoUS);
            this.Controls.Add(this.txtRateUnitedKingdom);
            this.Controls.Add(this.txtAmountUnitedKingdom);
            this.Controls.Add(this.txtJAtoUS);
            this.Controls.Add(this.txtRateJapan);
            this.Controls.Add(this.txtAmountJapan);
            this.Controls.Add(this.txtEUtoUS);
            this.Controls.Add(this.txtRateEurope);
            this.Controls.Add(this.txtAmountEurope);
            this.Controls.Add(this.txtCAtoUS);
            this.Controls.Add(this.txtRateCanada);
            this.Controls.Add(this.txtAmountCanada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountCanada;
        private System.Windows.Forms.TextBox txtRateCanada;
        private System.Windows.Forms.TextBox txtCAtoUS;
        private System.Windows.Forms.TextBox txtEUtoUS;
        private System.Windows.Forms.TextBox txtRateEurope;
        private System.Windows.Forms.TextBox txtAmountEurope;
        private System.Windows.Forms.TextBox txtJAtoUS;
        private System.Windows.Forms.TextBox txtRateJapan;
        private System.Windows.Forms.TextBox txtAmountJapan;
        private System.Windows.Forms.TextBox txtUKtoUS;
        private System.Windows.Forms.TextBox txtRateUnitedKingdom;
        private System.Windows.Forms.TextBox txtAmountUnitedKingdom;
        private System.Windows.Forms.TextBox txtUSSubtotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

