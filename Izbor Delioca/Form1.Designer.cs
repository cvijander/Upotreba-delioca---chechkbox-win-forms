namespace Izbor_Delioca
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
            this.chbDeljiviSaDva = new System.Windows.Forms.CheckBox();
            this.chbDeljiviSaTri = new System.Windows.Forms.CheckBox();
            this.chbDeljiviSaPet = new System.Windows.Forms.CheckBox();
            this.chbDeljiviSaSedam = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chbDeljiviSaDva
            // 
            this.chbDeljiviSaDva.AutoSize = true;
            this.chbDeljiviSaDva.Location = new System.Drawing.Point(42, 26);
            this.chbDeljiviSaDva.Name = "chbDeljiviSaDva";
            this.chbDeljiviSaDva.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaDva.TabIndex = 0;
            this.chbDeljiviSaDva.Text = "deljivi sa 2";
            this.chbDeljiviSaDva.UseVisualStyleBackColor = true;
            // 
            // chbDeljiviSaTri
            // 
            this.chbDeljiviSaTri.AutoSize = true;
            this.chbDeljiviSaTri.Location = new System.Drawing.Point(42, 65);
            this.chbDeljiviSaTri.Name = "chbDeljiviSaTri";
            this.chbDeljiviSaTri.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaTri.TabIndex = 1;
            this.chbDeljiviSaTri.Text = "deljivi sa 3";
            this.chbDeljiviSaTri.UseVisualStyleBackColor = true;
            // 
            // chbDeljiviSaPet
            // 
            this.chbDeljiviSaPet.AutoSize = true;
            this.chbDeljiviSaPet.Location = new System.Drawing.Point(42, 106);
            this.chbDeljiviSaPet.Name = "chbDeljiviSaPet";
            this.chbDeljiviSaPet.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaPet.TabIndex = 2;
            this.chbDeljiviSaPet.Text = "deljivi sa 5";
            this.chbDeljiviSaPet.UseVisualStyleBackColor = true;
            // 
            // chbDeljiviSaSedam
            // 
            this.chbDeljiviSaSedam.AutoSize = true;
            this.chbDeljiviSaSedam.Location = new System.Drawing.Point(39, 146);
            this.chbDeljiviSaSedam.Name = "chbDeljiviSaSedam";
            this.chbDeljiviSaSedam.Size = new System.Drawing.Size(80, 19);
            this.chbDeljiviSaSedam.TabIndex = 3;
            this.chbDeljiviSaSedam.Text = "deljivi sa 7";
            this.chbDeljiviSaSedam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Primeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(503, 23);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 330);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbDeljiviSaSedam);
            this.Controls.Add(this.chbDeljiviSaPet);
            this.Controls.Add(this.chbDeljiviSaTri);
            this.Controls.Add(this.chbDeljiviSaDva);
            this.Name = "Form1";
            this.Text = "Brojevi do 20";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chbDeljiviSaDva;
        private CheckBox chbDeljiviSaTri;
        private CheckBox chbDeljiviSaPet;
        private CheckBox chbDeljiviSaSedam;
        private Button button1;
        private TextBox textBox1;
    }
}