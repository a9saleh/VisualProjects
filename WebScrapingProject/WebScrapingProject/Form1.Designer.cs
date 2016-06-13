namespace WebScrapingProject
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
            this.resultstextbox = new System.Windows.Forms.TextBox();
            this.Scrapebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultstextbox
            // 
            this.resultstextbox.Location = new System.Drawing.Point(12, 12);
            this.resultstextbox.Multiline = true;
            this.resultstextbox.Name = "resultstextbox";
            this.resultstextbox.Size = new System.Drawing.Size(379, 364);
            this.resultstextbox.TabIndex = 0;
            this.resultstextbox.TextChanged += new System.EventHandler(this.resultstextbox_TextChanged);
            // 
            // Scrapebutton
            // 
            this.Scrapebutton.Location = new System.Drawing.Point(148, 382);
            this.Scrapebutton.Name = "Scrapebutton";
            this.Scrapebutton.Size = new System.Drawing.Size(75, 23);
            this.Scrapebutton.TabIndex = 1;
            this.Scrapebutton.Text = "Scrape";
            this.Scrapebutton.UseVisualStyleBackColor = true;
            this.Scrapebutton.Click += new System.EventHandler(this.Scrapebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 419);
            this.Controls.Add(this.Scrapebutton);
            this.Controls.Add(this.resultstextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultstextbox;
        private System.Windows.Forms.Button Scrapebutton;
    }
}

