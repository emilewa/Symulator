namespace Projekt4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slowa = new System.Windows.Forms.TextBox();
            this.slowanabinarny = new System.Windows.Forms.TextBox();
            this.zamien1 = new System.Windows.Forms.Button();
            this.wyslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slowa
            // 
            this.slowa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.slowa.Location = new System.Drawing.Point(12, 12);
            this.slowa.Multiline = true;
            this.slowa.Name = "slowa";
            this.slowa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.slowa.Size = new System.Drawing.Size(284, 89);
            this.slowa.TabIndex = 0;
            this.slowa.TextChanged += new System.EventHandler(this.slowa_TextChanged);
            // 
            // slowanabinarny
            // 
            this.slowanabinarny.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.slowanabinarny.Location = new System.Drawing.Point(383, 12);
            this.slowanabinarny.Multiline = true;
            this.slowanabinarny.Name = "slowanabinarny";
            this.slowanabinarny.ReadOnly = true;
            this.slowanabinarny.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.slowanabinarny.Size = new System.Drawing.Size(261, 89);
            this.slowanabinarny.TabIndex = 4;
            this.slowanabinarny.TextChanged += new System.EventHandler(this.slowanabinarny_TextChanged);
            // 
            // zamien1
            // 
            this.zamien1.Location = new System.Drawing.Point(302, 12);
            this.zamien1.Name = "zamien1";
            this.zamien1.Size = new System.Drawing.Size(75, 89);
            this.zamien1.TabIndex = 5;
            this.zamien1.Text = "Zamień";
            this.zamien1.UseVisualStyleBackColor = true;
            this.zamien1.Click += new System.EventHandler(this.zamien1_Click);
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(650, 12);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(75, 89);
            this.wyslij.TabIndex = 6;
            this.wyslij.Text = "Wyślij";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Click += new System.EventHandler(this.wyslij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 114);
            this.Controls.Add(this.wyslij);
            this.Controls.Add(this.zamien1);
            this.Controls.Add(this.slowanabinarny);
            this.Controls.Add(this.slowa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox slowanabinarny;
        private System.Windows.Forms.Button zamien1;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.TextBox slowa;
    }
}

