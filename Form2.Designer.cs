namespace Projekt4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.binarne = new System.Windows.Forms.TextBox();
            this.binarnenaslowa = new System.Windows.Forms.TextBox();
            this.zamien2 = new System.Windows.Forms.Button();
            this.cenzura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binarne
            // 
            this.binarne.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.binarne.Location = new System.Drawing.Point(12, 12);
            this.binarne.Multiline = true;
            this.binarne.Name = "binarne";
            this.binarne.ReadOnly = true;
            this.binarne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binarne.Size = new System.Drawing.Size(284, 89);
            this.binarne.TabIndex = 4;
            // 
            // binarnenaslowa
            // 
            this.binarnenaslowa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.binarnenaslowa.Location = new System.Drawing.Point(383, 12);
            this.binarnenaslowa.Multiline = true;
            this.binarnenaslowa.Name = "binarnenaslowa";
            this.binarnenaslowa.ReadOnly = true;
            this.binarnenaslowa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binarnenaslowa.Size = new System.Drawing.Size(264, 89);
            this.binarnenaslowa.TabIndex = 5;
            // 
            // zamien2
            // 
            this.zamien2.Location = new System.Drawing.Point(302, 12);
            this.zamien2.Name = "zamien2";
            this.zamien2.Size = new System.Drawing.Size(75, 89);
            this.zamien2.TabIndex = 6;
            this.zamien2.Text = "Zamień";
            this.zamien2.UseVisualStyleBackColor = true;
            this.zamien2.Click += new System.EventHandler(this.zamien2_Click);
            // 
            // cenzura
            // 
            this.cenzura.Location = new System.Drawing.Point(653, 12);
            this.cenzura.Name = "cenzura";
            this.cenzura.Size = new System.Drawing.Size(75, 89);
            this.cenzura.TabIndex = 7;
            this.cenzura.Text = "Cenzuruj!!";
            this.cenzura.UseVisualStyleBackColor = true;
            this.cenzura.Click += new System.EventHandler(this.cenzura_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 115);
            this.Controls.Add(this.cenzura);
            this.Controls.Add(this.zamien2);
            this.Controls.Add(this.binarnenaslowa);
            this.Controls.Add(this.binarne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox binarne;
        public System.Windows.Forms.TextBox binarnenaslowa;
        private System.Windows.Forms.Button zamien2;
        private System.Windows.Forms.Button cenzura;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}