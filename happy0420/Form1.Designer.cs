namespace happy0420
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.lsbNevek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Név rögzítése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnBtnRogzitClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(70, 34);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(645, 23);
            this.txtNev.TabIndex = 2;
            // 
            // lsbNevek
            // 
            this.lsbNevek.FormattingEnabled = true;
            this.lsbNevek.ItemHeight = 15;
            this.lsbNevek.Location = new System.Drawing.Point(33, 108);
            this.lsbNevek.Name = "lsbNevek";
            this.lsbNevek.Size = new System.Drawing.Size(696, 334);
            this.lsbNevek.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 586);
            this.Controls.Add(this.lsbNevek);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtNev;
        private ListBox lsbNevek;
    }
}